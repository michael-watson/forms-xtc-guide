using System;

using Xamarin.Forms;

namespace XtcGuide
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "XtcGuide",
				Content = new StackLayout
				{
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						new WebView { AutomationId = "MyWebView", Source = "https://www.google.com/",WidthRequest = 300, HeightRequest = 300 }
					}
				}
			};

			content.ToolbarItems.Add(new ToolbarItem { AutomationId = "OneButton", Text = "One", Icon = "icon.png" });
			content.ToolbarItems.Add(new ToolbarItem { AutomationId = "TwoButton", Text = "Two", Icon = "icon.png" });

			MainPage = new NavigationPage(content);
		}
	}
}
