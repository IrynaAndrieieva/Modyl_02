namespace Modyl_02.Models.Drugs
{
    using Modyl_02.Enums;
    public class Sedariston : Substances
    {
        public override int NumberRecipe => 1;

        public override string NameDrugs => "Sedariston";

        public override string Compositionem => "Menta, Valeriana Officinalic";

        public override TypeOfSubstances TypeOfSubstances => TypeOfSubstances.Lagena;
    }
}
