using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Csharp.ViewModels
{
    public class MainWindowViewModel
    {

        public MainWindowViewModel()
        {
            Shild_Up_ClickCommand=new DelegateCommand(Shild_Up_Click);  
        }
        private readonly IRegionManager _regionManager;



        public ICommand Shild_Up_ClickCommand { get; set; } 
        

        public int Shild_Up;

        public int Level { get; set; } = 1;
        public string Name { get; set; } 
        public int Health { get; set; } 
        public int TempHealth { get; set; }

        public void Shild_Up_Click()
        {
            Level = 10;
        }
    }
}
