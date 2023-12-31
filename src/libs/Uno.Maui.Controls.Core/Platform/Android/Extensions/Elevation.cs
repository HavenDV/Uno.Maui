#nullable disable
using Android.Content;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace Microsoft.Maui.Controls.Platform
{
	public static class ElevationHelper
	{
		public static void SetElevation(global::Android.Views.View view, VisualElement element)
		{
			if (view == null || element == null)
			{
				return;
			}

			var elevation = GetElevation(element, view.Context);
			SetElevation(view, elevation);
		}

		public static void SetElevation(global::Android.Views.View view, float? elevation)
		{
			if (view == null)
			{
				return;
			}

			if (!elevation.HasValue)
			{
				return;
			}

			view.Elevation = elevation.Value;
		}

		internal static float? GetElevation(global::Android.Views.View view)
		{
			if (view == null)
			{
				return null;
			}

			return view.Elevation;
		}

		internal static float? GetElevation(VisualElement element, Context context)
		{
			if (element == null)
			{
				return null;
			}

			var iec = element as IElementConfiguration<VisualElement>;
			var elevation = iec?.On<PlatformConfiguration.Android>().GetElevation();

			if (elevation == null)
				return elevation;

			return context.ToPixels(elevation.Value);
		}
	}
}