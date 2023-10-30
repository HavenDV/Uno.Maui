using System;

namespace Microsoft.Graphics.Canvas.Geometry;

[Flags]
public enum CanvasFigureSegmentOptions : uint
{
    None = 0u,
    ForceUnstroked = 1u,
    ForceRoundLineJoin = 2u
}