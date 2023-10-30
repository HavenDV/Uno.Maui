using Windows.Graphics.Effects;
using Microsoft.Maui.Graphics;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas.Effects;

public interface ICanvasEffect : IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
{
    CanvasBufferPrecision? BufferPrecision { get; set; }

    bool CacheOutput { get; set; }

    void InvalidateSourceRectangle(ICanvasResourceCreatorWithDpi resourceCreator, uint sourceIndex, Rect invalidRectangle);

    Rect[] GetInvalidRectangles(ICanvasResourceCreatorWithDpi resourceCreator);

    Rect GetRequiredSourceRectangle(ICanvasResourceCreatorWithDpi resourceCreator, Rect outputRectangle, ICanvasEffect sourceEffect, uint sourceIndex, Rect sourceBounds);

    Rect[] GetRequiredSourceRectangles(ICanvasResourceCreatorWithDpi resourceCreator, Rect outputRectangle, ICanvasEffect[] sourceEffects, uint[] sourceIndices, Rect[] sourceBounds);
}