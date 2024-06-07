using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Models
{
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
            if (Train > 0) Value = +Lvl + (Train * 2) + ((Ability - 10) / 2);
            else Value = (Ability - 10) / 2;
            if (Value < 0) SkillVal = (Value).ToString();
            else SkillVal = "+" + Value.ToString();
        }
    }
}
