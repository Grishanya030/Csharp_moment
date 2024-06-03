
using DynamicData;
using Pathfinder2E.Main.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media;
using Pathfinder2E.DTOSave.Services;
using Pathfinder2E.DTOSave.DTO;

namespace Pathfinder2E.Main.Services
{
    internal class JSON_DTO_Converter
    {
        public static void ModelToDTO(Model model, ModelDTO DTO)
        {
            DTO.Name=model.Name;
            DTO.Level=model.Level;
            DTO.Size=model.Size;
            DTO.Speed=model.Speed;
            DTO.TempHp=model.TempHp;
            DTO.HP=model.Hp.Value;
            DTO.MaxHP=model.Hp.MaxValue;
            DTO.Defence = model.Defence.Value;
            DTO.shieldUp=model.shildUp;
            DTO.Dying=model.Dying;
            DTO.Wounded=model.Wounded;
            DTO.ShieldName=model.ShieldName;
            DTO.ShieldHP=model.ShieldHp.Value;
            DTO.ShieldMaxHP=model.ShieldHp.MaxValue;
            DTO.ShieldHardness=model.ShieldHardness.Value;
            DTO.ShieldBroken=model.ShieldBroken.Value;
            DTO.Intel=model.Intelegence.Value;
            DTO.Dex=model.Dexterity.Value;
            DTO.Con=model.Constitution.Value;
            DTO.Str=model.Strengh.Value;
            DTO.Wis=model.Wisdom.Value;
            DTO.Cha=model.Charisma.Value;
            DTO.For=model.Fortitude.Value;
            DTO.Ref=model.Reflex.Value;
            DTO.Wil=model.Will.Value;
            DTO.BIO = model.BIO;
            DTO.Notes = model.Notes;
            int i = 0;
            foreach (string value in model.Languages)
            {
                DTO.Languages[i]=value;
                i++;
            }
            i = 0;
            foreach (var value in model.Lores)
            {
                DTO.Lores[i] = value.Type;
                i++;
            }
            i = 0;
            foreach (string value in model.Instruments)
            {
                DTO.Instruments[i] = value;
                i++;
            }
        }
        public static void DTOToModel (ModelDTO DTO,Model model) 
        {
            model.Languages.Clear();
            model.Instruments.Clear();
            model.Name = DTO.Name;  
            model.Level = DTO.Level;
            model.Size = DTO.Size;
            model.Speed = DTO.Speed;
            model.TempHp = DTO.TempHp;
            model.Hp.Value = DTO.HP;
            model.Hp.MaxValue=DTO.MaxHP;
            model.Defence.Value=DTO.Defence;
            model.shildUp=DTO.shieldUp;
            model.Dying=DTO.Dying;
            model.Wounded=DTO.Wounded;
            model.ShieldName=DTO.ShieldName;
            model.ShieldHp.Value=DTO.ShieldHP;
            model.ShieldHp.MaxValue=DTO.ShieldMaxHP;
            model.ShieldHardness.Value = DTO.ShieldHardness;
            model.ShieldBroken.Value = DTO.ShieldBroken;
            model.Intelegence.Value = DTO.Intel;
            model.Dexterity.Value = DTO.Dex;
            model.Constitution.Value = DTO.Con;
            model.Strengh.Value = DTO.Str;
            model.Wisdom.Value = DTO.Wis;
            model.Charisma.Value = DTO.Cha;
            model.Fortitude.Value = DTO.For;
            model.Reflex.Value = DTO.Ref;
            model.Will.Value = DTO.Wil;
            model.BIO = DTO.BIO;
            model.Notes = DTO.Notes;
            model.Languages.Clear();
            model.Lores.Clear();
            model.Instruments.Clear();  

            if(DTO.Languages.Any())
                foreach (string value in DTO.Languages)
                {   if(value!=null)
                    model.Languages.Add(value);
                }
            if (DTO.Lores.Any())
                foreach (string value in DTO.Lores)
                {
                    if (value != null)
                        model.Lores.Add(new MicroModels.SkillBlock( value, DTO.Intel, 1, DTO.Level));
                }
            if (DTO.Instruments.Any())
                foreach (string value in DTO.Instruments)
                {
                    if (value != null)
                        model.Instruments.Add(value);
                }
        
        }
        
       
       
        public static void JSONToModel (string filepath,Model model) 
        {
            DTOToModel(JSONConverter.JSONToDTO(filepath),model);
        }

        public static void ModelToJSON(Model model,string filepath)
        {
            ModelDTO DTO=new ModelDTO();
            ModelToDTO(model, DTO);
            JSONConverter.DTOToJSON(DTO,filepath);
        }
    }
}
