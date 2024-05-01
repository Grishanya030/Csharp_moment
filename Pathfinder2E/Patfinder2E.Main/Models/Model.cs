using Pathfinder2E.Main.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pathfinder2E.Main.Models.MicroModels;

namespace Pathfinder2E.Main.Models
{
    public class Model : ReactiveObject
    {
        [Reactive] public string Name { get; set; } = "Игорёчек";

        [Reactive] public int Level { get; set; } = 3;

        [Reactive] public HPData Hp { get; set; } = new HPData("Нр", 22, 22);

        [Reactive] public MicroModel Defence { get; set; } = new("КД", 10);
        public bool shildUp = false;

        // скилы
        [Reactive] public MicroModel Strengh { get; set; } = new MicroModel("Сила", 10);
        [Reactive] public MicroModel Dexterity { get; set; } = new MicroModel("Ловкость", 10);
        [Reactive] public MicroModel Constitution { get; set; } = new MicroModel("Телосложение", 10);
        [Reactive] public MicroModel Intelegence { get; set; }
        [Reactive] public MicroModel Wisdom { get; set; } = new MicroModel("Мудрость", 10);
        [Reactive] public MicroModel Charisma { get; set; } = new MicroModel("Харизма", 10);

        //спасброски
        [Reactive] public MicroModel Fortitude { get; set; } = new("Стойкость", 10);
        [Reactive] public MicroModel Reflex { get; set; } = new("Рефлексы", 10);
        [Reactive] public MicroModel Will { get; set; } = new("Воля", 10);

        //навыки
        [Reactive] public SkillBlock Arcana { get; set; }
        public Model()
        {
            Intelegence = new MicroModel("Интелект", 10);

            Arcana = new SkillBlock("Аркана", Intelegence.Value, 1, Level);
        }

        #region Вверх вниз скиллы
        public void IntUp() 
        {
            Intelegence.Value += 1;
            Arcana.Refresh(Intelegence.Value, 1, Level);
        }
        public void IntDown()
        {
            Intelegence.Value -= 1;
            Arcana.Refresh(Intelegence.Value, 1, Level);
        }
        #endregion

    }
}
