using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using Data.Connect;

namespace QLDA.App_Start
{
    public class AuthenToken : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            try
            {
               QLDAEntities  ql = new QLDAEntities();
                if (filterContext.RequestContext.HttpContext.Request.Headers.Count < 0)
                {
                    var routeValues = new RouteValueDictionary();
                    routeValues["controller"] = "Home";
                    routeValues["action"] = "Erorr";
                    filterContext.Result = new RedirectToRouteResult(routeValues);
                }
                else if (filterContext.RequestContext.HttpContext.Request.Headers["token"].Count() < 0)
                {
                    var routeValues = new RouteValueDictionary();
                    routeValues["controller"] = "Home";
                    routeValues["action"] = "Erorr";
                    filterContext.Result = new RedirectToRouteResult(routeValues);
                }
                else if (!ql.tbl_z_users.Select(u => u.token).Contains(filterContext.RequestContext.HttpContext.Request.Headers["token"].ToString()))
                {
                    var routeValues = new RouteValueDictionary();
                    routeValues["controller"] = "Home";
                    routeValues["action"] = "Erorr";
                    filterContext.Result = new RedirectToRouteResult(routeValues);
                }
            }
            catch (Exception ex)
            {
                var routeValues = new RouteValueDictionary();
                routeValues["controller"] = "Home";
                routeValues["action"] = "Erorr";
                filterContext.Result = new RedirectToRouteResult(routeValues);
            }


        }

        //Runs after the OnAuthentication method  
        //------------//
        //OnAuthenticationChallenge:- if Method gets called when Authentication or Authorization is 
        //failed and this method is called after
        //Execution of Action Method but before rendering of View
        //------------//
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //We are checking Result is null or Result is HttpUnauthorizedResult 
            // if yes then we are Redirect to Error View
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }
    }

}