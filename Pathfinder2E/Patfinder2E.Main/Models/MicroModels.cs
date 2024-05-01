using Pathfinder2E.Main.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pathfinder2E.Main.Models
{
    public class MicroModels
    {
        public class MicroModel : ReactiveObject
        {
            public MicroModel(string _Type, int _Value)
            {
                Value = _Value;
                Type = _Type;
            }

            [Reactive] public int Value { get; set; }
            public string Type { get; set; } = "";

        }
        public class HPData : MicroModel
        {
            public HPData(string Type, int Value, int _MaxValue) : base(Type, Value)
            {
                MaxValue = _MaxValue;
            }

            [Reactive] public int MaxValue { get; set; }
        }

        public class SkillBlock : MicroModel
        {
            public SkillBlock(string _Type, int skill, int _Train, int lvl, int _Value = 0) : base(_Type, _Value)
            {
                Refresh(skill, _Train, lvl);
            }

            [Reactive] public string SkillVal { get; set; } = "";
            
            public void Refresh(int Skill, int Train, int Lvl)
            {
                if (Train > 0) Value = Skill + Lvl + Train*3 - 10;
                else Value = Skill - 10;
                if (Value < 0) SkillVal = Value.ToString();
                else SkillVal = "+" + Value.ToString();
            }
        }
    }
}
