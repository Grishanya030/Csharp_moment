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
            ShildUpClickCommand=new DelegateCommand(ShildUpClick);  
        }
        private readonly IRegionManager _regionManager;

        public ICommand ShildUpClickCommand { get; set; } 
        

        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Defence { get; set; }
        public int Health { get; set; }   
        public int TempHealth { get; set; }

        public int Death { get; set; }
        public int Injured { get; set; }   
        public int Fortitude { get; set; }
        public int Will { get; set; }
        public int Reflex { get; set; }
        public string ShildName { get; set; }
        public int Hardness { get; set; }
        public int ShildHealth { get; set; }
        public int ShildLimit { get; set; } 

        public int Perception { get; set; }

        public void ShildUpClick()
        {
            Level += 1;
        }
    }
}
