using ReactiveUI.Fody.Helpers;
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
        public string Size { get; set; }
        public string Speed { get; set; }
        public int TempHp { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Defence { get; set; }
        public bool shieldUp { get; set; }
        public int Dying { get; set; }
        public int Wounded { get; set; }
        public string ShieldName { get; set; }
        public int ShieldHP { get; set; }
        public int ShieldMaxHP { get; set; }
        public int ShieldHardness { get; set; }
        public int ShieldBroken { get; set; }
        public int Intel {  get; set; }

        public int Dex { get; set; }
        public int Con {  get; set; }
        public int Str { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int For { get; set; }
        public int Ref { get; set; }
        public int Wil { get; set; }

        public string[] Languages = new string[20];
        public string[] Instruments = new string[20];
        public string[] Lores = new string[20];

        public string BIO { get; set; }
        public string Notes { get; set; }

    }
}
