using System.Windows;

namespace Pathfinder2E.Main.Converters
{
    internal class VisibilityConvertor: BooleanConverters<Visibility, VisibilityConvertor>
    {

        public VisibilityConvertor() : base(Visibility.Visible, Visibility.Collapsed)
        {

        }
    }
}
