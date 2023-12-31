﻿using System.Threading.Tasks;
using Android.Views;
using Android.Widget;
using Microsoft.Maui.Handlers;
using Xunit;

namespace Microsoft.Maui.DeviceTests
{
	public partial class ViewHandlerTests
	{
		[Fact]
		public async Task ChildIsVisibleIfWrapperIsVisible()
		{
			await InvokeOnMainThreadAsync(() =>
			{
				var child = new Button(MauiContext.Context);
				child.Visibility = ViewStates.Gone;

				var wrapper = new WrapperView(MauiContext.Context);
				wrapper.Visibility = ViewStates.Gone;
				wrapper.AddView(child);

				Assert.Equal(Android.Views.ViewStates.Gone, wrapper.Visibility);
				Assert.Equal(Android.Views.ViewStates.Gone, child.Visibility);

				wrapper.Visibility = ViewStates.Visible;

				Assert.Equal(Android.Views.ViewStates.Visible, wrapper.Visibility);
				Assert.Equal(Android.Views.ViewStates.Visible, child.Visibility);
			});
		}
	}
}