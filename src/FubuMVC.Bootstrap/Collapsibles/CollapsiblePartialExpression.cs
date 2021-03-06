using System;
using System.Web;
using FubuLocalization;

namespace FubuMVC.Bootstrap.Collapsibles
{
    public class CollapsiblePartialExpression : IHtmlString
    {
        private string _id;
        private string _title;
        private readonly Func<object > _content;

        public CollapsiblePartialExpression(Func<object> content)
        {
            _content = content;
            _id = Guid.NewGuid().ToString();
        }

        public CollapsiblePartialExpression Id(string id)
        {
            _id = id;
            return this;
        }

        public CollapsiblePartialExpression Title(StringToken title)
        {
            return Title(title.ToString());
        }

        public CollapsiblePartialExpression Title(string title)
        {
            _title = title;
            return this;
        }

        public override string ToString()
        {
            var tag = new CollapsibleTag(_id, _title);
            tag.AppendContent(_content().ToString());

            return tag.ToString();
        }

        public string ToHtmlString()
        {
            return ToString();
        }
    }
}