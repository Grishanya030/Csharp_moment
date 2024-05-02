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
using DynamicData;
using System.Collections.ObjectModel;
using Microsoft.Xaml.Behaviors.Core;

namespace Pathfinder2E.Main.ViewModels
{
    public class MainViewModel : ReactiveObject
    {

        private readonly IRegionManager _regionManager;
        
        public MainViewModel(IEventAggregator eventAggregator, IRegionManager regionManager, Model model)
        {
            var eventAggregator1 = eventAggregator;
            _regionManager = regionManager;
            this.model = model;

            //eventAggregator1
            //    .GetEvent<ShildChange>()
            //    .Subscribe(OnInputChanged);

            ShildUpClickCommand = new DelegateCommand(ShildUpClick);
            AddLangCommand = new ActionCommand(AddLang);
            DelLangCommand = new DelegateCommand(DelLang);

            //AddInstCommand = new ActionCommand(AddObj(TempInst, Model.Instruments));
            //DelInstCommand = new DelegateCommand(DelObj(TempInst, Model.Instruments));

            #region стрелки на скилах
            StrUp = new DelegateCommand(this.model.StrUp);
            StrDown = new DelegateCommand(this.model.StrDown);
            ConUp = new DelegateCommand(this.model.ConUp);
            ConDown = new DelegateCommand(this.model.ConDown);
            StrUp = new DelegateCommand(this.model.StrUp);
            StrDown = new DelegateCommand(this.model.StrDown);
            IntUp = new DelegateCommand(this.model.IntUp);
            IntDown = new DelegateCommand(this.model.IntDown);
            #endregion

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
        public ICommand AddLangCommand { get; set; }
        public ICommand DelLangCommand { get; set; }
        public ICommand AddInstCommand { get; set; }
        public ICommand DelInstCommand { get; set; }

        #region Повыешение понижение статы
        public ICommand StrUp { get; set; }
        public ICommand StrDown { get; set; }
        public ICommand DexUp { get; set; }
        public ICommand DexDown { get; set; }
        public ICommand ConUp { get; set; }
        public ICommand ConDown { get; set; }
        public ICommand IntUp { get; set; }
        public ICommand IntDown { get; set; }
        public ICommand WisUp { get; set; }
        public ICommand WisDown { get; set; }
        public ICommand ChaUp { get; set; }
        public ICommand ChaDown { get; set; }
        #endregion

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

        public Model model { get; }

        [Reactive] public bool ShieldCheck { get; set; } = true;

        [Reactive] public string TempLang { get; set; } = "";
        [Reactive] public string TempInst { get; set; } = "";

        [Reactive] public string DiceResult { get; set; } = string.Empty;
        [Reactive] public int DiceSumm { get; set; } = 0;


        public void AddLang()
        {
            bool flag = true;
            foreach (string i in model.Languages) if (i == TempLang) flag = false;

            if (flag)
            {
                model.Languages.Add(TempLang);
                TempLang = "";
            }
        }
        public void DelLang()
        {
            model.Languages.Remove(TempLang);
        }
        public void AddObj(string str, ObservableCollection<string> col)
        {
            bool flag = true;
            foreach(string i in col) if (i == str) flag = false;

            if (flag)
            {
                col.Add(str);
                str = "";
            }
        }
        public void DelObj(string str, ObservableCollection<string> col)
        {
            col.Remove(str);
        }
        public void ShildUpClick()
        {
            if (model.shildUp) { model.Defence.Value -= 2; model.shildUp = false; }
            else { model.Defence.Value += 2; model.shildUp = true; }
            model.Intelegence.Value += 2;
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
