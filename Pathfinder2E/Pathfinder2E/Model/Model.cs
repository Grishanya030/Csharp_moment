using Pathfinder2E.Components;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pathfinder2E.Model.MicroModels;

namespace Pathfinder2E.Model
{
    class Model
    {
        [Reactive] public int Level { get; set; } = 121;
        [Reactive] public HpBlockClass Hp { get; set; } = new("Нр", 22, 22);

        public HPData hp = new HPData(22, "Нр", 22);



    }
}
