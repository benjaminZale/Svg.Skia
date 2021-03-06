﻿using SvgXml.Svg.Attributes;
using SvgXml.Xml.Attributes;

namespace SvgXml.Svg.FilterEffects.Primitives
{
    [Element("feImage")]
    public class SvgImage : SvgFilterPrimitive,
        ISvgCommonAttributes,
        ISvgPresentationAttributes,
        ISvgStylableAttributes,
        ISvgResourcesAttributes
    {
        [Attribute("preserveAspectRatio", SvgNamespace)]
        public string? AspectRatio
        {
            get => this.GetAttribute("preserveAspectRatio", false, "xMidYMid meet");
            set => this.SetAttribute("preserveAspectRatio", value);
        }

        [Attribute("href", XLinkNamespace)]
        public override string? Href
        {
            get => this.GetAttribute("href", false, null);
            set => this.SetAttribute("href", value);
        }

        public override void SetPropertyValue(string key, string? value)
        {
            base.SetPropertyValue(key, value);
            switch (key)
            {
                case "preserveAspectRatio":
                    AspectRatio = value;
                    break;
                case "href":
                    Href = value;
                    break;
            }
        }
    }
}
