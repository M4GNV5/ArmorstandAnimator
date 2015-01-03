using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ArmorstandAnimator.GUI.XAML.Converters
{
	public class ZeroToDisabledConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (!(value is int))
				return true;

			int count = (int)value;

			if (count == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return 0;
		}
	}
}