using System;
namespace MyAppStart.Lib.Services
{

	public interface IWasStartCalledService
	{
		bool WasStartCalled();

		void CallStart();
	}
}
