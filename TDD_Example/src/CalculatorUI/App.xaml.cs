using System.Windows;
using CalculatorUIViewModel;
using StructureMap;
using TDD_Example.Calculator;

namespace CalculatorUI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DependencyProvider.Initialize();

            var view = new MainWindow
                           {
                               DataContext = ObjectFactory.GetInstance<ICalculatorViewModel>()
                           };
            view.Show();
        }
    }
}
