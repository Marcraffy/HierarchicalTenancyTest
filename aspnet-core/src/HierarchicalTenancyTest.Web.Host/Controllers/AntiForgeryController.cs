using Microsoft.AspNetCore.Antiforgery;
using HierarchicalTenancyTest.Controllers;

namespace HierarchicalTenancyTest.Web.Host.Controllers
{
    public class AntiForgeryController : HierarchicalTenancyTestControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
