using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.Maui.Graphics;
using Uno;
using WinRT;
using Rect = Windows.Foundation.Rect;

namespace Microsoft.Graphics.Canvas.Geometry;

public class CanvasGeometry : IDisposable, IGeometrySource2D, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasGeometry>
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

    public bool Equals(CanvasGeometry other)
    {
        throw new NotImplementedException();
    }
    
    public static CanvasGeometry CreateRectangle(ICanvasResourceCreator resourceCreator, Rect rect)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateRectangle(ICanvasResourceCreator resourceCreator, float x, float y, float w, float h)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateRoundedRectangle(ICanvasResourceCreator resourceCreator, Rect rect, float radiusX, float radiusY)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateRoundedRectangle(ICanvasResourceCreator resourceCreator, float x, float y, float w, float h, float radiusX, float radiusY)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateEllipse(ICanvasResourceCreator resourceCreator, Vector2 centerPoint, float radiusX, float radiusY)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateEllipse(ICanvasResourceCreator resourceCreator, float x, float y, float radiusX, float radiusY)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateCircle(ICanvasResourceCreator resourceCreator, Vector2 centerPoint, float radius)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateCircle(ICanvasResourceCreator resourceCreator, float x, float y, float radius)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreatePath(CanvasPathBuilder pathBuilder)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreatePolygon(ICanvasResourceCreator resourceCreator, Vector2[] points)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateGroup(ICanvasResourceCreator resourceCreator, CanvasGeometry[] geometries)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateGroup(ICanvasResourceCreator resourceCreator, CanvasGeometry[] geometries, CanvasFilledRegionDetermination filledRegionDetermination)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateText(CanvasTextLayout textLayout)
    {
        throw new NotImplementedException();
    }

    public static CanvasGeometry CreateGlyphRun(ICanvasResourceCreator resourceCreator, Vector2 point, CanvasFontFace fontFace, float fontSize, CanvasGlyph[] glyphs, bool isSideways, uint bidiLevel, CanvasTextMeasuringMode measuringMode, CanvasGlyphOrientation glyphOrientation)
    {
        throw new NotImplementedException();
    }

    public static float ComputeFlatteningTolerance(float dpi, float maximumZoomFactor)
    {
        throw new NotImplementedException();
    }

    public static float ComputeFlatteningTolerance(float dpi, float maximumZoomFactor, Matrix3x2 expectedGeometryTransform)
    {
        throw new NotImplementedException();
    }
    
    public CanvasGeometry CombineWith(CanvasGeometry otherGeometry, Matrix3x2 otherGeometryTransform, CanvasGeometryCombine combine)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry CombineWith(CanvasGeometry otherGeometry, Matrix3x2 otherGeometryTransform, CanvasGeometryCombine combine, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Stroke(float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Stroke(float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Stroke(float strokeWidth, CanvasStrokeStyle strokeStyle, Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Outline()
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Outline(Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Simplify(CanvasGeometrySimplification simplification)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Simplify(CanvasGeometrySimplification simplification, Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometry Transform(Matrix3x2 transform)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometryRelation CompareWith(CanvasGeometry otherGeometry)
    {
        throw new NotImplementedException();
    }

    public CanvasGeometryRelation CompareWith(CanvasGeometry otherGeometry, Matrix3x2 otherGeometryTransform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public float ComputeArea()
    {
        throw new NotImplementedException();
    }

    public float ComputeArea(Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public float ComputePathLength()
    {
        throw new NotImplementedException();
    }

    public float ComputePathLength(Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public Vector2 ComputePointOnPath(float distance)
    {
        throw new NotImplementedException();
    }

    public Vector2 ComputePointOnPath(float distance, out Vector2 tangent)
    {
        throw new NotImplementedException();
    }

    public Vector2 ComputePointOnPath(float length, Matrix3x2 transform, float flatteningTolerance, out Vector2 tangent)
    {
        throw new NotImplementedException();
    }

    public bool FillContainsPoint(Vector2 point)
    {
        throw new NotImplementedException();
    }

    public bool FillContainsPoint(Vector2 point, Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public Rect ComputeBounds()
    {
        throw new NotImplementedException();
    }

    public Rect ComputeBounds(Matrix3x2 transform)
    {
        throw new NotImplementedException();
    }

    public Rect ComputeStrokeBounds(float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public Rect ComputeStrokeBounds(float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public Rect ComputeStrokeBounds(float strokeWidth, CanvasStrokeStyle strokeStyle, Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public bool StrokeContainsPoint(Vector2 point, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public bool StrokeContainsPoint(Vector2 point, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public bool StrokeContainsPoint(Vector2 point, float strokeWidth, CanvasStrokeStyle strokeStyle, Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public CanvasTriangleVertices[] Tessellate()
    {
        throw new NotImplementedException();
    }

    public CanvasTriangleVertices[] Tessellate(Matrix3x2 transform, float flatteningTolerance)
    {
        throw new NotImplementedException();
    }

    public void SendPathTo(ICanvasPathReceiver streamReader)
    {
        throw new NotImplementedException();
    }
}