using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IValueConverter_Xamarin.Forms.Converters {

    public class ColorConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

            if (value as string == "Winter") 
                return Color.FromHex("#2980b9");

            else if(value as string == "Spring") 
                return Color.FromHex("#2ecc71");

            else if (value as string == "Summer")
                return Color.FromHex("#1abc9c");

            else if (value as string == "Autumn")
                return Color.FromHex("#e67e22");

            return Color.FromHex("#000000");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
