using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Infrastructure.Extensions;
using TimeTracker.Models.Domain;

namespace TimeTracker.Infrastructure.Filters
{
    public class AuthorizeUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = filterContext.HttpContext.Session.GetObject<User>(Constants.Session.UserKey);

            if (user == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
               new { controller = "Account", action = "Login", returnUrl = filterContext.HttpContext.Request.GetEncodedUrl() }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
