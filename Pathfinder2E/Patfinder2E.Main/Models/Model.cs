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
using System.Windows;
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


        [Reactive] public int TempHp { get; set; }
        [Reactive] public HPData Hp { get; set; }
        [Reactive] public MicroModel Defence { get; set; }
        public bool shildUp;

        [Reactive] public int Diying { get; set; }
        [Reactive] public int Wunded { get; set; }

        //щит

        [Reactive] public string ShieldName { get; set; }
        [Reactive] public HPData ShieldHp { get; set; }
        [Reactive] public MicroModel ShieldHardnes { get; set; }
        [Reactive] public MicroModel ShieldBroken { get; set; }

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
        [Reactive] public SkillBlock Perception { get; set; }
        public Model()
        {
            Name = "Игорёчек";
            Level = 3;

            Hp = new HPData("Нр", 22, 22);
            TempHp = 0;

            Defence = new("КД", 10);
            shildUp = false;

            Speed = "25";
            Size = "Средний";

            Diying = 0;
            Wunded = 0;

            //щит
            ShieldName = "Cтандартный щит";
            ShieldHp = new HPData(ShieldName, 55, 60);
            ShieldHardnes = new MicroModel("Твердость", 11);
            ShieldBroken = new MicroModel("Сломан", 48);
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
            Thievery = new SkillBlock("Воровство", Dexterity.Value, 1, Level);
            Perception = new SkillBlock("Внимание", Wisdom.Value, 1, Level);
            Lores.Add(new SkillBlock("Знания: проба", Intelegence.Value, 1, Level));

            Intelegence.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                foreach (SkillBlock lor in Lores) lor.Refresh(Intelegence.Value, 1, Level);
                Arcana.Refresh(Intelegence.Value, 1, Level);
                Crafting.Refresh(Intelegence.Value, 1, Level);
                Occultism.Refresh(Intelegence.Value, 1, Level);
                Society.Refresh(Intelegence.Value, 1, Level);

            });
            Strengh.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Athletics.Refresh(Strengh.Value, 1, Level);
            });
            Dexterity.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Acrobatics.Refresh(Dexterity.Value, 1, Level);
                Reflex.Refresh(Dexterity.Value);
                Stealth.Refresh(Dexterity.Value, 1, Level);
                Thievery.Refresh(Dexterity.Value, 1, Level);
            });
            Constitution.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Fortitude.Refresh(Constitution.Value);
            });
            Wisdom.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Will.Refresh(Wisdom.Value);
                Medicine.Refresh(Wisdom.Value, 1, Level);
                Nature.Refresh(Wisdom.Value, 1, Level);
                Religion.Refresh(Wisdom.Value, 1, Level);
                Survival.Refresh(Wisdom.Value, 1, Level);
                Perception.Refresh(Wisdom.Value, 1, Level);
            });
            Charisma.WhenPropertyChanged(x => x.Value).Subscribe(x =>
            {
                Deception.Refresh(Charisma.Value, 1, Level);
                Diplomacy.Refresh(Charisma.Value, 1, Level);
                Intimidation.Refresh(Charisma.Value, 1, Level);
                Perfomance.Refresh(Charisma.Value, 1, Level);
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

        }
        public void DexDown()
        {
            Dexterity.Value -= 1;
        }
        public void ConUp()
        {
            Constitution.Value += 1;

        }
        public void ConDown()
        {
            Constitution.Value -= 1;
        }
        public void IntUp() 
        {
            Intelegence.Value += 1;
           
           
        }
        public void IntDown()
        {
            Intelegence.Value -= 1;
            
        }
        public void WisUp()
        {
            Wisdom.Value += 1;

        }
        public void WisDown()
        {
            Wisdom.Value -= 1;
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
