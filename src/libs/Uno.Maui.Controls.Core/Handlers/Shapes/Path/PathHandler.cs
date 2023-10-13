#nullable disable
using Microsoft.Maui.Controls.Shapes;

namespace Microsoft.Maui.Controls.Handlers
{
	public partial class PathHandler : ShapeViewHandler
	{
		public static new IPropertyMapper<Microsoft.Maui.Controls.Shapes.Path, IShapeViewHandler> Mapper = new PropertyMapper<Microsoft.Maui.Controls.Shapes.Path, IShapeViewHandler>(ShapeViewHandler.Mapper)
		{
			[nameof(IShapeView.Shape)] = MapShape,
			[nameof(Microsoft.Maui.Controls.Shapes.Path.Data)] = MapData,
			[nameof(Microsoft.Maui.Controls.Shapes.Path.RenderTransform)] = MapRenderTransform,
		};

		public PathHandler() : base(Mapper)
		{

		}

		public PathHandler(IPropertyMapper mapper) : base(mapper ?? Mapper)
		{

		}
	}
}