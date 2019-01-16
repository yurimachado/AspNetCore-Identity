using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Validations.Commands.User;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Identity.Service.Application;
using Identity.Service.Application.Validations.Identity;
using System;
using Identity.Service.Application.Identity.Token;
using ScottBrady91.AspNetCore.Identity;
using Identity.Service.Application.Identity.Store;
using Raven.Client.Documents;
using Identity.Service.Application.Identity;
using Microsoft.Extensions.Options;
using Identity.Service.Application.Identity.Repository;
using Identity.Service.Application.Services.Email;
using Identity.Service.Services.Email;

namespace Identity.Service
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public bool SmtpEnabled { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddLogging();
            this.SmtpEnabled = this.Configuration.GetValue<bool>("SmtpEnabled");

            // Configure RavenDB options and store holder
            services.AddSingleton<IDocumentStore, DocumentStore>(provider => {
                var settings = provider.GetService<IOptions<RavenSettings>>().Value;
                return new DocumentStore { Database = settings.Database, Urls = new[] { settings.Url } };
            });

            services.Configure<RavenSettings>(Configuration.GetSection("Raven"));
            services.AddSingleton<IIdentityDocumentStoreHolder, IdentityDocumentStoreHolder>();

            services.AddScoped<IRepository<ApplicationUser, string>, ApplicationUserRepository>(); 

            services.AddIdentityCore<ApplicationUser>(options => {
                options.Tokens.EmailConfirmationTokenProvider = "EmailTokenProvider";
                
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                })
                .AddRoles<ApplicationRole>()
                .AddRavenDBDataStoreAdaptor<IIdentityDocumentStoreHolder>()
                .AddUserManager<ApplicationUserManager>()
                .AddDefaultTokenProviders() // Only for Reset Password Token
                .AddTokenProvider<EmailConfirmationTokenProvider<ApplicationUser>>("EmailTokenProvider")
                .AddRoleManager<RoleManager<ApplicationRole>>()
                .AddPasswordValidator<BasicPasswordValidator<ApplicationUser>>();

            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddCookie(IdentityConstants.ApplicationScheme, options => options.LoginPath = "/Account/Login");

            services.Configure<PasswordHasherOptions>(options => options.IterationCount = 100000);

            services.Configure<DataProtectionTokenProviderOptions>(options => {
                options.TokenLifespan = TimeSpan.FromHours(3); //Expire time for reset Password Token
            });

            services.Configure<DataProtectionTokenProviderOptions>(options => {
                options.TokenLifespan = TimeSpan.FromDays(2); //Expire time for Email Confirmation Token
            });

            services.AddScoped<IPasswordHasher<ApplicationUser>, Argon2PasswordHasher<ApplicationUser>>();

            services.AddSingleton<NotificationConfiguration>(provider => {
                var config = Configuration.GetSection("NotificationConfiguration").Get<NotificationConfiguration>();
                if (config != null)
                    return config;
                return new NotificationConfiguration();
            });

            services.AddScoped<IViewRenderService, ViewRenderService>();
            services.AddScoped<IEmailContentProvider<UserRegisteredNotification>, EmailConfirmationContentProvider>();
            services.AddScoped<IEmailContentProvider<PasswordResetHasBeenGeneratedNotification>, ResetPasswordEmailContentProvider>();
            services.AddScoped<IEmailContentProvider<UserLockoutNotification>, UserLockoutEmailContentProvider>();

            if (this.SmtpEnabled) {
                services.Configure<SmtpSettings>(Configuration.GetSection("Smtp"));
                services.AddTransient<IEmailSender, EmailSender>();
            } else {
                services.AddTransient<IEmailSender, FakeEmailSender>();
            }

            services.AddMediatR();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            .AddFluentValidation(fv =>{
                 fv.RegisterValidatorsFromAssemblyContaining<AddUserCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<EditUserCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<EditUserProfileCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<RegisterUserCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<ResetPasswordCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<AuthenticateUserCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<ConfirmEmailCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<ResendEmailConfirmationCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<GenerateConfirmPasswordTokenCommandValidator>();
                 //fv.RegisterValidatorsFromAssemblyContaining<GenerateResetPasswordTokenCommandValidator>();
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } else
            {
                app.UseHsts();
            }
            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}");
            });
        }
    }
}
