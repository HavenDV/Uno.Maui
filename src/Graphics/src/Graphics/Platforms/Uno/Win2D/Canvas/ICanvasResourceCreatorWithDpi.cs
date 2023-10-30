namespace Microsoft.Graphics.Canvas;

public interface ICanvasResourceCreatorWithDpi : ICanvasResourceCreator
{
    float Dpi { get; }

    float ConvertPixelsToDips(int pixels);

    int ConvertDipsToPixels(float dips, CanvasDpiRounding dpiRounding);
}