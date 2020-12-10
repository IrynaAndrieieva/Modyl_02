using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Enums;
using System.Threading.Tasks;

namespace Modyl_02.Models
{ 
    public abstract class Substances : IRecipe
    {        
        private readonly int numberRecipe;
        private readonly string nameDrugs;
        private readonly string compositionem;

        protected Substances(int numberRecipe)
        {
            this.numberRecipe = numberRecipe;          
        }

        public int NumberRecipe => this.numberRecipe;

        public abstract string NameDrugs { get; }

        public abstract string Compositionem { get; }

        public abstract TypeOfFamilia TypeOfFamilia { get; }

        public abstract TypeOfSubstances TypeOfSubstances { get; }


    }
}
