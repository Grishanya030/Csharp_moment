using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pathfinder2E.Main.Converters
{
    class ColorConvertor : BooleanConverters<string, ColorConvertor>
    {
        public ColorConvertor() : base("#FFB4E0DB", "#FFDDDDDD")
        {

        }
    }
}
