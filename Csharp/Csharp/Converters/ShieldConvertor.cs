using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using static System.Resources.ResXFileRef;

namespace Csharp.Converters
{
    public class ShieldConvertor : BooleanConverters<Visibility, ShieldConvertor>
    {

        public ShieldConvertor() : base(Visibility.Visible, Visibility.Collapsed)
        {

        }
        //public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //    => value is true ? "Visible" : "Collapsed";

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
