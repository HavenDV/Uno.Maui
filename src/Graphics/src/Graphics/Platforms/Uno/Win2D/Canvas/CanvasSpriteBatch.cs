using System.Runtime.InteropServices;
using WinRT;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasSpriteBatch : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasSpriteBatch>
{
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

    public void Dispose()
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

    public bool Equals(CanvasSpriteBatch other)
    {
        throw new NotImplementedException();
    }
}