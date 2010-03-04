using CalculatorUIModel;
using MbUnit.Framework;
using SG.Common.Test;
using TDD_Example.Calculator;
using TestHelper;

namespace CalculatorUIModelTests
{

    public class CalculatorModel__When_clearing_the_calculator
        : Calculator_Model_Concern
    {
        protected override void Because()
        {
            _calculatorModel.CurrentTotal = 1m;
            _calculatorModel.Clear();
        }

        [Test]
        public void should_have_a_new_current_total_of_0()
        {
            _calculatorModel.CurrentTotal.ShouldEqual(0m);
        }
    }

    public class CalculatorModel__When_calculating_1_added_to_2
        : Calculator_Model_Concern
    {
        protected override void Because()
        {
            _calculatorModel.CurrentTotal = 1m;
            _calculatorModel.Equate(2m);
        }

        [Test]
        public void should_have_a_new_current_total_of_3()
        {
            _calculatorModel.CurrentTotal.ShouldEqual(3m);
        }

        [Test]
        public void should_have_a_current_calculation_type_of_add()
        {
            _calculatorModel.CurrentCalculationType.ShouldEqual(CalculationType.Add);
        }
    }

    public class CalculatorModel__When_creating_a_calculator_model
        : Calculator_Model_Concern
    {
        [Test]
        public void should_have_an_current_total_value_of_0()
        {
            _calculatorModel.CurrentTotal.ShouldEqual(0m);
        }
    }

    public abstract class Calculator_Model_Concern : ConcernBase
    {
        protected ICalculatorModel _calculatorModel;

        protected override void Context()
        {
            _calculatorModel = new CalculatorModel();
        }
    }
}
