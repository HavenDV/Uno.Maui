using System;
using System.Numerics;
using WinRT;

namespace Microsoft.Graphics.Canvas.Brushes;

public struct CanvasGradientStopHdr : IEquatable<CanvasGradientStopHdr>
{
    public float Position;

    public Vector4 Color;

    public CanvasGradientStopHdr(float _Position, Vector4 _Color)
    {
        Position = _Position;
        Color = _Color;
    }

    public static bool operator ==(CanvasGradientStopHdr x, CanvasGradientStopHdr y)
    {
        if (x.Position == y.Position)
        {
            return x.Color == y.Color;
        }

        return false;
    }

    public static bool operator !=(CanvasGradientStopHdr x, CanvasGradientStopHdr y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasGradientStopHdr other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasGradientStopHdr canvasGradientStopHdr)
        {
            return this == canvasGradientStopHdr;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Position.GetHashCode() ^ Color.GetHashCode();
    }
}