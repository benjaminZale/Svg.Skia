﻿using SvgXml.Svg.Attributes;
using SvgXml.Xml.Attributes;

namespace SvgXml.Svg.Text
{
    [Element("missing-glyph")]
    public class SvgMissingGlyph : SvgGlyph,
        ISvgCommonAttributes,
        ISvgPresentationAttributes,
        ISvgStylableAttributes
    {
    }
}
