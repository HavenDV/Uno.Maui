#nullable disable
using System;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Compatibility.Platform.Tizen
{
	[Obsolete]
	internal class ResourcesProvider : ISystemResourcesProvider
	{
		ResourceDictionary _dictionary;

		public IResourceDictionary GetSystemResources()
		{
			_dictionary = new ResourceDictionary();

			UpdateStyles();

			return _dictionary;
		}

		void UpdateStyles()
		{
			_dictionary[Device.Styles.BodyStyleKey] = GetStyleByKey(Device.Styles.BodyStyleKey);
			_dictionary[Device.Styles.TitleStyleKey] = GetStyleByKey(Device.Styles.TitleStyleKey);
			_dictionary[Device.Styles.SubtitleStyleKey] = GetStyleByKey(Device.Styles.SubtitleStyleKey);
			_dictionary[Device.Styles.CaptionStyleKey] = GetStyleByKey(Device.Styles.CaptionStyleKey);
			_dictionary[Device.Styles.ListItemTextStyleKey] = GetStyleByKey(Device.Styles.ListItemTextStyleKey);
			_dictionary[Device.Styles.ListItemDetailTextStyleKey] = GetStyleByKey(Device.Styles.ListItemDetailTextStyleKey);
		}

		Style GetStyleByKey(string key)
		{
			Style style = null;
			if (key == Device.Styles.TitleStyleKey)
			{
				style = GetStyle(50, Color.FromRgb(250, 250, 250));
			}
			else if (key == Device.Styles.SubtitleStyleKey)
			{
				style = GetStyle(24, Color.FromRgb(250, 250, 250));
			}
			else if (key == Device.Styles.CaptionStyleKey)
			{
				style = GetStyle(24, Color.FromRgb(115, 115, 115));
			}
			else if (key == Device.Styles.ListItemTextStyleKey)
			{
				style = GetStyle(40, Color.FromRgb(0, 0, 0));
			}
			else if (key == Device.Styles.ListItemDetailTextStyleKey)
			{
				style = GetStyle(24, Color.FromRgb(0, 0, 0));
			}
			else
			{
				style = GetStyle();
			}

			return style;
		}

		Style GetStyle(int? fontSize = null, Color textColor = null)
		{
			Style style = new Style(typeof(Label));
			if (fontSize.HasValue)
			{
				style.Setters.Add(new Setter { Property = Label.FontSizeProperty, Value = fontSize });
			}
			if (textColor != null)
			{
				style.Setters.Add(new Setter { Property = Label.TextColorProperty, Value = textColor });
			}
			return style;
		}
	}
}
