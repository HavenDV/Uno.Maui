namespace Microsoft.Maui.Controls.Handlers
{
	public partial class BoxViewHandler : ShapeViewHandler
	{
		public bool NeedsContainer =>
			VirtualView?.Clip is not null ||
			VirtualView?.Shadow is not null;
	}
}