﻿using System.Collections.Generic;
using Newtonsoft.Json;
using StarWars5e.Models.Monster;

namespace StarWars5e.Models.Species
{
    public class Species : BaseEntity
    {
        public string Name { get; set; }
        public string SkinColorOptions { get; set; }
        public string HairColorOptions { get; set; }
        public string EyeColorOptions { get; set; }
        public string Distinctions { get; set; }
        public string HeightAverage { get; set; }
        public string HeightRollMod { get; set; }
        public string WeightAverage { get; set; }
        public string WeightRollMod { get; set; }
        public string Homeworld { get; set; }
        public string FlavorText { get; set; }
        public string ColorScheme { get; set; }
        public string Manufacturer { get; set; }
        public string Language { get; set; }
        public List<Trait> Traits { get; set; }
        public string TraitJson {
            get => Traits == null ? "" : JsonConvert.SerializeObject(Traits);
            set => Traits = JsonConvert.DeserializeObject<List<Trait>>(value);
        }
    }
}