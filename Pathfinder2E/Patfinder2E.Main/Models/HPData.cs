using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Models
{
    public class HPData : MicroModel
    {
        public HPData(string Type, int Value, int _MaxValue) : base(Type, Value)
        {
            MaxValue = _MaxValue;
        }

        [Reactive] public int MaxValue { get; set; }
    }
}
