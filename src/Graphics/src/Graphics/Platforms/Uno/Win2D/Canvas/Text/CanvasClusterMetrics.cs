using System;
using WinRT;

namespace Microsoft.Graphics.Canvas.Text;

public struct CanvasClusterMetrics : IEquatable<CanvasClusterMetrics>
{
    public int CharacterCount;

    public float Width;

    public CanvasClusterProperties Properties;

    public CanvasClusterMetrics(int _CharacterCount, float _Width, CanvasClusterProperties _Properties)
    {
        CharacterCount = _CharacterCount;
        Width = _Width;
        Properties = _Properties;
    }

    public static bool operator ==(CanvasClusterMetrics x, CanvasClusterMetrics y)
    {
        if (x.CharacterCount == y.CharacterCount && x.Width == y.Width)
        {
            return x.Properties == y.Properties;
        }

        return false;
    }

    public static bool operator !=(CanvasClusterMetrics x, CanvasClusterMetrics y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasClusterMetrics other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasClusterMetrics canvasClusterMetrics)
        {
            return this == canvasClusterMetrics;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CharacterCount.GetHashCode() ^ Width.GetHashCode() ^ Properties.GetHashCode();
    }
}