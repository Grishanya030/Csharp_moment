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
            public MicroModel(string _Type, int _Value) { 
                Value = _Value;
                Type = _Type;
            }

            [Reactive] public int Value { get; set; }
            public string Type { get; set; } = "";

        }
        public class HPData : MicroModel
        {
            public HPData(string Type, int Value, int _MaxValue):base(Type, Value)
            {
                MaxValue = _MaxValue;
            }

            [Reactive] public int MaxValue { get; set; }
        }
    }
}
