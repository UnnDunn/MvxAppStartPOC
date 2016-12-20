using Android.App;
using MvvmCross.Droid.Views;

namespace MyAppStart.Activities
{
	[Activity(Label = "MyAppStart", MainLauncher = true)]
	public class MainActivity : MvxActivity
	{
		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.Main);
		}
	}
}

