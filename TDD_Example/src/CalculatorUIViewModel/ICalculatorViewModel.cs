using System.Windows.Input;
using SG.Common.Wpf.Mvvm;

namespace CalculatorUIViewModel
{
    public interface ICalculatorViewModel : IViewModelBase
    {
        ICommand AddCommand { get; }
        ICommand SubtractCommand { get; }
        ICommand ClearCommand { get; }
        ICommand EquateCommand { get; }
        string EnteredValue { get; set; }
        string CurrentTotal { get; }
    }
}