using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

using MyAppStart.Lib.Services;

namespace MyAppStart.Core
{
	public class App : MvxApplication
	{
		public App()
		{
		}

		public override void Initialize()
		{
			base.Initialize();

			var appStart = new AppStart();
			Mvx.RegisterSingleton<IMvxAppStart>(appStart);
		}
	}
}
