using FubuMVC.Core;
using FubuMVC.Core.UI;
using FubuMVC.Bootstrap.Forms;

namespace FubuMVC.Bootstrap
{
    public class BootstrapExtensions : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Import<HtmlConventionRegistry>(x =>
            {
                x.FieldChrome<BootstrapFieldChrome>();
                x.Labels.Add(new BootstrapLabelModifier());
            });
        }
    }
}