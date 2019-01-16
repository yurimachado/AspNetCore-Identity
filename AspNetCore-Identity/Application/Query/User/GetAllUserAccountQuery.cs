using FluentValidation.Results;
using Identity.Service.Application.Common;
using Identity.Service.Application.Query.User.Dto;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Query.User
{
    /// <summary>
    /// This query retrieves all registered users. Return type: <see cref="Response{ICollection{AccountDTO}}."/>
    /// </summary>
    public class GetAllUserAccountQuery : IRequest<Response<ICollection<AccountDTO>>>
    {
        public string OwnerId { get; set; }
        public string OwnerRole { get; set; }

        internal class GetAllUserAccountQueryHandler : IRequestHandler<GetAllUserAccountQuery, Response<ICollection<AccountDTO>>>
        {

            public GetAllUserAccountQueryHandler(ApplicationUserManager userManager, IRepository<ApplicationUser, string> repository)
            {
                this.UserManager = userManager;
                this.Repository = repository;
            }

            public ApplicationUserManager UserManager { get; }
            public IRepository<ApplicationUser, string> Repository { get; }

            public async Task<Response<ICollection<AccountDTO>>> Handle(GetAllUserAccountQuery request, CancellationToken cancellationToken)
            {
                var ownerUser = await this.UserManager.FindByIdAsync(request.OwnerId);
                
                if (ownerUser == null)
                    return Response<ICollection<AccountDTO>>.Fail(new ValidationFailure("", $"There is no owner that matches the ID {request.OwnerId}."));
                var accountsDTO = new List<AccountDTO>();
                if (!ownerUser.IsAdmin)
                    return Response<ICollection<AccountDTO>>.Ok(accountsDTO);
                var accounts = await this.Repository.AllAsync(CancellationToken.None);
                foreach (var user in accounts) {
                    accountsDTO.Add(new AccountDTO {
                        Id = user.Id,
                        Email = user.Email,
                        Username = user.UserName,
                        IsBlocked = user.IsBlocked,
                        AccessFailedCount = user.AccessFailedCount,
                        EmailConfirmed = user.EmailConfirmed,
                        LockoutEnabled = user.LockoutEnabled,
                        PhoneNumber = user.PhoneNumber,
                        PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                        TwoFactorEnabled = user.TwoFactorEnabled,
                        IsAdmin = user.IsAdmin
                    });
                }

                return Response<ICollection<AccountDTO>>.Ok(accountsDTO);
            }
        }
    }
}
