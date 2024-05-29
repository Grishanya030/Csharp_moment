using DynamicData.Binding;
using Pathfinder2E.Main.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.Serialization;
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
        [Reactive] public SkillBlock Acrobatics { get; set; }
        [Reactive] public SkillBlock Arcana { get; set; }
        [Reactive] public SkillBlock Athletics { get; set; }
        [Reactive] public SkillBlock Crafting { get; set; }
        [Reactive] public SkillBlock Deception { get; set; }
        [Reactive] public SkillBlock Diplomacy { get; set; }
        [Reactive] public SkillBlock Intimidation { get; set; }
        [Reactive] public SkillBlock Medicine { get; set; }
        [Reactive] public SkillBlock Nature { get; set; }
        [Reactive] public SkillBlock Occultism { get; set; }
        [Reactive] public SkillBlock Perfomance { get; set; }
        [Reactive] public SkillBlock Religion { get; set; }
        [Reactive] public SkillBlock Society { get; set; }
        [Reactive] public SkillBlock Stealth { get; set; }
        [Reactive] public SkillBlock Survival { get; set; }
        [Reactive] public SkillBlock Thievery { get; set; }
        public Model()
        {
            Name = "Игорёчек";
            Level = 3;

            Hp = new HPData("Нр", 22, 22);

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
            Acrobatics = new SkillBlock("Акробатика", Dexterity.Value, 1, Level);
            Arcana = new SkillBlock("Аркана", Intelegence.Value, 1, Level);
            Athletics = new SkillBlock("Атлетика", Strengh.Value, 1, Level);
            Crafting = new SkillBlock("Ремесло", Intelegence.Value, 1, Level);
            Deception = new SkillBlock("Обман", Charisma.Value, 1, Level);
            Diplomacy = new SkillBlock("Дипломатия", Charisma.Value, 1, Level);
            Intimidation = new SkillBlock("Запугивание", Charisma.Value, 1, Level);
            Medicine = new SkillBlock("Медицина", Wisdom.Value, 1, Level);
            Nature = new SkillBlock("Природа", Wisdom.Value, 1, Level);
            Occultism = new SkillBlock("Оккультизм", Intelegence.Value, 1, Level);
            Perfomance = new SkillBlock("Исполнение", Charisma.Value, 1, Level);
            Religion = new SkillBlock("Религия", Wisdom.Value, 1, Level);
            Society = new SkillBlock("Общество", Intelegence.Value, 1, Level);
            Stealth = new SkillBlock("Скрытность", Dexterity.Value, 1, Level);
            Survival = new SkillBlock("Выживание", Wisdom.Value, 1, Level);
            Thievery = new SkillBlock("Воровство", Intelegence.Value, 1, Level);
            Lores.Add(new SkillBlock("Знания: проба", Intelegence.Value, 1, Level));

            Intelegence.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Arcana.Refresh(Intelegence.Value, 1, Level);
                foreach(SkillBlock lor in Lores)
                {
                    lor.Refresh(Intelegence.Value, 1, Level);
                }


            });
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
           
           
        }
        public void IntDown()
        {
            Intelegence.Value -= 1;
            Arcana.Refresh(Intelegence.Value, 1, Level);
            
        }
        public void WisUp()
        {
            Wisdom.Value += 1;
            Will.Value += 1;

        }
        public void WisDown()
        {
            Wisdom.Value -= 1;
            Will.Value -= 1;
        }
        public void ChaUp()
        {
            Charisma.Value += 1;

        }
        public void ChaDown()
        {
            Charisma.Value -= 1;

        }

            #endregion

        }
    }
