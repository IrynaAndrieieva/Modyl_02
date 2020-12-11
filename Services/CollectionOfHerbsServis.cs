using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Entities;
using Modyl_02.Models;
using Modyl_02.Abstractions;
using System.Threading.Tasks;
using Modyl_02.Models.Drugs;

namespace Modyl_02.Services
{
    public class CollectionOfHerbsServis : ICollectionOfHerbsServis
    {
        public CollectionOfHerbsServis()
        {
        }

        public CollectionOfHerbs MakeSedativi()
        {
            var substances = new Substances[]
            {
                new Sedariston(),

            }; 

            return new CollectionOfHerbs { Substances = substances };
        }
    }
}
