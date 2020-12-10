using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    public abstract class Kingdom : ILife
    {
        private readonly string medicinal;
        private readonly string zone;
        private readonly DateTime createdTime = DateTime.UtcNow;

        protected Kingdom(string medicinal, string zone)
        {
            this.medicinal = medicinal;
            this.zone = zone;
        }

        public abstract string Domain { get; }

        public abstract string NameKingdom { get; }

        public abstract string Name { get; }

        public string Medicinal => this.medicinal;

        public abstract TimeSpan LifeTime { get; }

        public string Zone => this.zone;

    }
}
