using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02.Models.Spermatophytes
{  
    public class Sinningia : Magnoliophyta
    {
        public Sinningia(string medicinal, string zone)
           : base(medicinal, zone)
        {

        }
        public override string Domain => "Eukaryota";

        public override TypeOfFamilia TypeOfFamilia => TypeOfFamilia.Gesneriaceae;

        public override string Name => "Sinningia";

        public override TimeSpan LifeTime => TimeSpan.FromDays(365);

        public override string NameKingdom => "Plantae";
    }
}
