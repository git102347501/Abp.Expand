using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Conch.Expand.Pages;

public class IndexModel : ExpandPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
