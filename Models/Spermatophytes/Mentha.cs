namespace Modyl_02
{
    using System;

    public class Mentha : Magnoliophyta
    {
        public Mentha(string medicinal, string zone)
           : base(medicinal, zone)
        {
        }

        public override string Domain => "Eukaryota";

        public override TypeOfFamilia TypeOfFamilia => TypeOfFamilia.Lamiaceae;

        public override string Name => "Mentha";

        public override TimeSpan LifeTime => TimeSpan.FromDays(365);

        public override string NameKingdom => "Plantae";
    }
}
