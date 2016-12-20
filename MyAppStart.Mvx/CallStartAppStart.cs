using MvvmCross.Core.ViewModels;
using MyAppStart.Core.Services;
using PlatformMvx = MvvmCross.Platform.Mvx;

namespace MyAppStart.Mvx
{

	public class CallStartAppStart : MvxNavigatingObject, IMvxAppStart
	{
		private IWasStartCalledService _wasStartCalledService;
		public CallStartAppStart(IWasStartCalledService wasStartCalledService)
		{
			_wasStartCalledService = wasStartCalledService;
		}

		public void Start(object hint = null)
		{
			// if all is well, this call will indicate it
			_wasStartCalledService.CallStart();

			ShowViewModel<MainViewModel>();
		}
	}
}
