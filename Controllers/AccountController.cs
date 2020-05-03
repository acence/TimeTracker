using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.Infrastructure;
using TimeTracker.Infrastructure.Database;
using TimeTracker.Infrastructure.Extensions;
using TimeTracker.Logic;
using TimeTracker.Models.View;

namespace TimeTracker.Controllers
{
    public class AccountController : Controller
    {
        DatabaseContext _context;
        public AccountController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await new UserLogic(_context).AuthenticateUser(model.Username, model.Password);

            if(user != null)
            {
                HttpContext.Session.SetObject(Constants.Session.UserKey, user);
                if (Request.Query[Constants.QueryString.ReturnUrl][0] != null)
                {
                    return new RedirectResult(Request.Query[Constants.QueryString.ReturnUrl][0]);
                }
                return new RedirectResult("/App");
            }
            return View(model);
        }
    }
}