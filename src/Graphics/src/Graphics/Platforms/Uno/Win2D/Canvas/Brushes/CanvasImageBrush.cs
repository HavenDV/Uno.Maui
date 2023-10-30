using System;
using System.Numerics;
using System.Runtime.InteropServices;
using WinRT;
using Size = Windows.Foundation.Size;
using Rect = Windows.Foundation.Rect;

namespace Microsoft.Graphics.Canvas.Brushes;

public sealed class CanvasImageBrush : ICanvasBrush, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasImageBrush>
{
    public CanvasImageBrush(ICanvasResourceCreator resourceCreator)
    {
        throw new NotImplementedException();
    }

    public CanvasImageBrush(ICanvasResourceCreator resourceCreator, ICanvasImage image)
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

    public bool Equals(CanvasImageBrush other)
    {
        throw new NotImplementedException();
    }
    
    
    public CanvasDevice Device => throw new NotImplementedException();

    public CanvasEdgeBehavior ExtendX
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasEdgeBehavior ExtendY
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public ICanvasImage Image
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasImageInterpolation Interpolation
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float Opacity
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Rect? SourceRectangle
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