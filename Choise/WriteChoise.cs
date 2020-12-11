using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02
{
    public class WriteChoise
    {
        public void SelectChoise()
        {           
            Console.WriteLine("\nDid you want make recipe? Put Y - yes, put N - no");
            string choice = Console.ReadLine();

            SelectQuantity selectQuantity = new SelectQuantity();

            selectQuantity.ChoiceCase(choice);
        }
    }

}
