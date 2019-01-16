using Identity.Service.Application.Commands.User;
using Identity.Service.Application.Services.Email.Models;
using Identity.Service.Models;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.Service.Controllers
{
    public class AccountController : ControllerBase
    {
        public AccountController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public IActionResult Login(string returnUrl) => View(new AuthenticateUserCommand { ReturnUrl = returnUrl });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthenticateUserCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure)
            {
                ModelState.AddModelErrors(response.Errors);
                command.Password = string.Empty;
                command.ConfirmPassword = string.Empty;

                return View(command);
            }
            var user = response.Result;
            var role = user.RoleName;
            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Sid, user.Id),
                new Claim(ClaimTypes.Role, (role != null ? role : "Guest")),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            await AuthenticationHttpContextExtensions.SignInAsync(HttpContext, IdentityConstants.ApplicationScheme, new ClaimsPrincipal(
                new ClaimsIdentity(claims, IdentityConstants.ApplicationScheme)), 
                new AuthenticationProperties {
                    IsPersistent = command.RememberMe
                });

            if (!string.IsNullOrEmpty(command.ReturnUrl))
                return Redirect(command.ReturnUrl);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout() {
            await AuthenticationHttpContextExtensions.SignOutAsync(HttpContext, IdentityConstants.ApplicationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register() => View(new RegisterUserCommand());

        [HttpGet]
        public IActionResult Registered(string email)
        {
            return View(new ResendEmailConfirmationCommand { Email = email });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResendEmail(ResendEmailConfirmationCommand command)
        {
            if (ModelState.IsValid)
                await this.Mediator.Send(command);

            return View("Registered", command);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure) {
                ModelState.AddModelErrors(response.Errors);
                return View(new RegisterUserCommand { Email = command.Email, Username = command.Username });
            }

            return RedirectToAction("Registered",  new { email = command.Email });
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation(string token, string email) {
            var response = await this.Mediator.Send(new ConfirmEmailCommand { ConfirmEmailToken = token, Email = email });

            if (response.IsFailure) 
                ModelState.AddModelError("", "Invalid request.");

            return View();
        }

        [HttpGet]
        public IActionResult Forgot() => View(new GenerateResetPasswordTokenCommand());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Forgot(GenerateResetPasswordTokenCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            return RedirectToAction("Result", new ResultViewModel
            {
                IsSuccess = true,
                Title = "Forgot Password",
                Description = "You can reset your password",
                Messages = new List<string>()
                    {
                        $"We've sent a reset password message to {command.Email}!"
                    }
            });
        }

        [HttpGet]
        public IActionResult Reset(string token, string email) => View(new ResetPasswordCommand { ResetPasswordToken = token, Email = email });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reset(ResetPasswordCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure)
            {
                ModelState.AddModelErrors(response.Errors);
                command.NewPassword = string.Empty;
                command.ConfirmNewPassword = string.Empty;

                return View(command);
            }

            return RedirectToAction("Result", new ResultViewModel
            {
                IsSuccess = true,
                Title = "Reset Password",
                Description = "You can reset your password",
                Messages = new List<string>()
                    {
                        "You're password has been successfully changed!"
                    }
            });
        }

        [HttpGet]
        public IActionResult Result(ResultViewModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterConfirmationEmail(RegisterConfirmationEmailViewModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult ResetPasswordEmail(ResetPasswordEmailViewModel model)
        {
            return View(model);
        }
    }
}
