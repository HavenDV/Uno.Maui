using System.Runtime.InteropServices;
using Windows.UI.Text;
using WinRT;
using Size = Windows.Foundation.Size;
using Rect = Windows.Foundation.Rect;

namespace Microsoft.Graphics.Canvas.Text;

public sealed class CanvasTextLayout : IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasTextLayout>
{
    public CanvasTextLayout(ICanvasResourceCreator resourceCreator, string textString, CanvasTextFormat textFormat, float requestedWidth, float requestedHeight)
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

    public bool Equals(CanvasTextLayout other)
    {
        throw new NotImplementedException();
    }
    
    public IntPtr Create(ICanvasResourceCreator resourceCreator, string textString, CanvasTextFormat textFormat, float requestedWidth, float requestedHeight)
    {
        throw new NotImplementedException();
    }
    
    public CanvasClusterMetrics[] ClusterMetrics => throw new NotImplementedException();

    public ICanvasTextInlineObject CustomTrimmingSign
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string DefaultFontFamily => throw new NotImplementedException();

    public float DefaultFontSize => throw new NotImplementedException();

    public FontStretch DefaultFontStretch => throw new NotImplementedException();

    public FontStyle DefaultFontStyle => throw new NotImplementedException();

    public FontWeight DefaultFontWeight => throw new NotImplementedException();

    public string DefaultLocaleName => throw new NotImplementedException();

    public CanvasDevice Device => throw new NotImplementedException();

    public CanvasTextDirection Direction
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Rect DrawBounds => throw new NotImplementedException();

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

    public Rect LayoutBounds => throw new NotImplementedException();

    public Rect LayoutBoundsIncludingTrailingWhitespace => throw new NotImplementedException();

    public int LineCount => throw new NotImplementedException();

    public CanvasLineMetrics[] LineMetrics => throw new NotImplementedException();

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

    public int MaximumBidiReorderingDepth => throw new NotImplementedException();

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

    public Size RequestedSize
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