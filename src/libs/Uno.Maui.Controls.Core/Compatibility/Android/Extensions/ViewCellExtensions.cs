#nullable disable
using Android.Views;
using AView = Android.Views.View;

namespace Microsoft.Maui.Controls.Compatibility.Platform.Android
{
	internal static class ViewCellExtensions
	{
		public static bool IsInViewCell(this VisualElement element)
		{
			var parent = element.Parent;
			while (parent != null)
			{
				if (parent is ViewCell)
				{
					return true;
				}
				parent = parent.Parent;
			}

			return false;
		}
	}
}