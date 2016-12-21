using System;
namespace MyAppStart.Lib.Services
{
	public class WasStartCalledService : IWasStartCalledService
	{
		private bool _startWasCalled;
		public bool WasStartCalled
		{
			get
			{
				return _startWasCalled;
			}
			set
			{
				_startWasCalled = value;
			}
		}
		public WasStartCalledService()
		{
			_startWasCalled = false;
		}

	}
}
