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
    /// Логика взаимодействия для SmallBlock.xaml
    /// </summary>
    public partial class SmallBlock : UserControl
    {
        public SmallBlock()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string value;
        public string Value
        {
            get { return "+" + this.value; }
            set { this.value = value; }
        }

        public string Type { get; set; }
    }
}
