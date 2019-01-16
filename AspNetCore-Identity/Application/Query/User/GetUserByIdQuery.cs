using FluentValidation.Results;
using Identity.Service.Application.Common;
using Identity.Service.Application.Query.User.Dto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Query.User
{
    /// <summary>
    /// This query retrieves a user by it's Id. Return type <see cref="Response{AccountDTO}}"/>
    /// </summary>
    public class GetUserByIdQuery : IRequest<Response<AccountDTO>>
    {
        public string Id { get; set; }

        internal class GetUserAccountQueryHandler : IRequestHandler<GetUserByIdQuery, Response<AccountDTO>>
        {
            public GetUserAccountQueryHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<AccountDTO>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByIdAsync(request.Id);

                if (user == null)
                    return Response<AccountDTO>.Fail(new ValidationFailure("", $"There is no owner that matches the ID {request.Id}."));

                return Response<AccountDTO>.Ok(new AccountDTO {
                    Id = user.Id,
                    Email = user.Email,
                    Username = user.UserName,
                    IsBlocked = user.IsBlocked,
                    EmailConfirmed = user.EmailConfirmed,
                    LockoutEnabled = user.LockoutEnabled,
                    PhoneNumber = user.PhoneNumber,
                    PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                    TwoFactorEnabled = user.TwoFactorEnabled,
                    IsAdmin = user.IsAdmin,
                    AccessFailedCount = user.AccessFailedCount
                });
            }
    }
    }
}
