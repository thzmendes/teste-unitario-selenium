using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Teste_Selenium.PageObjects;

namespace Teste_Americanas
{
    [TestFixture]
    public class Teste_MarketPlace_Americanas
    {
        Americanas x = new Americanas();

        [SetUp]
        public void SetupTest()
        {
            x.homeURL = "https://www.americanas.com.br/";
            x.webDriver = new ChromeDriver();
        }

        [TestCase("one milion", "01303900")]
        public void TesteAmericanas(string busca, string cep)
        {
            x.homeURL = "https://www.americanas.com.br/";
            x.webDriver.Navigate().GoToUrl(x.homeURL);
            x.Buscar(x.webDriver, busca);
            x.SelecionarProduto(x.webDriver);
            x.ProsseguirCompra(x.webDriver);
            x.SelecionarQuantidade(x.webDriver);
            x.PreencherCEP(x.webDriver, cep);
            x.Avancar(x.webDriver);
            TearDownTest();
        }

        public void TearDownTest()
        {
            x.webDriver.Close();
        }


    }


}

