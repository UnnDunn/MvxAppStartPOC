using System;
namespace MyAppStart.Lib.Services
{
	public class WasStartCalledService : IWasStartCalledService
	{
		private bool _startWasCalled;

		public WasStartCalledService()
		{
			_startWasCalled = false;
		}

		public void CallStart()
		{
			_startWasCalled = true;
		}

		public bool WasStartCalled()
		{
			return _startWasCalled;
		}
	}
}
