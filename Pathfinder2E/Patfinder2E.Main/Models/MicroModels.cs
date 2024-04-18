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
        public class MicroModel: ReactiveObject
        {
            public MicroModel(int _Value, string _Type) { 
                Value = _Value;
                Type = _Type;
            }

            [Reactive] public int Value { get; set; }
            public string Type { get; set; } = "";

        }
        public class HPData : MicroModel
        {
            public HPData(int Value, string Type, int _MaxValue):base(Value,Type)
            {
                MaxValue = _MaxValue;
            }

            public int MaxValue { get; set; }
        }
    }
}
