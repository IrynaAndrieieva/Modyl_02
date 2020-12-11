namespace Modyl_02
{
    using System;

    public interface ILife
    {
        string Domain { get; }

        string Name { get; }

        string Medicinal { get; }

        TimeSpan LifeTime { get; }

        string Zone { get; }
    }
}
