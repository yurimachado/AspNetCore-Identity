using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Identity.Service.Application.Common
{
    /// <summary>
    /// Encapsulates the response with a successful result of type <see cref="TSucceededResult"/> and a list of errors of type <see cref="ICollection{ValidationFailure}"/>.
    /// </summary>
    /// <typeparam name="TSucceededResult"></typeparam>
    public class Response<TSucceededResult>
    {
        public ICollection<ValidationFailure> Errors { get; private set; }
        private bool _hasFailure;
        public bool IsSuccessful { get => !this._hasFailure; }
        public bool IsFailure { get => this._hasFailure; }
        public TSucceededResult Result { get; private set; }

        public Response(TSucceededResult result)
        {
            this.Result = result;
        }

        public Response()
        {

        }

        public static Response<TSucceededResult> Fail(ValidationFailure error) => new Response<TSucceededResult> { _hasFailure = true, Errors = new List<ValidationFailure>() { error } };

        public static Response<TSucceededResult> Fail(ICollection<ValidationFailure> errors) => new Response<TSucceededResult> { _hasFailure = true, Errors = errors };

        public static Response<TSucceededResult> Ok(TSucceededResult result) => new Response<TSucceededResult>(result);

        public static Response<TSucceededResult> Ok() => new Response<TSucceededResult>();

        public ValidationFailure FirstError() => this.Errors.FirstOrDefault();

        public void AddErrors(ValidationFailure error)
        {
            this.Errors.Add(error);
        }
    }
}
