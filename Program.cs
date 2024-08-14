using GuitarApp.NewFolder;
using GuitarApp.Types;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();
            inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            inventory.AddGuitar("V9512", 1549.95, Builder.FENDER, "Stratocastor", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            inventory.AddGuitar("11277", 3999.95, Builder.COLLINGS, "CJ", GType.ACOUSTIC, Wood.INDIANROSEWOOD, Wood.SITKA, 12);


            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);

            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("You might like these guitars:");
                foreach (var guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.Spec;
                    Console.WriteLine($"We have a {spec.Builder} {spec.Model} {spec.Type} guitar:\n" +
                                      $"{spec.BackWood} back and sides,\n" +
                                      $"{spec.TopWood} top.\n" +
                                      $"You can have it for only ${guitar.Price}!\n" +
                                      $"--------------");
                }
            }
            else
            {
                Console.WriteLine("Sorry, we have nothing for you.");
            }
        }
    }
}
