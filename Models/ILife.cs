using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    public interface ILife
    {
        string Domain { get; }

        string Name { get; }

        string Medicinal { get; }

        TimeSpan LifeTime { get; }

        string Zone { get; }

    }
}
