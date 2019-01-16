using Identity.Service.Application;
using Identity.Service.Application.Commands.User;
using Identity.Service.Application.Query.User;
using Identity.Service.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.Service.Controllers
{
    [Route("Account/Management")]
    [Authorize(Roles = "Admin")]
    public class AccountManagementController : ControllerBase
    {
        public AccountManagementController(IMediator mediator) : base(mediator) {}

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await this.Mediator.Send(new GetAllUserAccountQuery {
                OwnerId = User.FindFirstValue(ClaimTypes.Sid),
                OwnerRole = User.FindFirstValue(ClaimTypes.Role)
            });

            if (response.IsFailure) {
                ModelState.AddModelErrors(response.Errors);
                return View();
            }

            var users = response.Result;

            return View(users);
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var response = await this.Mediator.Send(new GetUserByIdQuery { Id = id });

            if (response.IsFailure){
                return RedirectToAction("Page404", "Home");
            }

            var user = response.Result;

            return View(new EditUserCommand {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                IsBlocked = user.IsBlocked,
                EmailConfirmed = user.EmailConfirmed,
                LockoutEnabled = user.LockoutEnabled,
                PhoneNumber = user.PhoneNumber,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                TwoFactorEnabled = user.TwoFactorEnabled,
                IsAdmin = user.IsAdmin
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(string id, EditUserCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure){
                ModelState.AddModelErrors(response.Errors);
                return View(command);
            }

            return RedirectToAction("Edited", command);
        }

        [HttpGet]
        [Route("Edited")]
        public IActionResult Edited(EditUserCommand command)
        {
            return View(command);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create() => View(new CreateUserCommand());

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var response = await this.Mediator.Send(command);

            if (response.IsFailure)
            {
                ModelState.AddModelErrors(response.Errors);
                command.ConfirmPassword = string.Empty;
                command.Password = string.Empty;
                return View(command);
            }

            return RedirectToAction("Created", command);
        }

        [HttpGet]
        [Route("Created")]
        public IActionResult Created(CreateUserCommand command)
        {
            return View(command);
        }
    }
}
