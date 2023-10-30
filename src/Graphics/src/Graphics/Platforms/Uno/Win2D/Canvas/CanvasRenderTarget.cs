using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.DirectX;
using WinRT;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasRenderTarget : CanvasBitmap, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasRenderTarget>
{
    public CanvasRenderTarget(ICanvasResourceCreatorWithDpi resourceCreator, Size size)
        : base(DerivedComposed.Instance)
    {
        throw new NotImplementedException();
    }

    public CanvasRenderTarget(ICanvasResourceCreatorWithDpi resourceCreator, float width, float height)
        : base(DerivedComposed.Instance)
    {
        throw new NotImplementedException();
    }

    public CanvasRenderTarget(ICanvasResourceCreator resourceCreator, float width, float height, float dpi)
        : base(DerivedComposed.Instance)
    {
        throw new NotImplementedException();
    }

    public CanvasRenderTarget(ICanvasResourceCreator resourceCreator, float width, float height, float dpi, DirectXPixelFormat format, CanvasAlphaMode alpha)
        : base(DerivedComposed.Instance)
    {
        throw new NotImplementedException();
    }
    
    public bool Equals(CanvasRenderTarget other)
    {
        throw new NotImplementedException();
    }
    
    public CanvasDrawingSession CreateDrawingSession()
    {
        throw new NotImplementedException();
    }
    
    // public CanvasAlphaMode AlphaMode => throw new NotImplementedException();
    //
    // public Rect Bounds => throw new NotImplementedException();

    // public Direct3DSurfaceDescription Description => throw new NotImplementedException();
    //
    // public CanvasDevice Device => throw new NotImplementedException();
    //
    // public float Dpi => throw new NotImplementedException();

    // public DirectXPixelFormat Format => throw new NotImplementedException();
    //
    // public Size Size => throw new NotImplementedException();
    //
    // public BitmapSize SizeInPixels => throw new NotImplementedException();

}