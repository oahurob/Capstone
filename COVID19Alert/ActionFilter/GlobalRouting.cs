using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace COVID19Alert.ActionFilter
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimsprincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsprincipal = claimsPrincipal;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
            {
                if (_claimsprincipal.IsInRole("RegisteredUser"))
                {
                    context.Result = new RedirectToActionResult("Index", "RegisteredUsers", null);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

    }
}
