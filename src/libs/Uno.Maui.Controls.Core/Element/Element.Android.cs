﻿using Microsoft.Maui.Controls.Platform;

namespace Microsoft.Maui.Controls
{
	public partial class Element
	{
		public static void MapAutomationPropertiesIsInAccessibleTree(IElementHandler handler, Element element)
		{
			Platform.AutomationPropertiesProvider.SetImportantForAccessibility(
				handler.PlatformView as Android.Views.View, element);
		}

		public static void MapAutomationPropertiesExcludedWithChildren(IElementHandler handler, Element element)
		{
			Platform.AutomationPropertiesProvider.SetImportantForAccessibility(
				handler.PlatformView as Android.Views.View, element);
		}

		static void MapAutomationPropertiesIsInAccessibleTree(IElementHandler handler, IElement element)
		{
			if (element is Element e)
				MapAutomationPropertiesIsInAccessibleTree(handler, e);
		}

		static void MapAutomationPropertiesExcludedWithChildren(IElementHandler handler, IElement element)
		{
			if (element is Element e)
				MapAutomationPropertiesExcludedWithChildren(handler, e);
		}
	}
}
