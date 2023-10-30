using System.Numerics;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;
using Microsoft.Maui.Graphics;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas;

public interface ICanvasImage : IGraphicsEffectSource, IDisposable
{
    [Overload("GetBounds")]
    Rect GetBounds(ICanvasResourceCreator resourceCreator);

    [Overload("GetBoundsWithTransform")]
    Rect GetBounds(ICanvasResourceCreator resourceCreator, Matrix3x2 transform);
}