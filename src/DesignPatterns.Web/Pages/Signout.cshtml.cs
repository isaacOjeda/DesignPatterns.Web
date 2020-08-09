using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DesignPatterns.Web.Pages
{
    public class SignOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            var callbackUrl = Url.Page("/SignedOut", pageHandler: null, values: null, protocol: Request.Scheme);

            return SignOut(
                new AuthenticationProperties { RedirectUri = callbackUrl }, "Cookies", "oidc");
        }
    }
}