using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MyAppStart.Core;
using MyAppStart.Core.Converters;
using MyAppStart.Lib.Services;

namespace MyAppStart
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context appContext) : base(appContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override MvvmCross.Droid.Views.IMvxAndroidViewPresenter CreateViewPresenter()
		{
			var mvxFragmentPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
			Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentPresenter);
			return mvxFragmentPresenter;
		}

		protected override void InitializeFirstChance()
		{
			Mvx.LazyConstructAndRegisterSingleton<IWasStartCalledService, WasStartCalledService>();

			base.InitializeFirstChance();
		}

		protected override void FillValueConverters(MvvmCross.Platform.Converters.IMvxValueConverterRegistry registry)
		{
			base.FillValueConverters(registry);
			if (registry != null)
			{
				registry.AddOrOverwrite("StartCalled", new StartCalledValueConverter());
			}
		}
	}
}
