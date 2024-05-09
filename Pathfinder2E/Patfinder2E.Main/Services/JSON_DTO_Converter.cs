
using Pathfinder2E.Main.DTO;
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
    internal class JSON_DTO_Converter
    {
        public static void ModelToDTO(Model model, ModelDTO DTO)
        {
            DTO.Name=model.Name;
            DTO.Level=model.Level;
            DTO.HP=model.Hp.Value;
            DTO.MaxHP=model.Hp.MaxValue;
            DTO.Defence = model.Defence.Value;
            DTO.shieldUp=model.shildUp;
            DTO.Intel=model.Intelegence.Value;
            DTO.Dex=model.Dexterity.Value;
            DTO.Con=model.Constitution.Value;
            DTO.Str=model.Strengh.Value;
            DTO.Wis=model.Wisdom.Value;
            DTO.Cha=model.Charisma.Value;
            DTO.For=model.Fortitude.Value;
            DTO.Ref=model.Reflex.Value;
            DTO.Wil=model.Will.Value;

        }
        public static void DTOToModel (ModelDTO DTO,Model model) 
        {
            model.Name = DTO.Name;  
            model.Level = DTO.Level;
            model.Hp.Value = DTO.HP;
            model.Hp.MaxValue=DTO.MaxHP;
            model.Defence.Value=DTO.Defence;
            model.shildUp=DTO.shieldUp;
            model.Intelegence.Value = DTO.Intel;
            model.Dexterity.Value = DTO.Dex;
            model.Constitution.Value = DTO.Con;
            model.Strengh.Value = DTO.Str;
            model.Wisdom.Value = DTO.Wis;
            model.Charisma.Value = DTO.Cha;
            model.Fortitude.Value = DTO.For;
            model.Reflex.Value = DTO.Ref;
            model.Will.Value = DTO.Wil;
        }
        
       
        public static void DTOToJSON(ModelDTO DTO,string filepath)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields=true
        };
            string json=JsonSerializer.Serialize(DTO, options: serializeOptions);
            File.WriteAllText(filepath, json);
        }
        public static ModelDTO JSONToDTO(string filepath)
        {
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json= File.ReadAllText(filepath);
            
            ModelDTO DTO = JsonSerializer.Deserialize<ModelDTO>(json, options: serializeOptions);
            return DTO;
        }
        public static void JSONToModel (string filepath,Model model) 
        {
            DTOToModel(JSONToDTO(filepath),model);
        }

        public static void ModelToJSON(Model model,string filepath)
        {
            ModelDTO DTO=new ModelDTO();
            ModelToDTO(model, DTO);
            DTOToJSON(DTO,filepath);
        }
    }
}
