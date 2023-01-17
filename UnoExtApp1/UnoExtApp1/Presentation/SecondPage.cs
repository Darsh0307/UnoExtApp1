﻿namespace UnoExtApp1.Presentation;

public sealed partial class SecondPage : Page
{
	public SecondPage()
	{
		this.DataContext<BindableSecondModel>((page, vm) => page
			.Background(Theme.Brushes.Background.Default)
			.Content(new Grid().Children(
				new NavigationBar()
					.Content("Second Page")
					.MainCommand(new AppBarButton()
						.Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///UnoExtApp1/Assets/Icons/back.png")))
					),
				new TextBlock()
					.Text(() => vm.Entity.Name)
					.HorizontalAlignment(HorizontalAlignment.Center)
					.VerticalAlignment(VerticalAlignment.Center))));
	}
}

