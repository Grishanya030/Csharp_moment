using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Components
{
    public class BlockClass: ReactiveObject
    {
        public BlockClass(string typeName, int value) {
            Type = typeName;
            Value = value;
        }
                
        public string Type { get; set; } = "";
        [Reactive] public int Value { get; set; }

        public string PlusValue
        {
            get => "+" + Value;
            set => PlusValue = value;
        }
    }

    public class HpBlockClass
    {
        public HpBlockClass(string typeName, int curHp, int maxHp)
        {
            Type = typeName;
            CurrHp = curHp;
            MaxHp = maxHp;
        }

        public string Type { get; set; } = "";
        public int CurrHp { get; set; }

        public int MaxHp{ get; set; }
        //public string MaxHp
        //{
        //    get => "/" + MaxHpValue;
        //    set => MaxHp = value;
        //}
    }
}
