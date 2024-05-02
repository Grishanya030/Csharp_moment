using Pathfinder2E.Main.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pathfinder2E.Main.Models.MicroModels;

namespace Pathfinder2E.Main.Models
{
    public class Model : ReactiveObject
    {
        [Reactive] public string Name { get; set; }

        [Reactive] public int Level { get; set; }
        [Reactive] public string Size { get; set; }
        [Reactive] public string Speed { get; set; }

        [Reactive] public HPData Hp { get; set; }

        [Reactive] public MicroModel Defence { get; set; }
        public bool shildUp;

        // скилы
        [Reactive] public MicroModel Strengh { get; set; }
        [Reactive] public MicroModel Dexterity { get; set; }
        [Reactive] public MicroModel Constitution { get; set; }
        [Reactive] public MicroModel Intelegence { get; set; }
        [Reactive] public MicroModel Wisdom { get; set; }
        [Reactive] public MicroModel Charisma { get; set; }

        //спасброски
        [Reactive] public MicroModel Fortitude { get; set; }
        [Reactive] public MicroModel Reflex { get; set; }
        [Reactive] public MicroModel Will { get; set; }
        //Языки и тп 
        public ObservableCollection<string> Languages { get; } = new();
        public ObservableCollection<string> Instruments { get; } = new();
        public ObservableCollection<SkillBlock> Lores { get; } = new();

        //навыки
        [Reactive] public SkillBlock Arcana { get; set; }
        public Model()
        {
            Name = "Игорёчек";
            Level = 3;

            Hp= new HPData("Нр", 22, 22);

            Defence = new("КД", 10);
            shildUp = false;
            // скилы
            Intelegence = new MicroModel("Интелект", 10);
            Dexterity = new MicroModel("Ловкость", 10);
            Constitution = new MicroModel("Телосложение", 10);
            Strengh = new MicroModel("Сила", 10);
            Wisdom = new MicroModel("Мудрость", 10);
            Charisma = new MicroModel("Харизма", 10);
            //спасброски
            Fortitude = new("Стойкость", 10);
            Reflex = new("Рефлексы", 10);
            Will = new("Воля", 10);
            //навыки
            Arcana = new SkillBlock("Аркана", Intelegence.Value, 1, Level);
            Lores.Add(new SkillBlock("Знания: проба", Intelegence.Value, 1, Level));
        }



        #region Вверх/вниз скиллы

        public void StrUp()
        {
            Strengh.Value += 1;

        }
        public void StrDown()
        {
            Strengh.Value -= 1;

        }
        public void DexUp()
        {
            Dexterity.Value += 1;
            Reflex.Value += 1;

        }
        public void DexDown()
        {
            Dexterity.Value -= 1;
            Reflex.Value -= 1;
        }
        public void ConUp()
        {
            Constitution.Value += 1;
            Fortitude.Value += 1;

        }
        public void ConDown()
        {
            Constitution.Value -= 1;
            Fortitude.Value -= 1;
        }
        public void IntUp() 
        {
            Intelegence.Value += 1;
            Arcana.Refresh(Intelegence.Value, 1, Level);
            Will.Value += 1;
           
        }
        public void IntDown()
        {
            Intelegence.Value -= 1;
            Arcana.Refresh(Intelegence.Value, 1, Level);
            Will.Value -= 1;
            
        }


        #endregion

    }
}
