using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using NUnit.Framework;

using TechTalk.SpecFlow;

namespace KataSupermarket.Tests
{
	[Binding]
	public sealed class SupermaketBundlesSteps
	{
		private readonly List<string> _productList;
		private readonly List<string> _offersList;

		public SupermaketBundlesSteps()
		{
			_productList = new List<string>();
			_offersList = new List<string>();
		}

		// For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
		[Given(@"che ProdottoA costa 50 dollari")]
		public void DatoCheProdottoACosta50Dollari()
		{
			char productA = 'A';
			double productAPrice = 50;

			ScenarioContext.Current.Add("productA", productA);
			ScenarioContext.Current.Add("productAPrice", productAPrice);
		}

		[Given(@"che compro 1 pezzo")]
		public void DatoCheComproPezzo()
		{
			ScenarioContext.Current.Add("productAQuantity", 1);
		}

		[When(@"chiedo il prezzo")]
		public void QuandoChiedoIlPrezzo()
		{
			char productA = (char)ScenarioContext.Current["productA"];
			var productAQuantity = (int)ScenarioContext.Current["productAQuantity"];
			var productAPrice = (double)ScenarioContext.Current["productAPrice"];

			var productARules = new List<IProductRule>();
			var productABasicRule = new ProductRule();
			productABasicRule.Set(productA, (uint)productAQuantity, productAPrice);
			productARules.Add(productABasicRule);
			
			var productList = productA.ToString();

			var checkout = new Checkout();
			checkout.AddProductRuleRange(productARules);
			
			var price = checkout.GetPrice(productList);

			ScenarioContext.Current.Add("price", price);
		}

		[Then(@"il prezzo è 50 dollari")]
		public void AlloraIlPrezzoEDollari()
		{
			var price = (double)ScenarioContext.Current["price"];

			Assert.AreEqual(50, price);
		}

		[Given(@"un pezzo di ProdottoA che costa 50 dollari")]
		public void DatoUnPezzoDiProdottoACheCostaDollari()
		{
			char productA = 'A';
			double productAPrice = 50;

			ScenarioContext.Current.Add("productA", productA);
			ScenarioContext.Current.Add("productAPrice", productAPrice);
		}

		[Given(@"(.*) pezzi di (.*) che costa (.*) dollari")]
		public void DatoPezziDiCheCostaDollari(string p0, string p1, string p2)
		{
			var productList = ScenarioContext.Current["productList"];
			_productList.Add($"{p0}|{p1}|{p2}");

			ScenarioContext.Current.Add("productList", _productList);
		}

		[Given(@"una offerta per (.*) pezzi di (.*) per (.*) dollari")]
		public void DatoUnaOffertaPerPezziDiPerDollari(string p0, string p1, string p2)
		{
			_offersList.Add($"{p0}|{p1}|{p2}");

			ScenarioContext.Current.Add("offersList", _offersList);
		}
		
		[When(@"chiedo il prezzo totale")]
		public void QuandoChiedoIlPrezzoTotale()
		{
			var productDataList = ScenarioContext.Current["productList"] as List<string>;
			var promotions = ScenarioContext.Current["offersList"] as List<string>;

			string productList = null;

			var productRules = new List<IProductRule>();
			
			foreach (var productData in productDataList)
			{
				var data = productData.Split('|');
				char product = data[0].First();
				uint quantity = 0;
				uint.TryParse(data[1], out quantity);
				double price = 0;
				double.TryParse(data[2], out price);

				var productRule = new ProductRule();
				productRule.Set(product, quantity, price);
				productRules.Add(productRule);

				productList += (product.ToString());
			}
			foreach (var promotion in promotions)
			{
				var data = promotion.Split('|');
				char product = data[0].First();
				uint quantity = 0;
				uint.TryParse(data[1], out quantity);
				double price = 0;
				double.TryParse(data[2], out price);

				var productRule = new ProductRule();
				productRule.Set(product, quantity, price);
				productRules.Add(productRule);
			}

			var checkout = new Checkout();
			checkout.AddProductRuleRange(productRules);

			var finalPrice = checkout.GetPrice(productList);
			ScenarioContext.Current.Add("productList", finalPrice);
		}

		[Then(@"il prezzo totale è (.*) dollari")]
		public void AlloraIlPrezzoTotaleEDollari(double p0)
		{
			var finalPrice = (double)ScenarioContext.Current["finalPrice"];
			Assert.AreEqual(p0, finalPrice);
		}

	}
}
