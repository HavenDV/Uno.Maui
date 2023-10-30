using System;
using System.Runtime.InteropServices;
using WinRT;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasActiveLayer : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasActiveLayer>
{
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

    public bool Equals(CanvasActiveLayer other)
    {
        throw new NotImplementedException();
    }
}