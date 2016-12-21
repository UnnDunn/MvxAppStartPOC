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

			Mvx.RegisterType<IWasStartCalledService, WasStartCalledService>();

			var startCalledService = Mvx.Resolve<IWasStartCalledService>();
			Mvx.RegisterSingleton<IMvxAppStart>(new CallStartAppStart(startCalledService));
		}
	}
}
