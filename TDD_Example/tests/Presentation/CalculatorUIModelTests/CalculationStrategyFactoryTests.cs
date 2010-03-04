using CalculatorUIModel;
using MbUnit.Framework;
using SG.Common.Test;
using TestHelper;

namespace CalculatorUIModelTests
{
    public class CalculationStrategyFactory__When_building_the_calculation_strategies
        : ConcernBase
    {
        [Test]
        public void should_have_two_calculation_strategies_in_the_dictionary()
        {
            CalculationStrategyFactory.Create().Count.ShouldEqual(2);
        }
    }
}
