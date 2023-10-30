using System;
using System.Runtime.InteropServices;
using WinRT;

namespace Microsoft.Graphics.Canvas.Geometry;

public sealed class CanvasSvgDocument : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasSvgDocument>
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

    public bool Equals(CanvasSvgDocument other)
    {
        throw new NotImplementedException();
    }
}