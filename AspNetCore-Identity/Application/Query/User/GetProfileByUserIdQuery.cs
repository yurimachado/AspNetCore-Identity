using FluentValidation.Results;
using Identity.Service.Application.Common;
using Identity.Service.Application.Query.User.Dto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Query.User
{
    /// <summary>
    /// This query retrieves an user's profile based on it's Id. Return type: <see cref="Response{ProfileDTO}"/>
    /// </summary>
    public class GetProfileByUserIdQuery : IRequest<Response<ProfileDTO>>
    {
        public string UserId { get; set; }

        internal class GetProfileByUserIdQueryHandler : IRequestHandler<GetProfileByUserIdQuery, Response<ProfileDTO>>
        {
            public GetProfileByUserIdQueryHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<ProfileDTO>> Handle(GetProfileByUserIdQuery request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByIdAsync(request.UserId);

                if (user == null)
                    return Response<ProfileDTO>.Fail(new ValidationFailure("UserId", $"There is no user that matches the id {request.UserId}."));

                return Response<ProfileDTO>.Ok(new ProfileDTO {
                    UserId = user.Id,
                    Email = user.Email,
                    Username = user.UserName,
                    PhoneNumber = user.PhoneNumber
                });
            }
        }
    }
}
