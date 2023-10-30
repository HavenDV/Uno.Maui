using System.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry;

public interface ICanvasPathReceiver
{
    void BeginFigure(Vector2 startPoint, CanvasFigureFill figureFill);

    void AddArc(Vector2 endPoint, float radiusX, float radiusY, float rotationAngle, CanvasSweepDirection sweepDirection, CanvasArcSize arcSize);

    void AddCubicBezier(Vector2 controlPoint1, Vector2 controlPoint2, Vector2 endPoint);

    void AddLine(Vector2 endPoint);

    void AddQuadraticBezier(Vector2 controlPoint, Vector2 endPoint);

    void SetFilledRegionDetermination(CanvasFilledRegionDetermination filledRegionDetermination);

    void SetSegmentOptions(CanvasFigureSegmentOptions figureSegmentOptions);

    void EndFigure(CanvasFigureLoop figureLoop);
}