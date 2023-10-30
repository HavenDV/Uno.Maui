using System.Runtime.InteropServices;
using Windows.UI.Text;
using WinRT;

namespace Microsoft.Graphics.Canvas.Text;

public sealed class CanvasTextFormat : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasTextFormat>
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

    public bool Equals(CanvasTextFormat other)
    {
        throw new NotImplementedException();
    }
    
    
    public ICanvasTextInlineObject CustomTrimmingSign
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasTextDirection Direction
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string FontFamily
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float FontSize
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public FontStretch FontStretch
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public FontStyle FontStyle
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public FontWeight FontWeight
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasHorizontalAlignment HorizontalAlignment
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float IncrementalTabStop
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool LastLineWrapping
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float LineSpacing
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public float LineSpacingBaseline
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasLineSpacingMode LineSpacingMode
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string LocaleName
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasOpticalAlignment OpticalAlignment
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasDrawTextOptions Options
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string TrimmingDelimiter
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public int TrimmingDelimiterCount
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasTextTrimmingGranularity TrimmingGranularity
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasTrimmingSign TrimmingSign
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasVerticalAlignment VerticalAlignment
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasVerticalGlyphOrientation VerticalGlyphOrientation
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasWordWrapping WordWrapping
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}