using Android.Content;
using MvvmCross.Droid.Platform;
using MyAppStart.Core;

namespace MyAppStart
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context appContext) : base(appContext)
		{
		}

		protected override MvvmCross.Core.ViewModels.IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}
