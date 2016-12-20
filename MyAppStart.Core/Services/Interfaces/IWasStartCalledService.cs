using System;
namespace MyAppStart.Core.Services
{

	public interface IWasStartCalledService
	{
		bool WasStartCalled();

		void CallStart();
	}
}
