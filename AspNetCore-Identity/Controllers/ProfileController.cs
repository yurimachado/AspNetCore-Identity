using Identity.Service.Application;
using Identity.Service.Application.Commands.User;
using Identity.Service.Application.Query.User;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.Service.Controllers
{
    [Authorize]
    public class ProfileController : ControllerBase
    {
        public ProfileController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userId = User.FindFirstValue(ClaimTypes.Sid);

            var response = await this.Mediator.Send(new GetProfileByUserIdQuery { UserId = User.FindFirstValue(ClaimTypes.Sid) });

            if (response.IsFailure)
                return RedirectToAction("Page404", "Home");
            var user = response.Result;

            return View(new EditUserProfileCommand {
                UserId = user.UserId,
                Email = user.Email,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserProfileCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure)
            {
                ModelState.AddModelErrors(response.Errors);
                return View(command);
            }

            return RedirectToAction("Edited", command);
        }

        public IActionResult Edited(EditUserProfileCommand command) => View(command);
    }
}
