﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
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
