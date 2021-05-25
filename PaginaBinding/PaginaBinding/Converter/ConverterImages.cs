using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginaBinding.Converter
{
    public class ConverterImages : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int numero = (int)value;
            if (numero>0)
            {
                return "arriba.png";
            }
            else{
                return "abajo.png";
            }
            /* if (numero>0)
            {
                return "https://images.emojiterra.com/twitter/v13.0/512px/2b06.png";
            }
            else{
                return "https://image.flaticon.com/icons/png/512/37/37340.png";
            }*/
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
