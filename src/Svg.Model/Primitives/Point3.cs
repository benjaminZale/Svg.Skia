﻿using System;

namespace Svg.Model.Primitives
{
    public readonly struct Point3
    {
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        public static readonly Point3 Empty;

        public readonly bool IsEmpty => X == default && Y == default && Z == default;

        public Point3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public override string ToString()
        {
            return FormattableString.Invariant($"{X}, {Y}, {Z}");
        }
    }
}
