using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.UI;
using WinRT;

namespace Microsoft.Graphics.Canvas.Brushes;

public sealed class CanvasSolidColorBrush : ICanvasBrush, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasSolidColorBrush>
{
    public CanvasSolidColorBrush(ICanvasResourceCreator resourceCreator, Color color)
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

    public bool Equals(CanvasSolidColorBrush other)
    {
        throw new NotImplementedException();
    }
    
    public Color Color
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Vector4 ColorHdr
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasDevice Device => throw new NotImplementedException();

    public float Opacity
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Matrix3x2 Transform
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}