using System;
using System.Collections.Generic;

using NUnit.Framework;

using TechTalk.SpecFlow;


namespace KataSupermarket.Tests
{
	[Binding]
	public sealed class SupermaketBundlesSteps
	{
		// For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"il seguento listino prezzi:")]
        public void DatoIlSeguentoListinoPrezzi(Table table)
        {
            var productRules = ScenarioContext.Current.Retrieve<List<IProductRule>>("productRules");

            foreach (var row in table.Rows)
            {
                var prodotto = row["Prodotto"][0];   
                var prezzo = Convert.ToDouble(row["Prezzo"]);

                var productRule = new ProductRule();
                productRule.Set(prodotto, 1, prezzo);

                productRules.Add(productRule);
            }

            ScenarioContext.Current.Update("productRules", productRules);
        }

        [Given(@"le seguenti offerte:")]
        public void DatoLeSeguentiOfferte(Table table)
        {
            var productRules = ScenarioContext.Current.Retrieve<List<IProductRule>>("productRules");

            foreach (var row in table.Rows)
            {
                var prodotto = row["Prodotto"][0];
                var quantita = Convert.ToUInt16(row["Quantità"]);
                var prezzo = Convert.ToDouble(row["Prezzo"]);

                var productRule = new ProductRule();
                productRule.Set(prodotto, quantita, prezzo);

                productRules.Add(productRule);
            }

            ScenarioContext.Current.Update("productRules", productRules);
        }

        [Given(@"la seguente lista di prodotti acquistati (.*)")]
        public void DatoLaSeguenteListaDiProdottiAcquistati(string p0)
        {
            ScenarioContext.Current.Add("productList", p0);
        }

        [When(@"vado a pagare")]
        public void QuandoVadoAPagare()
        {
            var productRules = ScenarioContext.Current.Retrieve<List<IProductRule>>("productRules");
            var productList = ScenarioContext.Current["productList"].ToString();

            var checkout = new Checkout();
            checkout.AddProductRuleRange(productRules);

            var finalPrice = checkout.GetPrice(productList);
            ScenarioContext.Current.Add("finalPrice", finalPrice);
        }

        [Then(@"il prezzo totale è (.*) dollari")]
        public void AlloraIlPrezzoTotaleEDollari(double p0)
        {
            var finalPrice = (double)ScenarioContext.Current["finalPrice"];
            Assert.AreEqual(p0, finalPrice);
        }
    }
}
