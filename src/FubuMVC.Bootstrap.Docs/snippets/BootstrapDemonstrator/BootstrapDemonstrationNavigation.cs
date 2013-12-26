using FubuMVC.Navigation;
using BootstrapDemonstrator.CollapsiblePartial;
using BootstrapDemonstrator.Forms;
using BootstrapDemonstrator.Modals;
using BootstrapDemonstrator.Navigation;

namespace BootstrapDemonstrator
{
    // SAMPLE: NavigationRegistry
    public class BootstrapDemonstrationNavigation : NavigationRegistry
    {
        public BootstrapDemonstrationNavigation()
        {
            ForMenu("TwitterBootstrap");

            Add += MenuNode.ForAction<NavigationEndpoint>("Navigation Bar", x => x.get_navigation_bar());
            Add += MenuNode.ForAction<CollapsiblePartialEndpoint>("Collapsible Partials", x => x.get_collapsible_partial());
            Add += MenuNode.ForAction<ModalEndpoint>("Modal Popups", x => x.get_modal());
            Add += MenuNode.ForAction<FormEndpoint>("Forms", x => x.get_form(null));
        }
    }
    // ENDSAMPLE
}