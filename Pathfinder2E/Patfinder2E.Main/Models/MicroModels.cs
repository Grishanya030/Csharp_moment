using Pathfinder2E.Shell.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pathfinder2E.Shell.Models
{
    public class MicroModels
    {
        public class MicroModel : ReactiveObject
        {
            public MicroModel(string _Type, int _Value)
            {
                Refresh(_Value);
                Type = _Type;
            }

            [Reactive] public int Value { get; set; }
            [Reactive] public string SkillVal { get; set; } = "";
            public string Type { get; set; } = "";
            public void Refresh(int _Value)
            {
                Value= _Value;
                if (Value - 10 < 0) SkillVal = (((Value - 11) / 2)).ToString();
                else SkillVal = "+" + ((Value - 10) / 2).ToString();
            }
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
            [Reactive] public int Train { get; set; }
            public void Refresh(int Ability, int _Train, int Lvl)
            {
                Train = _Train;
                if (Ability - 10 < 0) Ability--;
                if (Train > 0) Value = + Lvl + (Train * 2)+((Ability - 10)/2);
                else Value = (Ability - 10) / 2;
                if (Value < 0) SkillVal = (Value).ToString();
                else SkillVal = "+" + Value.ToString();
            }
        }
    }
}
