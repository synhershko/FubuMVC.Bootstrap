using FubuMVC.Core.UI.Forms;
using FubuMVC.Bootstrap.Forms;
using FubuTestingSupport;
using HtmlTags;
using NUnit.Framework;

namespace FubuMVC.Bootstrap.Testing.Forms
{
    [TestFixture]
    public class HorizontalFormModifierTester
    {
        [Test]
        public void adds_the_horizontal_form_class()
        {
            var request = new FormRequest(null, null);
            request.ReplaceTag(new FormTag("/test"));

            var modifier = new HorizontalFormModifier();
            modifier.Modify(request);

            request.CurrentTag.HasClass("form-horizontal").ShouldBeTrue();
        }
    }
}