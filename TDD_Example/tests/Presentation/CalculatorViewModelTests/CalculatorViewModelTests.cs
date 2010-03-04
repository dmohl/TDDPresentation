using System.Windows.Input;
using CalculatorUIModel;
using CalculatorUIViewModel;
using MbUnit.Framework;
using SG.Common.Test;
using TestHelper;
using StructureMap;

namespace CalculatorViewModelTests
{
    public class CalculatorViewModel__When_firing_the_clear_command
        : CalculatorViewModelBase
    {
        protected override void Because()
        {
            base.Because();
            _viewModel.EnteredValue = "1";
            _viewModel.ClearCommand.Execute(null);
        }

        [Test]
        public void should_have_a_current_total_of_0()
        {
            _viewModel.CurrentTotal.ShouldEqual("0");
        }

        [Test]
        public void should_have_an_entered_value_of_0()
        {
            _viewModel.EnteredValue.ShouldEqual("0");
        }
    }

    public class CalculatorViewModel__When_firing_the_equate_command
        : CalculatorViewModelBase
    {
        protected override void Because()
        {
            base.Because();
            _viewModel.EnteredValue = "1";
            _viewModel.EquateCommand.Execute(null);
        }

        [Test]
        public void should_have_a_current_total_of_1()
        {
            _viewModel.CurrentTotal.ShouldEqual("1");
        }

        [Test]
        public void should_have_an_entered_value_of_1()
        {
            _viewModel.EnteredValue.ShouldEqual("1");
        }
    }

    public class CalculatorViewModel__When_firing_the_subtract_command
        : CalculatorViewModelBase
    {
        protected override void Because()
        {
            base.Because();
            _viewModel.EnteredValue = "1";
            _viewModel.SubtractCommand.Execute(null);
        }

        [Test]
        public void should_have_a_current_total_of_negative1()
        {
            _viewModel.CurrentTotal.ShouldEqual("-1");
        }

        [Test]
        public void should_have_an_entered_value_of_0()
        {
            _viewModel.EnteredValue.ShouldEqual("0");
        }
    }

    public class CalculatorViewModel__When_firing_the_add_command
        : CalculatorViewModelBase
    {
        protected override void Because()
        {
            base.Because();
            _viewModel.EnteredValue = "1";
            _viewModel.AddCommand.Execute(null);
        }

        [Test]
        public void should_have_a_current_total_of_1()
        {
            _viewModel.CurrentTotal.ShouldEqual("1");
        }

        [Test]
        public void should_have_an_entered_value_of_0()
        {
            _viewModel.EnteredValue.ShouldEqual("0");
        }
    }

    public class CalculatorViewModel__When_adding_two_numbers
        : CalculatorViewModelBase
    {
        protected override void Because()
        {
            base.Because();
            _viewModel.EnteredValue = "1";
            _viewModel.AddCommand.Execute(null);
            _viewModel.EnteredValue = "1";
            _viewModel.AddCommand.Execute(null);
        }

        [Test]
        public void should_have_a_current_total_of_2()
        {
            _viewModel.CurrentTotal.ShouldEqual("2");
        }

        [Test]
        public void should_have_an_entered_value_of_0()
        {
            _viewModel.EnteredValue.ShouldEqual("0");
        }
    }

    public class CalculatorViewModel__When_creating_a_calculator_view_model
        : CalculatorViewModelBase
    {
        [Test]
        public void should_have_an_AddCommand_of_type_ICommand()
        {
            _viewModel.AddCommand.ShouldBeOfType(typeof (ICommand));
        }

        [Test]
        public void should_have_a_SubtractCommand_of_type_ICommand()
        {
            _viewModel.SubtractCommand.ShouldBeOfType(typeof(ICommand));
        }

        [Test]
        public void should_have_a_ClearCommand_of_type_ICommand()
        {
            _viewModel.ClearCommand.ShouldBeOfType(typeof(ICommand));
        }

        [Test]
        public void should_have_an_EquateCommand_of_type_ICommand()
        {
            _viewModel.EquateCommand.ShouldBeOfType(typeof(ICommand));
        }

        [Test]
        public void should_have_an_EnteredValue_of_0()
        {
            _viewModel.EnteredValue.ShouldEqual("0");
        }

        [Test]
        public void should_have_an_CurrentTotal_of_0()
        {
            _viewModel.CurrentTotal.ShouldEqual("0");
        }
    }

    public abstract class CalculatorViewModelBase : ConcernBase
    {
        protected ICalculatorViewModel _viewModel;
        protected ICalculatorModel _calculatorModel;

        protected override void Because()
        {
            _calculatorModel = ObjectFactory.GetInstance<ICalculatorModel>();
            _viewModel = new CalculatorViewModel(_calculatorModel);
            base.Because();
        }
    }
}
