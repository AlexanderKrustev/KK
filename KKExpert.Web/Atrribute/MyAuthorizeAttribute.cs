namespace KKExpert.Web.Atrribute
{
    using System;
    using System.Web.Mvc;

    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
         protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.IsInRole("invoice") &&  filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/BuyInvoice.cshtml"
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
           
        }
    }
}