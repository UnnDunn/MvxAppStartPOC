using Android.App;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

using MyAppStart.Core;

namespace MyAppStart.Activities
{
	[Activity(Label = "MainView")]
	public class MainView : MvxActivity<MainViewModel>
	{
		protected override void OnCreate(Android.OS.Bundle bundle)
		{
			base.OnCreate(bundle);
			//view model should be available

		}
		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.Main);
		}
	}
}

