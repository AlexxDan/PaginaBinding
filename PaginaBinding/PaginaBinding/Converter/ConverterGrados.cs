using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginaBinding.Converter
{
    public class ConverterGrados : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString()!="")
                {
                    double c = Double.Parse(value.ToString());
                    double f = (c*1.8) + (32);
                    return f;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
