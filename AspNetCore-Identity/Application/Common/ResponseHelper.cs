using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Service.Application.Common
{
    public static class ResponseHelper
    {
        public static Response<T> IdentityResultFail<T>(IdentityResult identityResult)
        {
            ICollection<ValidationFailure> results = new List<ValidationFailure>();

            foreach (var error in identityResult.Errors)
                results.Add(new ValidationFailure(error.Code, error.Description));

            return Response<T>.Fail(results);
        }
    }
}
