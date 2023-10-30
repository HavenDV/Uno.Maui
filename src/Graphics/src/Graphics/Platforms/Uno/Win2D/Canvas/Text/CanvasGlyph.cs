using System;
using WinRT;

namespace Microsoft.Graphics.Canvas.Text;

public struct CanvasGlyph : IEquatable<CanvasGlyph>
{
    public int Index;

    public float Advance;

    public float AdvanceOffset;

    public float AscenderOffset;

    public CanvasGlyph(int _Index, float _Advance, float _AdvanceOffset, float _AscenderOffset)
    {
        Index = _Index;
        Advance = _Advance;
        AdvanceOffset = _AdvanceOffset;
        AscenderOffset = _AscenderOffset;
    }

    public static bool operator ==(CanvasGlyph x, CanvasGlyph y)
    {
        if (x.Index == y.Index && x.Advance == y.Advance && x.AdvanceOffset == y.AdvanceOffset)
        {
            return x.AscenderOffset == y.AscenderOffset;
        }

        return false;
    }

    public static bool operator !=(CanvasGlyph x, CanvasGlyph y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasGlyph other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasGlyph canvasGlyph)
        {
            return this == canvasGlyph;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Index.GetHashCode() ^ Advance.GetHashCode() ^ AdvanceOffset.GetHashCode() ^ AscenderOffset.GetHashCode();
    }
}