
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExample
{
	public partial class OpacityBindingCodePage : ContentPage
	{
		public OpacityBindingCodePage()
		{
			Label label = new Label
			{
				Text = "Opacicty Binding Demo",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.Center
			};

			Slider slider = new Slider
			{
				VerticalOptions = LayoutOptions.Center
			};

			label.BindingContext = slider;

			label.SetBinding(Label.OpacityProperty, "Value");

			Padding = new Thickness(10, 0);

			Content = new StackLayout
			{
				Children = { label, slider }
			};
		}
	}
}
