using System.Collections.Generic;
using StructureMap;
using TDD_Example.Calculator;

namespace CalculatorUIModel
{
    public class CalculationStrategyFactory
    {
        protected static IDictionary<CalculationType, ICalculationStrategy> _calculationStrategies;

        public static IDictionary<CalculationType, ICalculationStrategy> Create()
        {
            if (_calculationStrategies == null)
            {
                _calculationStrategies =
                    new Dictionary<CalculationType, ICalculationStrategy>();
                _calculationStrategies.Add(CalculationType.Add,
                    ObjectFactory.GetInstance<IAddStrategy>());
                _calculationStrategies.Add(CalculationType.Subtract,
                    ObjectFactory.GetInstance<ISubtractStrategy>());
            }

            return _calculationStrategies;
        }
    }
}
