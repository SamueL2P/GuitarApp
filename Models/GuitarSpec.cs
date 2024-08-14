using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Types;

namespace GuitarApp.NewFolder
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public GType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings { get; set; }


        public GuitarSpec(Builder builder, string model, GType type, Wood backWood, Wood topWood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder || Model != otherSpec.Model || Type != otherSpec.Type ||
                BackWood != otherSpec.BackWood || TopWood != otherSpec.TopWood || NumStrings != otherSpec.NumStrings)
            {
                return false;
            }
            return true;
        }
    }
}
