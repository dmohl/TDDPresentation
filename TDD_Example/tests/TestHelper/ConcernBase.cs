using CalculatorUIModel;
using CalculatorUIViewModel;
using MbUnit.Framework;
using SG.Common.Test;
using StructureMap;
using TDD_Example.Calculator;

namespace TestHelper
{
    public abstract class ConcernBase : Concern
    {
        [FixtureSetUp]
        public override void BaseFixtureSetUp()
        {
            ObjectFactory.Configure(x => 
                x.Scan(scanner =>
                        {
                            scanner.AssemblyContainingType<ICalculator>();
                            scanner.AssemblyContainingType<ICalculatorModel>();
                            scanner.AssemblyContainingType<ICalculatorViewModel>();
                            scanner.WithDefaultConventions();
                        }));

            base.BaseFixtureSetUp();
        }
    }
}
