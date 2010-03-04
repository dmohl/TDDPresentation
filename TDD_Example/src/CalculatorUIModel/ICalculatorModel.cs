using System.Collections.Generic;
using TDD_Example.Calculator;

namespace CalculatorUIModel
{
    public interface ICalculatorModel
    {
        decimal CurrentTotal { get; set; }
        CalculationType CurrentCalculationType { get; set; }
        decimal Equate(decimal value2);
        decimal Clear();
    }
}