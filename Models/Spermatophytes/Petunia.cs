namespace Modyl_02
{
    using System;

    public class Petunia : Magnoliophyta
    {
        public Petunia(string medicinal, string zone)
           : base(medicinal, zone)
        {
        }
        public override string Domain => "Eukaryota";

        public override TypeOfFamilia TypeOfFamilia => TypeOfFamilia.Solanaceae;

        public override string Name => "Petunia";

        public override TimeSpan LifeTime => TimeSpan.FromDays(365);

        public override string NameKingdom => "Plantae";
    }
}
