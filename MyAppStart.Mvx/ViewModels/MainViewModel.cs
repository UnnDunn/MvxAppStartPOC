using System;
using MvvmCross.Core.ViewModels;
using MyAppStart.Lib.Services;

namespace MyAppStart.Core
{
	public class MainViewModel : MvxViewModel
	{
		private IWasStartCalledService _wasStartCalledService;

		private bool _wasStartCalled;
		public bool WasStartCalled
		{
			get { return _wasStartCalled; }
			set { SetProperty(ref _wasStartCalled, value); }
		}

		public MainViewModel(IWasStartCalledService wasStartCalledService)
		{
			_wasStartCalledService = wasStartCalledService;
		}

		public void Init()
		{
			Initalize();
		}

		private void Initalize()
		{
			WasStartCalled = _wasStartCalledService.WasStartCalled;	
		}
	}

}
