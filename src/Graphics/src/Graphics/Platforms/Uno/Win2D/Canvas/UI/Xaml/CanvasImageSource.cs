using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Media.Imaging;
using WinRT;
using Size = Windows.Foundation.Size;
using Rect = Windows.Foundation.Rect;
using Color = Windows.UI.Color;

namespace Microsoft.Graphics.Canvas.UI.Xaml;

public sealed class CanvasImageSource : SurfaceImageSource, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasImageSource>
{
    
    public CanvasImageSource(ICanvasResourceCreatorWithDpi resourceCreator, Size size)
        : base((int)size.Width, (int)size.Height)
    {
        throw new NotImplementedException();
    }

    public CanvasImageSource(ICanvasResourceCreatorWithDpi resourceCreator, float width, float height)
        : base((int)width, (int)height)
    {
        throw new NotImplementedException();
    }

    public CanvasImageSource(ICanvasResourceCreator resourceCreator, float width, float height, float dpi)
        : base((int)width, (int)height)
    {
        throw new NotImplementedException();
    }

    public CanvasImageSource(ICanvasResourceCreator resourceCreator, float width, float height, float dpi, CanvasAlphaMode alphaMode)
        : base((int)width, (int)height)
    {
        throw new NotImplementedException();
    }
    
    public CanvasImageSource(int pixelWidth, int pixelHeight) : base(pixelWidth, pixelHeight)
    {
    }

    public CanvasImageSource(int pixelWidth, int pixelHeight, bool isOpaque) : base(pixelWidth, pixelHeight, isOpaque)
    {
    }

    public CanvasDevice Device { get; }
    public float Dpi { get; }

    public float ConvertPixelsToDips(int pixels)
    {
        throw new NotImplementedException();
    }

    public int ConvertDipsToPixels(float dips, CanvasDpiRounding dpiRounding)
    {
        throw new NotImplementedException();
    }

    public CustomQueryInterfaceResult GetInterface(ref Guid iid, out IntPtr ppv)
    {
        throw new NotImplementedException();
    }

    public bool IsInterfaceImplemented(RuntimeTypeHandle interfaceType, bool throwIfNotImplemented)
    {
        throw new NotImplementedException();
    }

    public RuntimeTypeHandle GetInterfaceImplementation(RuntimeTypeHandle interfaceType)
    {
        throw new NotImplementedException();
    }

    public bool Equals(CanvasImageSource other)
    {
        throw new NotImplementedException();
    }
    
    public CanvasDrawingSession CreateDrawingSession(Color clearColor)
    {
        throw new NotImplementedException();
    }

    public CanvasDrawingSession CreateDrawingSession(Color clearColor, Rect updateRectangle)
    {
        throw new NotImplementedException();
    }

    public void Recreate(ICanvasResourceCreator value)
    {
        throw new NotImplementedException();
    }
}