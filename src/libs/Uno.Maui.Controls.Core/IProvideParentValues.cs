#nullable disable
using System.Collections.Generic;

namespace Microsoft.Maui.Controls.Xaml
{
	public interface IProvideParentValues : IProvideValueTarget
	{
		IEnumerable<object> ParentObjects { get; }
	}
}