using System;
using System.Numerics;
using WinRT;

namespace Microsoft.Graphics.Canvas.Geometry;

public struct CanvasTriangleVertices : IEquatable<CanvasTriangleVertices>
{
    public Vector2 Vertex1;

    public Vector2 Vertex2;

    public Vector2 Vertex3;

    public CanvasTriangleVertices(Vector2 _Vertex1, Vector2 _Vertex2, Vector2 _Vertex3)
    {
        Vertex1 = _Vertex1;
        Vertex2 = _Vertex2;
        Vertex3 = _Vertex3;
    }

    public static bool operator ==(CanvasTriangleVertices x, CanvasTriangleVertices y)
    {
        if (x.Vertex1 == y.Vertex1 && x.Vertex2 == y.Vertex2)
        {
            return x.Vertex3 == y.Vertex3;
        }

        return false;
    }

    public static bool operator !=(CanvasTriangleVertices x, CanvasTriangleVertices y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasTriangleVertices other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasTriangleVertices canvasTriangleVertices)
        {
            return this == canvasTriangleVertices;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Vertex1.GetHashCode() ^ Vertex2.GetHashCode() ^ Vertex3.GetHashCode();
    }
}