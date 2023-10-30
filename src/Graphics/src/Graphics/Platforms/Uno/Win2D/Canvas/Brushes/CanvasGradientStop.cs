using System;
using Windows.UI;
using WinRT;

namespace Microsoft.Graphics.Canvas.Brushes;

public struct CanvasGradientStop : IEquatable<CanvasGradientStop>
{
    public float Position;

    public Color Color;

    public CanvasGradientStop(float _Position, Color _Color)
    {
        Position = _Position;
        Color = _Color;
    }

    public static bool operator ==(CanvasGradientStop x, CanvasGradientStop y)
    {
        if (x.Position == y.Position)
        {
            return x.Color == y.Color;
        }

        return false;
    }

    public static bool operator !=(CanvasGradientStop x, CanvasGradientStop y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasGradientStop other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasGradientStop canvasGradientStop)
        {
            return this == canvasGradientStop;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Position.GetHashCode() ^ Color.GetHashCode();
    }
}