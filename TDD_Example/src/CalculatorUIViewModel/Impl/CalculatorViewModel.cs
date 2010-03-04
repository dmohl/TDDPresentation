using System;
using System.Windows.Input;
using CalculatorUIModel;
using SG.Common.Commands;
using SG.Common.Wpf.Mvvm;
using TDD_Example.Calculator;

namespace CalculatorUIViewModel
{
    public class CalculatorViewModel : ViewModelBase, ICalculatorViewModel
    {
        private readonly ICalculatorModel _calculatorModel;
        private string _enteredValue;

        public CalculatorViewModel(ICalculatorModel calculatorModel)
        {
            _calculatorModel = calculatorModel;
        }

        public ICommand AddCommand
        {
            get
            {
                return new RelayCommand(x => CalculateAdd());
            }
        }

        public ICommand SubtractCommand
        {
            get
            {
                return new RelayCommand(x => CalculateSubtract());
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                return new RelayCommand(x => ClearCalculator());
            }
        }

        public ICommand EquateCommand
        {
            get
            {
                return new RelayCommand(x => CalculateEquate());
            }
        }

        public string EnteredValue
        {
            get
            {
                if (string.IsNullOrEmpty(_enteredValue))
                {
                    _enteredValue = "0";
                }
                return _enteredValue;
            }
            set
            {
                _enteredValue = value;
                OnPropertyChanged("EnteredValue");
            }
        }

        public string CurrentTotal
        {
            get { return string.Format("{0}", _calculatorModel.CurrentTotal); }
        }

        protected void CalculateAdd()
        {
            _calculatorModel.CurrentCalculationType = CalculationType.Add;
            CalculateAndClear();
        }

        protected void CalculateSubtract()
        {
            _calculatorModel.CurrentCalculationType = CalculationType.Subtract;
            CalculateAndClear();
        }

        protected void CalculateAndClear()
        {
            CalculateEquate();
            EnteredValue = "0";
        }

        protected void CalculateEquate()
        {
            decimal currentValue;
            decimal.TryParse(EnteredValue, out currentValue);
            _calculatorModel.Equate(currentValue);
            OnPropertyChanged("CurrentTotal");
        }

        protected void ClearCalculator()
        {
            EnteredValue = "0";
            _calculatorModel.Clear();
            OnPropertyChanged("EnteredValue");
            OnPropertyChanged("CurrentTotal");
        }
    }
}