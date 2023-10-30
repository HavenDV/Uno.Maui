using System.Runtime.InteropServices;
using WinRT;

namespace Microsoft.Graphics.Canvas.Geometry;

public sealed class CanvasStrokeStyle : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasStrokeStyle>
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

    public bool Equals(CanvasStrokeStyle other)
    {
        throw new NotImplementedException();
    }
    
    
    public float[] CustomDashStyle
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasCapStyle DashCap
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float DashOffset
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasDashStyle DashStyle
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasCapStyle EndCap
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasLineJoin LineJoin
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float MiterLimit
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasCapStyle StartCap
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasStrokeTransformBehavior TransformBehavior
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}