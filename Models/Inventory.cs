using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Types;

namespace GuitarApp.NewFolder
{
    internal class Inventory
    {
        public List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNumber, double price,Builder builder, string model, GType type, Wood backWood, Wood topWood, int numStrings)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood, numStrings);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (var guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
