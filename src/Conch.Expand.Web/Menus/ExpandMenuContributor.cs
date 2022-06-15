using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Conch.Expand.Web.Menus;

public class ExpandMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ExpandMenus.Prefix, displayName: "Expand", "~/Expand", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
