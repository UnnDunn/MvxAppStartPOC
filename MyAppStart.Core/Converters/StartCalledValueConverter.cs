using System;
using MvvmCross.Platform.Converters;

namespace MyAppStart.Core.Converters
{
	public class StartCalledValueConverter : MvxValueConverter<bool, string>
	{
		protected override string Convert(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value
				? "Yup, looks like it was called. Yay."
					: "Nope, definitely wasn't called. Boo.";
		}
	}
}
