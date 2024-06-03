using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pathfinder2E.DTOSave.DTO;

namespace Pathfinder2E.DTOSave.Services
{
    public class JSONConverter
    {
        public static void DTOToJSON(ModelDTO DTO, string filepath)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json = JsonSerializer.Serialize(DTO, options: serializeOptions);
            File.WriteAllText(filepath, json);
        }
        public static ModelDTO JSONToDTO(string filepath)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json = File.ReadAllText(filepath);

            ModelDTO DTO = JsonSerializer.Deserialize<ModelDTO>(json, options: serializeOptions);
            return DTO;
        }
    }
}
