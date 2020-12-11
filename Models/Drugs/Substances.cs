namespace Modyl_02.Models
{
    using Modyl_02.Enums;
    using Modyl_02.Models.Drugs;

    public abstract class Substances : Signatyre
    {     
        public abstract TypeOfSubstances TypeOfSubstances { get; }
    }
}
