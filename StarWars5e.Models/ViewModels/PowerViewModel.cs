﻿using System.Collections.Generic;
using Newtonsoft.Json;
using StarWars5e.Models.Enums;

namespace StarWars5e.Models.ViewModels
{

    /// <summary>
    /// Viewmodel representing a power (be it force or tech based)
    /// </summary>
    public class PowerViewModel
    {
        /// <summary>
        /// Default ctor for serialization
        /// </summary>
        public PowerViewModel()
        {
            
        }

        /// <summary>
        ///  The name of the power
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  The type of the power (should only be force or tech)
        /// </summary>
        [JsonProperty("powerType")]
        public string PowerType { get; set; }


        /// <summary>
        ///  The description of the power
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }


        /// <summary>
        ///  The level of the power (-1 represents an at-will power)
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        ///  A string of the prerequisities for the power
        /// </summary>
        [JsonProperty("prerequisite")]
        public string Prerequisite { get; set; }

        /// <summary>
        ///  The requirements to cast this power (generally only one, but there might be multiple)
        /// </summary>
        [JsonProperty("castingLength")]
        public IEnumerable<CastingLength> CastingLength { get; set; } = new List<CastingLength>();

        /// <summary>
        ///  What limits are placed on reactions that this power can react to
        /// </summary>
        [JsonProperty("reactionLimit")]
        public string ReactionLimit { get; set; }

        /// <summary>
        /// The number of units of range that this power takes
        /// </summary>
        [JsonProperty("range")]
        public int Range { get; set; }

        /// <summary>
        /// Describes the type of range for this power
        /// </summary>
        public RangeType RangeType { get; set; }

        /// <summary>
        /// Describes the shape of this power
        /// </summary>
        public Shape PowerShape { get; set; }

        /// <summary>
        ///  The size of the shape generated by this power
        /// </summary>
        [JsonProperty("shapeSize")]
        public int ShapeSize { get; set; }

        /// <summary>
        ///  The type of measurement that the shape size is measured in
        /// </summary>
        [JsonProperty("shapeSizeType")]
        public string ShapeSizeType { get; set; }


        /// <summary>
        ///  Indicates if this power requires concentration to maintain
        /// </summary>
        [JsonProperty("requiresConcentration")]
        public bool RequiresConcentration { get; set; }

        /// <summary>
        ///  Length of the duration of this power
        /// </summary>
        [JsonProperty("durationLength")]
        public int DurationLength { get; set; }

        /// <summary>
        ///  Does the modifier last minutes or hours etc
        /// </summary>
        [JsonProperty("durationLengthModifier")]
        public Duration DurationLengthModifier { get; set; }

        /// <summary>
        ///  What happens when this power is overloaded with force (or tech) potency
        /// </summary>
        [JsonProperty("potencyPower")]
        public string PotencyPower { get; set; }

        /// <summary>
        ///  How does this power align with the force (all tech powers will be unaligned)
        /// </summary>
        [JsonProperty("powerAlignment")]
        public ForceAlignment PowerAlignment { get; set; }

        /// <summary>
        ///  List of generated tags for this power. These are not found in the source documentation and will be used for filtering
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }


    }

    /// <summary>
    /// Describes what is required to invoke the poewr
    /// </summary>
    public class CastingLength
    {
        /// <summary>
        ///  The type of time period that is required to cast the power
        /// </summary>
        [JsonProperty("castingPeriod")]
        public CastingPeriod CastingPeriod { get; set; }

        /// <summary>
        ///  The number of periods that is required to cast the power
        /// </summary>
        [JsonProperty("castingTime")]
        public int CastingTime { get; set; }
    }
}