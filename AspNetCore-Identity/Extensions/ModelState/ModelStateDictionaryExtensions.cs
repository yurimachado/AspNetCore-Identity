using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc
{
    public static class ModelStateDictionaryExtensions
    {
        public static void AddModelError(this ModelStateDictionary modelState, ValidationFailure failure)
        {
            modelState.AddModelError(failure.ErrorCode, failure.ErrorMessage);
        }
        public static void AddModelErrors(this ModelStateDictionary modelState, ICollection<ValidationFailure> failures)
        {
            foreach(var failure in failures)
                modelState.AddModelError(failure.ErrorCode ?? string.Empty, failure.ErrorMessage);
        }
    }
}