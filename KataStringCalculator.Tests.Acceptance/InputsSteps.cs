using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using TechTalk.SpecFlow;

namespace KataStringCalculator.Tests.Acceptance
{
	[Binding]
	public class InputsSteps
	{
		// For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

		[Given(@"una stringa vuota")]
		public void DatoUnaStringaVuota()
		{
			ScenarioContext.Current.Add("stringa", string.Empty);
		}

		[When(@"eseguo il calcolo")]
		public void QuandoEseguoIlCalcolo()
		{
			var stringa = ScenarioContext.Current.Get<string>("stringa");
			var stringCalculator = new StringCalculator();
			var result = stringCalculator.Calculate(stringa);
			ScenarioContext.Current.Add("somma", result);
		}

		[Then(@"il risultato è:(.*)")]
		public void AlloraIlRisultatoE(int p0)
		{
			var result = ScenarioContext.Current.Get<int>("somma");
			Assert.AreEqual(p0, result);
		}

		//[Given("I have entered (.*) into the calculator")]
		//public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
		//{
		//	//TODO: implement arrange (precondition) logic
		//	// For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
		//	// To use the multiline text or the table argument of the scenario,
		//	// additional string/Table parameters can be defined on the step definition
		//	// method. 

		//	ScenarioContext.Current.Pending();
		//}

		//[When("I press add")]
		//public void WhenIPressAdd()
		//{
		//	//TODO: implement act (action) logic

		//	ScenarioContext.Current.Pending();
		//}

		//[Then("the result should be (.*) on the screen")]
		//public void ThenTheResultShouldBe(int result)
		//{
		//	//TODO: implement assert (verification) logic

		//	ScenarioContext.Current.Pending();
		//}
	}
}
