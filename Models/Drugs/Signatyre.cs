using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02.Models.Drugs
{
    public abstract class Signatyre : IRecipe
    {
        private readonly int numberRecipe;
       
        protected Signatyre(int numberRecipe)
        {
            this.numberRecipe = numberRecipe;
        }

        public int NumberRecipe => this.numberRecipe;

        public abstract string NameDrugs { get; }

        public abstract string Compositionem { get; }

    }
}
