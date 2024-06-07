using ReactiveUI.Fody.Helpers;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Models
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
            Value = _Value;
            if (Value - 10 < 0) SkillVal = (((Value - 11) / 2)).ToString();
            else SkillVal = "+" + ((Value - 10) / 2).ToString();
        }
    }
}
