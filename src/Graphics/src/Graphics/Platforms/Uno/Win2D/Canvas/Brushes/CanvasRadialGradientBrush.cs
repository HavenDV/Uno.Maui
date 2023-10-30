using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.UI;
using WinRT;

namespace Microsoft.Graphics.Canvas.Brushes;

public sealed class CanvasRadialGradientBrush : ICanvasBrush, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasRadialGradientBrush>
{
    public CanvasRadialGradientBrush(ICanvasResourceCreator resourceCreator, Color startColor, Color endColor)
    {
        throw new NotImplementedException();
    }

    public CanvasRadialGradientBrush(ICanvasResourceCreator resourceCreator, CanvasGradientStop[] gradientStops)
    {
        throw new NotImplementedException();
    }

    public CanvasRadialGradientBrush(ICanvasResourceCreator resourceCreator, CanvasGradientStop[] gradientStops, CanvasEdgeBehavior edgeBehavior, CanvasAlphaMode alphaMode)
    {
        throw new NotImplementedException();
    }

    public CanvasRadialGradientBrush(ICanvasResourceCreator resourceCreator, CanvasGradientStop[] gradientStops, CanvasEdgeBehavior edgeBehavior, CanvasAlphaMode alphaMode, CanvasColorSpace preInterpolationSpace, CanvasColorSpace postInterpolationSpace, CanvasBufferPrecision bufferPrecision)
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

    public bool Equals(CanvasRadialGradientBrush other)
    {
        throw new NotImplementedException();
    }
    
    
    public CanvasAlphaMode AlphaMode => throw new NotImplementedException();

    public CanvasBufferPrecision BufferPrecision => throw new NotImplementedException();

    public Vector2 Center
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public CanvasDevice Device => throw new NotImplementedException();

    public CanvasEdgeBehavior EdgeBehavior => throw new NotImplementedException();

    public float Opacity
    {
        get
        {
            throw new NotImplementedException();        }
        set
        {
            throw new NotImplementedException();        }
    }

    public Vector2 OriginOffset
    {
        get
        {
            throw new NotImplementedException();        }
        set
        {
            throw new NotImplementedException();        }
    }

    public CanvasColorSpace PostInterpolationSpace => throw new NotImplementedException();

    public CanvasColorSpace PreInterpolationSpace => throw new NotImplementedException();

    public float RadiusX
    {
        get
        {
            throw new NotImplementedException();        }
        set
        {
            throw new NotImplementedException();        }
    }

    public float RadiusY
    {
        get
        {
            throw new NotImplementedException();        }
        set
        {
            throw new NotImplementedException();        }
    }

    public CanvasGradientStop[] Stops => throw new NotImplementedException();

    public CanvasGradientStopHdr[] StopsHdr => throw new NotImplementedException();

    public Matrix3x2 Transform
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
}