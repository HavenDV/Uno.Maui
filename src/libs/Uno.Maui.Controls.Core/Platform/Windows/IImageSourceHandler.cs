#nullable disable
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Maui.Controls.Platform
{
	public interface IImageSourceHandler : IRegisterable
	{
		Task<Microsoft.UI.Xaml.Media.ImageSource> LoadImageAsync(ImageSource imagesource, CancellationToken cancellationToken = default(CancellationToken));
	}
}