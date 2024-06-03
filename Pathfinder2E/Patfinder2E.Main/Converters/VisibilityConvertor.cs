using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pathfinder2E.Shell.Converters
{
    internal class VisibilityConvertor: BooleanConverters<Visibility, VisibilityConvertor>
    {

        public VisibilityConvertor() : base(Visibility.Visible, Visibility.Collapsed)
        {

        }
    }
}
