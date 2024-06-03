using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pathfinder2E.Shell.Converters
{
    internal class ShildUpConvertor: BooleanConverters<string, ShildUpConvertor>
    {
        public ShildUpConvertor() : base("Опустить щит", "Поднять щит")
        {

        }
    }
}
