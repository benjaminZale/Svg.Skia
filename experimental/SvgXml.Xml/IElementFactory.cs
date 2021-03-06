﻿using System;
using System.Collections.Generic;

namespace SvgXml.Xml
{
    public interface IElementFactory
    {
        Dictionary<string, Type> Types { get; }
        ISet<string> Namespaces { get; }
        Element Create(string name, IElement? parent);
    }
}
