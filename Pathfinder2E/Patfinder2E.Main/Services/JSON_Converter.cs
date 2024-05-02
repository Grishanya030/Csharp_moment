
using Pathfinder2E.Main.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pathfinder2E.Main.Services
{
    internal class JSON_Converter
    {
        
       
        public static void ModelToJSON(string filepath, Model Model)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields=true
        };
            string json=JsonSerializer.Serialize(Model, options: serializeOptions);
            File.WriteAllText(filepath, json);
        }
        public static Model JSONToModel(string filepath)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json= File.ReadAllText(filepath);
            
            Model model = JsonSerializer.Deserialize<Model>(json, options: serializeOptions);
            return model;
        }

    }
}
