using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Playboy
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}
		[Test]
		public void FirstTest()
		{
			app.Tap("tabGreatest");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Greatest' Tab");

			app.ScrollDown();
			Thread.Sleep(8000);
			app.Screenshot("Scrolling down to see more information");

			app.Tap("title");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on a Gallery");

			app.Tap("arrowNext");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on the 'next' arrow");

			app.Tap("arrowNext");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on the 'next' arrow");

			app.Tap("arrowNext");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on the 'next' arrow");

			app.Back();
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Back' Button");

			app.Tap("topBarRightButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Hamburger' Icon");

			app.Tap("articlesButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Articles' Button");

			app.Tap("title");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on an article");

			app.Tap("doneButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Done' Button");

			app.Tap("topBarRightButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Hamburger' Icon");

			app.Tap("videosButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Video' Button");

			app.ScrollDown();
			Thread.Sleep(8000);
			app.Screenshot("Scrolling down for more information");

			app.Tap("topBarRightButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Hamburger' Icon");

			app.Tap("searchButton");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Search' Button");


		}



	}
}
