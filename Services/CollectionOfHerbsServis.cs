namespace Modyl_02.Services
{
    using Modyl_02.Entities;
    using Modyl_02.Models;
    using Modyl_02.Abstractions;
    using Modyl_02.Models.Drugs;

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
