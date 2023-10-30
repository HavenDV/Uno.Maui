namespace Microsoft.Graphics.Canvas.Text;

public struct CanvasUnicodeRange : IEquatable<CanvasUnicodeRange>
{
    public uint First;

    public uint Last;

    public CanvasUnicodeRange(uint _First, uint _Last)
    {
        First = _First;
        Last = _Last;
    }

    public static bool operator ==(CanvasUnicodeRange x, CanvasUnicodeRange y)
    {
        if (x.First == y.First)
        {
            return x.Last == y.Last;
        }

        return false;
    }

    public static bool operator !=(CanvasUnicodeRange x, CanvasUnicodeRange y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasUnicodeRange other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasUnicodeRange canvasUnicodeRange)
        {
            return this == canvasUnicodeRange;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return First.GetHashCode() ^ Last.GetHashCode();
    }
}