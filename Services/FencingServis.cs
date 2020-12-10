using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            };
           
            return new Fencing { Magnoliophyta = magnoliophyta };
        }

        public Fencing MakeNonMedicinPlant()
        {
            var magnoliophyta = new Magnoliophyta[]
            {
                new Petunia("No", "Equatorial and subequatorial"),
            };

            return new Fencing { Magnoliophyta = magnoliophyta };
        }
    }
}
