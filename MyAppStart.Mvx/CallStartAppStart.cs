using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

using MyAppStart.Lib.Services;

namespace MyAppStart.Core
{
	public class AppStart : MvxNavigatingObject, IMvxAppStart
	{
		public AppStart() {}

		public void Start(object hint = null)
		{
 			var wasStartCalledService = Mvx.Resolve<IWasStartCalledService>();
			// if all is well, this call will indicate it
			wasStartCalledService.WasStartCalled = true;

			ShowViewModel<MainViewModel>();
		}
	}
}
