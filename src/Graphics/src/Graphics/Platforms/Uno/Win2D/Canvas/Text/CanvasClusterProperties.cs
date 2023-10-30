using System;
using WinRT;

namespace Microsoft.Graphics.Canvas.Text;

[Flags]
public enum CanvasClusterProperties : uint
{
    None = 0u,
    CanWrapLineAfter = 1u,
    Whitespace = 2u,
    Newline = 4u,
    SoftHyphen = 8u,
    RightToLeft = 0x10u
}