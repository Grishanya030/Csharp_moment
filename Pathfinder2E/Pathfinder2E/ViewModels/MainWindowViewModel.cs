using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using ReactiveUI.Fody.Helpers;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Pathfinder2E.Components;

namespace Pathfinder2E.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {

        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            var eventAggregator1 = eventAggregator;
            _regionManager = regionManager;

            //eventAggregator1
            //    .GetEvent<ShildChange>()
            //    .Subscribe(OnInputChanged);


            ShildUpClickCommand = new DelegateCommand(ShildUpClick);
        }


        public ICommand ShildUpClickCommand { get; set; }


        [Reactive] public bool ShieldCheck { get; set; } = true;


        public string Name { get; set; } = "Игорёчек";
        [Reactive] public int Level { get; set; } = 121;
        [Reactive] public BlockClass Defence { get; set; } = new("КД", 10);

        [Reactive] public BlockClass Fortitude {  get; set; } = new("Стойкость", 10);
        [Reactive] public BlockClass Reflex { get; set; } = new("Рефлексы", 10);
        [Reactive] public BlockClass Will { get; set; } = new("Воля", 10);

        [Reactive] public HpBlockClass Hp { get; set; } = new("Нр", 22, 22);

        public void ShildUpClick()
        {
            Level += 2;
        }
    }
}
