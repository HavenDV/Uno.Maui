using System.Numerics;
using Size = Windows.Foundation.Size;
using Rect = Windows.Foundation.Rect;

namespace Microsoft.Graphics.Canvas.Text;

public interface ICanvasTextInlineObject
{
    float Baseline { get; }

    CanvasLineBreakCondition BreakAfter { get; }

    CanvasLineBreakCondition BreakBefore { get; }

    Rect DrawBounds { get; }

    Size Size { get; }

    bool SupportsSideways { get; }

    void Draw(ICanvasTextRenderer textRenderer, Vector2 point, bool isSideways, bool isRightToLeft, object brush);
}