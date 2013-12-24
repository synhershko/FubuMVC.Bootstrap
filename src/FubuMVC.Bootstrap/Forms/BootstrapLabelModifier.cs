using FubuMVC.Core.UI.Elements;

namespace FubuMVC.Bootstrap.Forms
{
    public class BootstrapLabelModifier : IElementModifier
    {
        public bool Matches(ElementRequest token)
        {
            return true;
        }

        public void Modify(ElementRequest request)
        {
            request.CurrentTag.AddClass("control-label");
        }
    }
}