using System;
using MvvmCross.Core.ViewModels;
using MyAppStart.Core.Services;

namespace MyAppStart.Mvx
{
	public class MainViewModel : MvxViewModel
	{
		private IWasStartCalledService _wasStartCalledService;

		private bool _wasStartCalled;
		public bool WasStartCalled
		{
			get { return _wasStartCalled; }
			set { SetProperty(ref _wasStartCalled, value, nameof(WasStartCalled)); }
		}

		public MainViewModel(IWasStartCalledService wasStartCalledService)
		{
			_wasStartCalledService = wasStartCalledService;
		}
	}

}
