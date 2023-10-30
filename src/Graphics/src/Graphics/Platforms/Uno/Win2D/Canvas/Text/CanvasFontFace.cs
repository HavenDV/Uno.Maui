using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.UI.Text;
using WinRT;

namespace Microsoft.Graphics.Canvas.Text;

public sealed class CanvasFontFace : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasFontFace>
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

    public bool Equals(CanvasFontFace other)
    {
        throw new NotImplementedException();
    }
    
    
    public float Ascent => throw new NotImplementedException();

    public float CapHeight => throw new NotImplementedException();

    public float CaretOffset => throw new NotImplementedException();

    public float CaretSlopeRise => throw new NotImplementedException();

    public float CaretSlopeRun => throw new NotImplementedException();

    public float Descent => throw new NotImplementedException();

    public IReadOnlyDictionary<string, string> FaceNames => throw new NotImplementedException();

    public IReadOnlyDictionary<string, string> FamilyNames => throw new NotImplementedException();

    public CanvasFontFileFormatType FileFormatType => throw new NotImplementedException();

    public Rect GlyphBox => throw new NotImplementedException();

    public uint GlyphCount => throw new NotImplementedException();

    public bool HasTypographicMetrics => throw new NotImplementedException();

    public bool HasVerticalGlyphVariants => throw new NotImplementedException();

    public bool IsMonospaced => throw new NotImplementedException();

    public bool IsSymbolFont => throw new NotImplementedException();

    public float LineGap => throw new NotImplementedException();

    public float LowercaseLetterHeight => throw new NotImplementedException();

    public byte[] Panose => throw new NotImplementedException();

    public CanvasFontSimulations Simulations => throw new NotImplementedException();

    public FontStretch Stretch => throw new NotImplementedException();

    public float StrikethroughPosition => throw new NotImplementedException();

    public float StrikethroughThickness => throw new NotImplementedException();

    public FontStyle Style => throw new NotImplementedException();

    public Vector2 SubscriptPosition => throw new NotImplementedException();

    public Size SubscriptSize => throw new NotImplementedException();

    public Vector2 SuperscriptPosition => throw new NotImplementedException();

    public Size SuperscriptSize => throw new NotImplementedException();

    public float UnderlinePosition => throw new NotImplementedException();

    public float UnderlineThickness => throw new NotImplementedException();

    public CanvasUnicodeRange[] UnicodeRanges => throw new NotImplementedException();

    public FontWeight Weight => throw new NotImplementedException();
}