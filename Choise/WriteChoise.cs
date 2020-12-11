namespace Modyl_02
{
    using System;

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
