using Pathfinder2E.Main.Components;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pathfinder2E.Main.Models.MicroModels;

namespace Pathfinder2E.Main.Models
{
    public class Model: ReactiveObject
    {
        [Reactive] public int Level { get; set; } = 1;

        



    }
}
