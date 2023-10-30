using System;
using System.Runtime.InteropServices;
using Windows.Graphics.DirectX.Direct3D11;
using WinRT;

namespace Microsoft.Graphics.Canvas;

public class CanvasDevice : IDirect3DDevice, IDisposable, ICanvasResourceCreator, IWinRTObject, ICustomQueryInterface, IDynamicInterfaceCastable, IEquatable<CanvasDevice>
{
    public CanvasDevice Device { get; }

    public void Dispose()
    {
        Device?.Dispose();
    }

    public void Trim()
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

    public bool Equals(CanvasDevice other)
    {
        throw new NotImplementedException();
    }
    
    public static CanvasDevice CreateFromDirect3D11Device(IDirect3DDevice direct3DDevice)
    {
        throw new NotImplementedException();
    }

    public static CanvasDevice GetSharedDevice()
    {
        throw new NotImplementedException();
    }

    public static CanvasDevice GetSharedDevice(bool forceSoftwareRenderer)
    {
        throw new NotImplementedException();
    }
}