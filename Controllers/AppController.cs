using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.Infrastructure.Filters;

namespace TimeTracker.Controllers
{
    [AuthorizeUser]
    public class AppController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}