using System;

namespace Microsoft.Graphics.Canvas;

[Flags]
public enum CanvasSpriteOptions : uint
{
    None = 0u,
    ClampToSourceRect = 1u
}