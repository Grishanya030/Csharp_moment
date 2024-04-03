using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Csharp.Components
{
    /// <summary>
    /// Логика взаимодействия для HightBlock.xaml
    /// </summary>
    public partial class HighBlock : UserControl
    {
        public HighBlock()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public int Value { get; set; }
        public string Type { get; set; }
        public bool isBlock { get; set; }
    }
}
