#nullable disable
using System;
using System.Windows.Input;

namespace Microsoft.Maui.Controls
{
	public interface ISwipeItem : Maui.ISwipeItem
	{
		bool IsVisible { get; set; }
		ICommand Command { get; set; }
		object CommandParameter { get; set; }

		event EventHandler<EventArgs> Invoked;
	}
}