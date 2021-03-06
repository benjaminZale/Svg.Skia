﻿using System;
using SvgXml.Xml;

namespace SvgXml.Svg
{
    public static class SvgElementExtensions
    {
        public static string? GetAttribute(this IElement element, string key, bool inherited, string? defaultValue)
        {
            bool inherit = false;

            if (element.TryGetAttribute(key, out var value))
            {
                inherit = string.Equals(value?.ToString(), "inherit", StringComparison.OrdinalIgnoreCase);
                if (!inherit)
                {
                    return value;
                }
            }

            if (inherited || inherit)
            {
                var parentValue = element.Parent?.GetAttribute(key, inherited, default);
                if (parentValue != null)
                {
                    return parentValue;
                }
            }

            return defaultValue;
        }
    }
}
