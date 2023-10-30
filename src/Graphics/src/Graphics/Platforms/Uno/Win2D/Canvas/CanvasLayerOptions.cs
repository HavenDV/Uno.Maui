namespace Microsoft.Graphics.Canvas;

[Flags]
public enum CanvasLayerOptions : uint
{
    None = 0u,
    InitializeFromBackground = 1u,
    IgnoreAlpha = 2u
}