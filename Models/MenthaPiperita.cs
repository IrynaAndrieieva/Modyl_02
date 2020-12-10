using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    public class MenthaPiperita : Magnoliophyta
    {
        protected MenthaPiperita(string medicinal, string zone)
           : base(medicinal, zone)
        {

        }
        public override string Domain => "Eukaryota";

        public override TypeOfFamilia TypeOfFamilia => TypeOfFamilia.Lamiaceae;

        public override string Name => "MenthaPiperita";

        public override TimeSpan LifeTime => TimeSpan.FromDays(365);

        public override string NameKingdom => "Plantae";
    }
}
