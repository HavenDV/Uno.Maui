using System.ComponentModel;

namespace WinRT;

[EditorBrowsable(EditorBrowsableState.Never)]
public class DerivedComposed
{
    public static readonly DerivedComposed Instance = new DerivedComposed();

    private DerivedComposed()
    {
    }
}