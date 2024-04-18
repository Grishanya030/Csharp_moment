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
using Pathfinder2E.Main.Models;
using Pathfinder2E.Main.Components;
using static Pathfinder2E.Main.Models.MicroModels;

namespace Pathfinder2E.Main.ViewModels
{
    public class MainViewModel : ReactiveObject
    {

        private readonly IRegionManager _regionManager;
        
        public MainViewModel(IEventAggregator eventAggregator, IRegionManager regionManager, Model model)
        {
            var eventAggregator1 = eventAggregator;
            _regionManager = regionManager;
            Model = model;

            //eventAggregator1
            //    .GetEvent<ShildChange>()
            //    .Subscribe(OnInputChanged);

            //Hp = new HPData("Нр", 22, 8 * Model.Level);

            ShildUpClickCommand = new DelegateCommand(ShildUpClick);

            #region Подключение кубов
            DiceClearCommand = new DelegateCommand(DiceClear);

            RollD4_1Command = new DelegateCommand(RollD4_1);
            RollD4_2Command = new DelegateCommand(RollD4_2);
            RollD4_3Command = new DelegateCommand(RollD4_3);
            RollD6_1Command = new DelegateCommand(RollD6_1);
            RollD6_2Command = new DelegateCommand(RollD6_2);
            RollD6_3Command = new DelegateCommand(RollD6_3);
            RollD8_1Command = new DelegateCommand(RollD8_1);
            RollD8_2Command = new DelegateCommand(RollD8_2);
            RollD8_3Command = new DelegateCommand(RollD8_3);
            RollD10_1Command = new DelegateCommand(RollD10_1);
            RollD10_2Command = new DelegateCommand(RollD10_2);
            RollD10_3Command = new DelegateCommand(RollD10_3);
            RollD12_1Command = new DelegateCommand(RollD12_1);
            RollD12_2Command = new DelegateCommand(RollD12_2);
            RollD12_3Command = new DelegateCommand(RollD12_3);
            RollD20_1Command = new DelegateCommand(RollD20_1);
            RollD20_2Command = new DelegateCommand(RollD20_2);
            RollD20_3Command = new DelegateCommand(RollD20_3);
            #endregion
        }


        public ICommand ShildUpClickCommand { get; set; }

        #region ICommand для кубов
        public ICommand DiceClearCommand { get; set; }
        public ICommand RollD4_1Command { get; set; }
        public ICommand RollD4_2Command { get; set; }
        public ICommand RollD4_3Command { get; set; }
        public ICommand RollD6_1Command { get; set; }
        public ICommand RollD6_2Command { get; set; }
        public ICommand RollD6_3Command { get; set; }
        public ICommand RollD8_1Command { get; set; }
        public ICommand RollD8_2Command { get; set; }
        public ICommand RollD8_3Command { get; set; }
        public ICommand RollD10_1Command { get; set; }
        public ICommand RollD10_2Command { get; set; }
        public ICommand RollD10_3Command { get; set; }
        public ICommand RollD12_1Command { get; set; }
        public ICommand RollD12_2Command { get; set; }
        public ICommand RollD12_3Command { get; set; }
        public ICommand RollD20_1Command { get; set; }
        public ICommand RollD20_2Command { get; set; }
        public ICommand RollD20_3Command { get; set; }
        #endregion

        public Model Model { get; }
        [Reactive] public bool ShieldCheck { get; set; } = true;


        public string Name { get; set; } = "Игорёчек";
        //[Reactive] public int Level { get; set; } = 121;
        [Reactive] public MicroModel Defence { get; set; } = new("КД", 10);

        [Reactive] public MicroModel Fortitude { get; set; } = new("Стойкость", 10);
        [Reactive] public MicroModel Reflex { get; set; } = new("Рефлексы", 10);
        [Reactive] public MicroModel Will { get; set; } = new("Воля", 10);

        //[Reactive] public HpBlockClass Hp { get; set; } = new("Нр", 22, 22);
        [Reactive] public HPData Hp { get; set; } = new HPData("Нр", 22, 22);

        [Reactive] public string DiceResult { get; set; } = string.Empty;
        [Reactive] public int DiceSumm { get; set; } = 0;
        

        bool shildUp = false;

        public void ShildUpClick()
        {
            if (shildUp) { Defence.Value -= 2; shildUp = false; }
            else { Defence.Value += 2; shildUp = true; }
            Model.Level += 2;
        }

        #region Функции для кубов
        public void DiceClear()
        {
            DiceResult = string.Empty;
            DiceSumm = 0;
        }
        public void Roll(int dice, int numb)
        {
            if (DiceResult != string.Empty) { DiceResult += " + "; }
            Random rnd = new Random();
            for (int i = 0; i < numb - 1; i++)
            {
                int value = rnd.Next(dice) + 1;
                DiceSumm += value;
                DiceResult += value + " + ";
            }
            int v = rnd.Next(dice) + 1;
            DiceSumm += v;
            DiceResult += v;
        }
        public void RollD4_1() { Roll(4, 1); }
        public void RollD4_2() { Roll(4, 2); }
        public void RollD4_3() { Roll(4, 3); }
        public void RollD6_1() { Roll(6, 1); }
        public void RollD6_2() { Roll(6, 2); }
        public void RollD6_3() { Roll(6, 3); }
        public void RollD8_1() { Roll(8, 1); }
        public void RollD8_2() { Roll(8, 2); }
        public void RollD8_3() { Roll(8, 3); }
        public void RollD10_1() { Roll(10, 1); }
        public void RollD10_2() { Roll(10, 2); }
        public void RollD10_3() { Roll(10, 3); }
        public void RollD12_1() { Roll(12, 1); }
        public void RollD12_2() { Roll(12, 2); }
        public void RollD12_3() { Roll(12, 3); }
        public void RollD20_1() { Roll(20, 1); }
        public void RollD20_2() { Roll(20, 2); }
        public void RollD20_3() { Roll(20, 3); }
        #endregion
    }
}
