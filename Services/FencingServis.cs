using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Models.Spermatophytes;
using System.Threading.Tasks;

namespace Modyl_02
{
    class FencingServis : IFencingServis
    {
        public FencingServis()
        {
        }
        public Fencing MakeMedicinPlant()
        {
            var magnoliophyta = new Magnoliophyta[]
            {
                new Mentha("Yes", "Forest zone"),
                new ValerianaOfficinalis("Yes", "Forest zone"),
                new MenthaPiperita("Yes", "Forest-steppe zone"),
            };
           
            return new Fencing { Magnoliophyta = magnoliophyta };
        }

        public Fencing MakeNonMedicinPlant()
        {
            var magnoliophyta = new Magnoliophyta[]
            {
                new Petunia("No", "Equatorial and subequatorial"),
                new Sinningia("No", "Tropical and subtropical"),
            };

            return new Fencing { Magnoliophyta = magnoliophyta };
        }
    }
}
