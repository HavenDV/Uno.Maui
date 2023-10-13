using Microsoft.Maui.Devices;

namespace Microsoft.Maui
{
	public static partial class WindowExtensions
	{
		public static DisplayOrientation GetOrientation(this IWindow? window) =>
			DeviceDisplay.Current.MainDisplayInfo.Orientation;
	}
}
