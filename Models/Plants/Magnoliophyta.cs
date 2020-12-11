namespace Modyl_02
{
    public abstract class Magnoliophyta : Kingdom //Отдел Цветковые
    {
        protected Magnoliophyta(string medicinal, string zone)
            : base(medicinal, zone)
        {
        }

        public abstract TypeOfFamilia TypeOfFamilia { get; }

        //public abstract Ingredient[] HerbalPreparation { get; }
    }
}
