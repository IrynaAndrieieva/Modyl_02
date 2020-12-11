namespace Modyl_02
{
    using System;

    public class Starter
    {
        // Attention! I use Latin names to avoid confusion
        private readonly IFencingServis fencingServis;

        public Starter()
        {
            this.fencingServis = new FencingServis();
        }

        public void Run()
        {
            Console.WriteLine("\nFencing 1:");

            var fencing = this.fencingServis.MakeMedicinPlant();
            Array.Sort(fencing.Magnoliophyta, new MagnoliophytaComparer());

            for (int i = 0; i < fencing.Magnoliophyta.Length; i++)
            {
                Console.WriteLine($"\nName: {fencing.Magnoliophyta[i].Name} \nDomain: {fencing.Magnoliophyta[i].Domain}");
                Console.WriteLine($"NameKingdom: {fencing.Magnoliophyta[i].NameKingdom} || Medicinal: {fencing.Magnoliophyta[i].Medicinal}");
                Console.WriteLine($"Familia: {fencing.Magnoliophyta[i].TypeOfFamilia}");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("\nFencing 2:");

            var fencingNonMed = this.fencingServis.MakeDecorationPlant();
            Array.Sort(fencingNonMed.Magnoliophyta, new MagnoliophytaComparer());

            for (int i = 0; i < fencingNonMed.Magnoliophyta.Length; i++)
            {
                Console.WriteLine($"\nName: {fencingNonMed.Magnoliophyta[i].Name} \nDomain: {fencingNonMed.Magnoliophyta[i].Domain}");
                Console.WriteLine($"NameKingdom: {fencingNonMed.Magnoliophyta[i].NameKingdom} || Medicinal: {fencingNonMed.Magnoliophyta[i].Medicinal}");
                Console.WriteLine($"Familia: {fencingNonMed.Magnoliophyta[i].TypeOfFamilia}");
            }
        }
    }
}
