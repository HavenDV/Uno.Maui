using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using WinRT;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasPathBuilder : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasPathBuilder>
{
    public CanvasPathBuilder(ICanvasResourceCreator resourceCreator)
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

    public bool Equals(CanvasPathBuilder other)
    {
        throw new NotImplementedException();
    }
    
    
    public void BeginFigure(Vector2 startPoint, CanvasFigureFill figureFill)
    {
        throw new NotImplementedException();
    }

    public void BeginFigure(Vector2 startPoint)
    {
        throw new NotImplementedException();
    }

    public void BeginFigure(float startX, float startY, CanvasFigureFill figureFill)
    {
        throw new NotImplementedException();
    }

    public void BeginFigure(float startX, float startY)
    {
        throw new NotImplementedException();
    }

    public void AddArc(Vector2 endPoint, float radiusX, float radiusY, float rotationAngle, CanvasSweepDirection sweepDirection, CanvasArcSize arcSize)
    {
        throw new NotImplementedException();
    }

    public void AddArc(Vector2 centerPoint, float radiusX, float radiusY, float startAngle, float sweepAngle)
    {
        throw new NotImplementedException();
    }

    public void AddCubicBezier(Vector2 controlPoint1, Vector2 controlPoint2, Vector2 endPoint)
    {
        throw new NotImplementedException();
    }

    public void AddLine(Vector2 endPoint)
    {
        throw new NotImplementedException();
    }

    public void AddLine(float x, float y)
    {
        throw new NotImplementedException();
    }

    public void AddQuadraticBezier(Vector2 controlPoint, Vector2 endPoint)
    {
        throw new NotImplementedException();
    }

    public void SetFilledRegionDetermination(CanvasFilledRegionDetermination filledRegionDetermination)
    {
        throw new NotImplementedException();
    }

    public void SetSegmentOptions(CanvasFigureSegmentOptions figureSegmentOptions)
    {
        throw new NotImplementedException();
    }

    public void EndFigure(CanvasFigureLoop figureLoop)
    {
        throw new NotImplementedException();
    }

    public void AddGeometry(CanvasGeometry geometry)
    {
        throw new NotImplementedException();
    }
}