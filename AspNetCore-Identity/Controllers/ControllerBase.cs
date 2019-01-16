using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Identity.Service.Controllers
{
    public class ControllerBase : Controller
    {
        public ControllerBase(IMediator mediator)
        {
            this.Mediator = mediator;
            this.OnFailureAction = this.OnFailure;
        }

        protected IMediator Mediator { get; }
        protected bool IsSuccess { get; set; }
        protected Action<string> OnFailureAction;

        protected void AddModelError(string error)
        {
            foreach (var er in error.Split(";"))
                ModelState.AddModelError("", er);
        }

        public void OnFailure(string errorDescription)
        {
            AddModelError(errorDescription);
            this.IsSuccess = false;
        }
    }
}
