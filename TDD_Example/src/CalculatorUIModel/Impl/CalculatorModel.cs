using TDD_Example.Calculator;

namespace CalculatorUIModel
{
    public class CalculatorModel : ICalculatorModel
    {
        private ICalculator _calculator;
        private CalculationType _currentCalculationType;

        public CalculatorModel()
        {
            _currentCalculationType = CalculationType.Add;
        }

        public ICalculator Calculator
        {
            get
            {
                if (_calculator == null)
                {
                    _calculator = new Calculator(CalculationStrategyFactory.Create());
                }
                return _calculator;
            }
        }

        public decimal CurrentTotal { get; set; }
        public CalculationType CurrentCalculationType
        {
            get
            {
                return _currentCalculationType;
            }
            set
            {
                _currentCalculationType = value;
            }
        }

        public decimal Equate(decimal value2)
        {
            var result =
                Calculator.Calculate(CurrentCalculationType, 
                CurrentTotal, value2);
            CurrentTotal = result;
            return result;
        }

        public decimal Clear()
        {
            const decimal result = 0m;
            CurrentTotal = result;
            CurrentCalculationType = CalculationType.Add;
            return result;
        }
    }
}