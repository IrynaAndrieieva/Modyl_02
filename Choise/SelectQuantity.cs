using Modyl_02.Abstractions;
using Modyl_02.Helpers;
using Modyl_02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    public class SelectQuantity
    {
        private readonly ICollectionOfHerbsServis collectionOfHerbsServis;

        public SelectQuantity()
        {
            this.collectionOfHerbsServis = new CollectionOfHerbsServis();
        }
        public void Choise()
        {
        }
        public void ShowRecipe()
        {
            Console.WriteLine("-------------------");

            Console.WriteLine("Write number doses:");
            int doses = Convert.ToInt32(Console.ReadLine());

            var collectionOfHerbsServis = this.collectionOfHerbsServis.MakeSedativi();
            Array.Sort(collectionOfHerbsServis.Substances, new SubstancesComparer());

            for (int i = 0; i < collectionOfHerbsServis.Substances.Length; i++)
            {
                Console.WriteLine($"\nNumber Recipe: {collectionOfHerbsServis.Substances[i].NumberRecipe}");
                Console.WriteLine($"Name Drugs: {collectionOfHerbsServis.Substances[i].NameDrugs}");
                Console.WriteLine($"Recipe: {collectionOfHerbsServis.Substances[i].Compositionem}");
                Console.WriteLine($"Da tales doses № {doses} in {collectionOfHerbsServis.Substances[i].TypeOfSubstances}");
            }
        }

        public static void NonShowRecipe()
        {
            Console.WriteLine("It's good that everyone is healthy. Enjoy your garden!");
        }

        public void ChoiceCase(string choice)
        {
         
            switch (choice)
            {

                case "Y":
                    {
                        ShowRecipe();

                        break;
                    }
                case "N":
                    {
                        NonShowRecipe();

                        break;
                    }

            }


        }
    }
}
