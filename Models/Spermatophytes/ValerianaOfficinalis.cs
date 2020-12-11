namespace Modyl_02
{
    using System;

    public class ValerianaOfficinalis : Magnoliophyta
    {
        public ValerianaOfficinalis(string medicinal, string zone)
           : base(medicinal, zone)
        {
        }
        public override string Domain => "Eukaryota";

        public override TypeOfFamilia TypeOfFamilia => TypeOfFamilia.Caprifoliaceae;

        public override string Name => "Valeriana Officinalis";

        public override TimeSpan LifeTime => TimeSpan.FromDays(365);

        public override string NameKingdom => "Plantae";
    }
}
