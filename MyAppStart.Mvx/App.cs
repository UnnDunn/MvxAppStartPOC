using MvvmCross.Core.ViewModels;
using MyAppStart.Core.Services;
using PlatformMvx = MvvmCross.Platform.Mvx;

namespace MyAppStart.Mvx
{
	public class App : MvxApplication
	{
		public App()
		{
		}

		public override void Initialize()
		{
			base.Initialize();

			PlatformMvx.RegisterType<IWasStartCalledService, WasStartCalledService>();

			var startCalledService = PlatformMvx.Resolve<IWasStartCalledService>();
			PlatformMvx.RegisterSingleton<IMvxAppStart>(new CallStartAppStart(startCalledService));
		}
	}
}
