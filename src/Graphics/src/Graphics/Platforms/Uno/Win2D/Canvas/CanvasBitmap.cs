using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Microsoft.Graphics.DirectX;
using Microsoft.Maui.Graphics;
using WinRT;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas;

public class CanvasBitmap : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDirect3DSurface, IDisposable, ICanvasImage, IGraphicsEffectSource, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasBitmap>
{
    protected CanvasBitmap(DerivedComposed _)
    {
    }
    

    public CanvasAlphaMode AlphaMode => throw new NotImplementedException();

    public Rect Bounds => throw new NotImplementedException();

    public Direct3DSurfaceDescription Description => throw new NotImplementedException();

    public CanvasDevice Device => throw new NotImplementedException();

    public float Dpi => throw new NotImplementedException();

    public DirectXPixelFormat Format => throw new NotImplementedException();

    public Size Size => throw new NotImplementedException();

    public BitmapSize SizeInPixels => throw new NotImplementedException();

    
    public float ConvertPixelsToDips(int pixels)
    {
        throw new NotImplementedException();
    }

    public int ConvertDipsToPixels(float dips, CanvasDpiRounding dpiRounding)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }


    public Rect GetBounds(ICanvasResourceCreator resourceCreator)
    {
        throw new NotImplementedException();
    }

    public Rect GetBounds(ICanvasResourceCreator resourceCreator, Matrix3x2 transform)
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

    public bool Equals(CanvasBitmap other)
    {
        throw new NotImplementedException();
    }
    
    public static CanvasBitmap CreateFromDirect3D11Surface(ICanvasResourceCreator resourceCreator, IDirect3DSurface surface)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromDirect3D11Surface(ICanvasResourceCreator resourceCreator, IDirect3DSurface surface, float dpi)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromDirect3D11Surface(ICanvasResourceCreator resourceCreator, IDirect3DSurface surface, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, byte[] bytes, int widthInPixels, int heightInPixels, DirectXPixelFormat format)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, byte[] bytes, int widthInPixels, int heightInPixels, DirectXPixelFormat format, float dpi)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, byte[] bytes, int widthInPixels, int heightInPixels, DirectXPixelFormat format, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, IBuffer buffer, int widthInPixels, int heightInPixels, DirectXPixelFormat format)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, IBuffer buffer, int widthInPixels, int heightInPixels, DirectXPixelFormat format, float dpi)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromBytes(ICanvasResourceCreator resourceCreator, IBuffer buffer, int widthInPixels, int heightInPixels, DirectXPixelFormat format, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromColors(ICanvasResourceCreator resourceCreator, Color[] colors, int widthInPixels, int heightInPixels)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromColors(ICanvasResourceCreator resourceCreator, Color[] colors, int widthInPixels, int heightInPixels, float dpi)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromColors(ICanvasResourceCreator resourceCreator, Color[] colors, int widthInPixels, int heightInPixels, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static CanvasBitmap CreateFromSoftwareBitmap(ICanvasResourceCreator resourceCreator, SoftwareBitmap sourceBitmap)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, string fileName)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, string fileName, float dpi)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, string fileName, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, Uri uri)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, Uri uri, float dpi)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, Uri uri, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, IRandomAccessStream stream)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, IRandomAccessStream stream, float dpi)
    {
        throw new NotImplementedException();
    }

    public static IAsyncOperation<CanvasBitmap> LoadAsync(ICanvasResourceCreator resourceCreator, IRandomAccessStream stream, float dpi, CanvasAlphaMode alpha)
    {
        throw new NotImplementedException();
    }
    
    
    public IAsyncAction SaveAsync(string fileName)
    {
        throw new NotImplementedException();
    }

    public IAsyncAction SaveAsync(string fileName, CanvasBitmapFileFormat fileFormat)
    {
        throw new NotImplementedException();
    }

    public IAsyncAction SaveAsync(string fileName, CanvasBitmapFileFormat fileFormat, float quality)
    {
        throw new NotImplementedException();
    }

    public IAsyncAction SaveAsync(IRandomAccessStream stream, CanvasBitmapFileFormat fileFormat)
    {
        throw new NotImplementedException();
    }

    public IAsyncAction SaveAsync(IRandomAccessStream stream, CanvasBitmapFileFormat fileFormat, float quality)
    {
        throw new NotImplementedException();
    }

    public byte[] GetPixelBytes()
    {
        throw new NotImplementedException();
    }

    public byte[] GetPixelBytes(int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public void GetPixelBytes(IBuffer buffer)
    {
        throw new NotImplementedException();
    }

    public void GetPixelBytes(IBuffer buffer, int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public Color[] GetPixelColors()
    {
        throw new NotImplementedException();
    }

    public Color[] GetPixelColors(int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public void SetPixelBytes(byte[] valueElements)
    {
        throw new NotImplementedException();
    }

    public void SetPixelBytes(byte[] valueElements, int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public void SetPixelBytes(IBuffer buffer)
    {
        throw new NotImplementedException();
    }

    public void SetPixelBytes(IBuffer buffer, int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public void SetPixelColors(Color[] valueElements)
    {
        throw new NotImplementedException();
    }

    public void SetPixelColors(Color[] valueElements, int left, int top, int width, int height)
    {
        throw new NotImplementedException();
    }

    public void CopyPixelsFromBitmap(CanvasBitmap otherBitmap)
    {
        throw new NotImplementedException();
    }

    public void CopyPixelsFromBitmap(CanvasBitmap otherBitmap, int destX, int destY)
    {
        throw new NotImplementedException();
    }

    public void CopyPixelsFromBitmap(CanvasBitmap otherBitmap, int destX, int destY, int sourceRectLeft, int sourceRectTop, int sourceRectWidth, int sourceRectHeight)
    {
        throw new NotImplementedException();
    }
}