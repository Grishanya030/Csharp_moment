using Newtonsoft.Json;
using Pathfinder2E.Main.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Services
{
    internal class JSON_Converter
    {
        public void ModelToJSON(string filepath, Model Model)
        {
            string json=JsonConvert.SerializeObject(Model);
            File.WriteAllText(filepath, json);
        }
        public Model JSONToModel(string filepath)
        {
            string json= File.ReadAllText(filepath);
            Model model = JsonConvert.DeserializeObject<Model>(json);
            return model;
        }

    }
}
