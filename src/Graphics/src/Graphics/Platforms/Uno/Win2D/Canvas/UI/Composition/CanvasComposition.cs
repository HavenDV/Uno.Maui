using System;
using Microsoft.Maui.Graphics;
using Microsoft.UI.Composition;

namespace Microsoft.Graphics.Canvas.UI.Composition;

public static class CanvasComposition
{
    public static CompositionGraphicsDevice CreateCompositionGraphicsDevice(Compositor compositor, CanvasDevice canvasDevice)
    {
        throw new NotImplementedException();
    }

    public static CanvasDevice GetCanvasDevice(CompositionGraphicsDevice graphicsDevice)
    {
        throw new NotImplementedException();
    }

    public static void SetCanvasDevice(CompositionGraphicsDevice graphicsDevice, CanvasDevice canvasDevice)
    {
        throw new NotImplementedException();
    }

    public static CanvasDrawingSession CreateDrawingSession(CompositionDrawingSurface drawingSurface)
    {
        throw new NotImplementedException();
    }

    public static CanvasDrawingSession CreateDrawingSession(CompositionDrawingSurface drawingSurface, Rect updateRect)
    {
        throw new NotImplementedException();
    }

    public static CanvasDrawingSession CreateDrawingSession(CompositionDrawingSurface drawingSurface, Rect updateRectInPixels, float dpi)
    {
        throw new NotImplementedException();
    }

    public static void Resize(CompositionDrawingSurface drawingSurface, Size sizeInPixels)
    {
        throw new NotImplementedException();
    }
}