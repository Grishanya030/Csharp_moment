using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Model
{
    class MicroModels
    {
        class MicroModel 
        {
            public MicroModel(int _Value, string _Type) { 
                Value = _Value;
                Type = _Type;
            }

            public int Value { get; set; }
            public string Type { get; set; } = "";

        }
        class HP : MicroModel
        {
            public HP(int Value, string Type, int MaxValue):base(Value,Type)
            {
                
            }

            public int MaxValue { get; set; }
            //HP(int _Value, string _Type, int _MaxValue)
            //{
            //    Value = _Value;
            //    Type = _Type;
            //    MaxValue = _MaxValue;
            //}
        }
    }
}
