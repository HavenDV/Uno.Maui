namespace Microsoft.Graphics.Canvas.Text;

[Flags]
public enum CanvasDrawTextOptions : uint
{
    Default = 0u,
    NoPixelSnap = 1u,
    Clip = 2u,
    EnableColorFont = 4u
}