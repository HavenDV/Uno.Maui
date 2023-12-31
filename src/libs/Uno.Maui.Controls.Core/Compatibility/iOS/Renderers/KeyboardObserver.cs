#nullable disable
using System;
using ObjCRuntime;
using UIKit;

namespace Microsoft.Maui.Controls.Compatibility.Platform.iOS
{
	internal static class KeyboardObserver
	{
		static KeyboardObserver()
		{
			UIKeyboard.Notifications.ObserveWillShow(OnKeyboardShown);
			UIKeyboard.Notifications.ObserveWillHide(OnKeyboardHidden);
		}

		public static event EventHandler<UIKeyboardEventArgs> KeyboardWillHide;

		public static event EventHandler<UIKeyboardEventArgs> KeyboardWillShow;

		static void OnKeyboardHidden(object sender, UIKeyboardEventArgs args)
		{
			var handler = KeyboardWillHide;
			if (handler != null)
				handler(sender, args);
		}

		static void OnKeyboardShown(object sender, UIKeyboardEventArgs args)
		{
			var handler = KeyboardWillShow;
			if (handler != null)
				handler(sender, args);
		}
	}
}