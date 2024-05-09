using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.DTO
{
    public class ModelDTO
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Defence { get; set; }
        public bool shieldUp { get; set; }
        public int Intel {  get; set; }

        public int Dex { get; set; }
        public int Con {  get; set; }
        public int Str { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int For { get; set; }
        public int Ref { get; set; }
        public int Wil { get; set; }

        public int Hp_Value { get; set; }
        public int Hp_MaxValue { get; set; }
    }
}
