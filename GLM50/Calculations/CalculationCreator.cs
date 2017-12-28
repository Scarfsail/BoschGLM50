using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLM50.Calculations
{
    class CalculationCreator<TCalculation> : ICalculationCreator
        where TCalculation : ICalculationDialog, new()
    {
        public CalculationCreator(string title)
        {
            this.Title = title;
        }


        public string Title { get; }

        public TCalculation CreateInstance()
        {
            return new TCalculation();
        }

        public override string ToString() => this.Title;

        ICalculationDialog ICalculationCreator.CreateInstance() => this.CreateInstance();
    }
}
