using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Graphics.Imaging;
using Windows.UI;
using Microsoft.Graphics.Canvas.Brushes;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.Maui.Graphics;
using WinRT;
using Color = Windows.UI.Color;
using Size = Windows.Foundation.Size;
using Rect = Windows.Foundation.Rect;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasDrawingSession : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasDrawingSession>
{
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

    public bool Equals(CanvasDrawingSession other)
    {
        throw new NotImplementedException();
    }
    
    
    public CanvasAntialiasing Antialiasing
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasBlend Blend
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasDevice Device => throw new NotImplementedException();

    public float Dpi => throw new NotImplementedException();

    public CanvasBufferPrecision? EffectBufferPrecision
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public BitmapSize EffectTileSize
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasTextAntialiasing TextAntialiasing
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasTextRenderingParameters TextRenderingParameters
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Matrix3x2 Transform
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasUnits Units
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    
    
    public void Clear(Color color)
    {
        throw new NotImplementedException();
    }

    public void Clear(Vector4 color)
    {
        throw new NotImplementedException();
    }

    public void Flush()
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Vector2 offset)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, float x, float y)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(CanvasBitmap bitmap, Rect destinationRectangle)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Vector2 offset, Rect sourceRectangle)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, float x, float y, Rect sourceRectangle)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Rect destinationRectangle, Rect sourceRectangle)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Vector2 offset, Rect sourceRectangle, float opacity)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, float x, float y, Rect sourceRectangle, float opacity)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Rect destinationRectangle, Rect sourceRectangle, float opacity)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Vector2 offset, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, float x, float y, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Rect destinationRectangle, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Vector2 offset, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, CanvasComposite composite)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, float x, float y, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, CanvasComposite composite)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(ICanvasImage image, Rect destinationRectangle, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, CanvasComposite composite)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(CanvasBitmap bitmap, Vector2 offset, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, Matrix4x4 perspective)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(CanvasBitmap bitmap, float x, float y, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, Matrix4x4 perspective)
    {
        throw new NotImplementedException();
    }

    public void DrawImage(CanvasBitmap bitmap, Rect destinationRectangle, Rect sourceRectangle, float opacity, CanvasImageInterpolation interpolation, Matrix4x4 perspective)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(Vector2 point0, Vector2 point1, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawLine(float x0, float y0, float x1, float y1, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(Rect rect, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRectangle(float x, float y, float w, float h, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(Rect rect, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(float x, float y, float w, float h, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(Rect rect, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(float x, float y, float w, float h, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(Rect rect, ICanvasBrush brush, ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public void FillRectangle(float x, float y, float w, float h, ICanvasBrush brush, ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(Rect rect, float radiusX, float radiusY, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void FillRoundedRectangle(Rect rect, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillRoundedRectangle(Rect rect, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillRoundedRectangle(float x, float y, float w, float h, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(Vector2 centerPoint, float radiusX, float radiusY, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawEllipse(float x, float y, float radiusX, float radiusY, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void FillEllipse(Vector2 centerPoint, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillEllipse(float x, float y, float radiusX, float radiusY, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillEllipse(Vector2 centerPoint, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillEllipse(float x, float y, float radiusX, float radiusY, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(Vector2 centerPoint, float radius, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawCircle(float x, float y, float radius, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void FillCircle(Vector2 centerPoint, float radius, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillCircle(float x, float y, float radius, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillCircle(Vector2 centerPoint, float radius, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillCircle(float x, float y, float radius, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, Vector2 point, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, float x, float y, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, Vector2 point, ICanvasBrush brush, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, Rect rectangle, ICanvasBrush brush, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, float x, float y, ICanvasBrush brush, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, float x, float y, float w, float h, ICanvasBrush brush, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, Vector2 point, Color color, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, Rect rectangle, Color color, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, float x, float y, Color color, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawText(string text, float x, float y, float w, float h, Color color, CanvasTextFormat format)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, ICanvasBrush brush, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Color color, float strokeWidth)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Vector2 offset, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, float x, float y, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, ICanvasBrush brush, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void DrawGeometry(CanvasGeometry geometry, Color color, float strokeWidth, CanvasStrokeStyle strokeStyle)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, Vector2 offset, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, Vector2 offset, ICanvasBrush brush, ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, Vector2 offset, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, float x, float y, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, float x, float y, ICanvasBrush brush, ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, float x, float y, Color color)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, ICanvasBrush brush, ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public void FillGeometry(CanvasGeometry geometry, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, Vector2 offset, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, Vector2 offset, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, float x, float y, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, float x, float y, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawCachedGeometry(CanvasCachedGeometry geometry, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawTextLayout(CanvasTextLayout textLayout, Vector2 point, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawTextLayout(CanvasTextLayout textLayout, float x, float y, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawTextLayout(CanvasTextLayout textLayout, Vector2 point, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawTextLayout(CanvasTextLayout textLayout, float x, float y, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawGradientMesh(CanvasGradientMesh gradientMesh)
    {
        throw new NotImplementedException();
    }

    public void DrawGradientMesh(CanvasGradientMesh gradientMesh, Vector2 point)
    {
        throw new NotImplementedException();
    }

    public void DrawGradientMesh(CanvasGradientMesh gradientMesh, float x, float y)
    {
        throw new NotImplementedException();
    }

    public void DrawSvg(CanvasSvgDocument svgDocument, Size viewportSize)
    {
        throw new NotImplementedException();
    }

    public void DrawSvg(CanvasSvgDocument svgDocument, Size viewportSize, Vector2 point)
    {
        throw new NotImplementedException();
    }

    public void DrawSvg(CanvasSvgDocument svgDocument, Size viewportSize, float x, float y)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(float opacity)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(ICanvasBrush opacityBrush)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(float opacity, Rect clipRectangle)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(ICanvasBrush opacityBrush, Rect clipRectangle)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(float opacity, CanvasGeometry clipGeometry)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(ICanvasBrush opacityBrush, CanvasGeometry clipGeometry)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(float opacity, CanvasGeometry clipGeometry, Matrix3x2 geometryTransform)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(ICanvasBrush opacityBrush, CanvasGeometry clipGeometry, Matrix3x2 geometryTransform)
    {
        throw new NotImplementedException();
    }

    public CanvasActiveLayer CreateLayer(float opacity, ICanvasBrush opacityBrush, Rect clipRectangle, CanvasGeometry clipGeometry, Matrix3x2 geometryTransform, CanvasLayerOptions options)
    {
        throw new NotImplementedException();
    }

    public void DrawGlyphRun(Vector2 point, CanvasFontFace fontFace, float fontSize, CanvasGlyph[] glyphs, bool isSideways, uint bidiLevel, ICanvasBrush brush)
    {
        throw new NotImplementedException();
    }

    public void DrawGlyphRun(Vector2 point, CanvasFontFace fontFace, float fontSize, CanvasGlyph[] glyphs, bool isSideways, uint bidiLevel, ICanvasBrush brush, CanvasTextMeasuringMode measuringMode)
    {
        throw new NotImplementedException();
    }

    public void DrawGlyphRun(Vector2 point, CanvasFontFace fontFace, float fontSize, CanvasGlyph[] glyphs, bool isSideways, uint bidiLevel, ICanvasBrush brush, CanvasTextMeasuringMode measuringMode, string localeName, string textString, int[] clusterMapIndices, uint textPosition)
    {
        throw new NotImplementedException();
    }

    public CanvasSpriteBatch CreateSpriteBatch()
    {
        throw new NotImplementedException();
    }

    public CanvasSpriteBatch CreateSpriteBatch(CanvasSpriteSortMode sortMode)
    {
        throw new NotImplementedException();
    }

    public CanvasSpriteBatch CreateSpriteBatch(CanvasSpriteSortMode sortMode, CanvasImageInterpolation interpolation)
    {
        throw new NotImplementedException();
    }

    public CanvasSpriteBatch CreateSpriteBatch(CanvasSpriteSortMode sortMode, CanvasImageInterpolation interpolation, CanvasSpriteOptions options)
    {
        throw new NotImplementedException();
    }

    public float ConvertPixelsToDips(int pixels)
    {
        throw new NotImplementedException();
    }
}