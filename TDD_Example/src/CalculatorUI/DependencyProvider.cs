using CalculatorUIModel;
using CalculatorUIViewModel;
using StructureMap;

namespace TDD_Example.Calculator
{
    public class DependencyProvider
    {
        public static void Initialize()
        {
            ObjectFactory.Configure(x => 
                x.Scan(scanner =>
                    {
                        scanner.TheCallingAssembly();
                        scanner.AssemblyContainingType<ICalculator>();
                        scanner.AssemblyContainingType<ICalculatorModel>();
                        scanner.AssemblyContainingType<ICalculatorViewModel>();
                        scanner.WithDefaultConventions();
                    }));
        }
    }
}
