namespace Microsoft.Graphics.Canvas.Text;

public struct CanvasLineMetrics : IEquatable<CanvasLineMetrics>
{
    public int CharacterCount;

    public int TrailingWhitespaceCount;

    public int TerminalNewlineCount;

    public float Height;

    public float Baseline;

    public bool IsTrimmed;

    public float LeadingWhitespaceBefore;

    public float LeadingWhitespaceAfter;

    public CanvasLineMetrics(int _CharacterCount, int _TrailingWhitespaceCount, int _TerminalNewlineCount, float _Height, float _Baseline, bool _IsTrimmed, float _LeadingWhitespaceBefore, float _LeadingWhitespaceAfter)
    {
        CharacterCount = _CharacterCount;
        TrailingWhitespaceCount = _TrailingWhitespaceCount;
        TerminalNewlineCount = _TerminalNewlineCount;
        Height = _Height;
        Baseline = _Baseline;
        IsTrimmed = _IsTrimmed;
        LeadingWhitespaceBefore = _LeadingWhitespaceBefore;
        LeadingWhitespaceAfter = _LeadingWhitespaceAfter;
    }

    public static bool operator ==(CanvasLineMetrics x, CanvasLineMetrics y)
    {
        if (x.CharacterCount == y.CharacterCount && x.TrailingWhitespaceCount == y.TrailingWhitespaceCount && x.TerminalNewlineCount == y.TerminalNewlineCount && x.Height == y.Height && x.Baseline == y.Baseline && x.IsTrimmed == y.IsTrimmed && x.LeadingWhitespaceBefore == y.LeadingWhitespaceBefore)
        {
            return x.LeadingWhitespaceAfter == y.LeadingWhitespaceAfter;
        }

        return false;
    }

    public static bool operator !=(CanvasLineMetrics x, CanvasLineMetrics y)
    {
        return !(x == y);
    }

    public bool Equals(CanvasLineMetrics other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is CanvasLineMetrics canvasLineMetrics)
        {
            return this == canvasLineMetrics;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CharacterCount.GetHashCode() ^ TrailingWhitespaceCount.GetHashCode() ^ TerminalNewlineCount.GetHashCode() ^ Height.GetHashCode() ^ Baseline.GetHashCode() ^ IsTrimmed.GetHashCode() ^ LeadingWhitespaceBefore.GetHashCode() ^ LeadingWhitespaceAfter.GetHashCode();
    }
}