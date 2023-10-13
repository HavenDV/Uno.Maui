#nullable enable
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui
{
	public class ImageSourcePaint : Paint
	{
		public ImageSourcePaint()
		{
		}

		public ImageSourcePaint(IImageSource imageSource)
		{
			ImageSource = imageSource;
		}

		public IImageSource? ImageSource { get; set; }
	}
}