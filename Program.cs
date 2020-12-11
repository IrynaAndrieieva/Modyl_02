using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Attention! I use Latin names to avoid confusion
            Greeting great = new Greeting();
            great.Hello();

            Starter start = new Starter();
            start.Run();            

            WriteChoise writeChoise = new WriteChoise();
            writeChoise.SelectChoise();

            Console.ReadKey();
        }
    }
}
