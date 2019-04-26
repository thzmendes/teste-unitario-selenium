using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Teste_Geral.PageObjects;

namespace Teste_GoogleMaps
{
    [TestFixture]
    public class TestarGoogleMaps
    {
        GoogleMaps x = new GoogleMaps();

        [SetUp]
        public void SetupTest()
        {
            x.homeURL = "https://www.google.com.br/maps";
            x.webDriver = new ChromeDriver();
        }

        [TestCase("Praça da Sé", "Masp")]
        [TestCase("Parque Ibirapuera", "Metrô Ana Rosa")]
        [TestCase("Viaduto do Chá", "Enseada Guarujá")]
        public void TesteGoogleMaps(string local_desejado, string local_atual)
        {
            x.homeURL = "https://www.google.com.br/maps";
            x.webDriver.Navigate().GoToUrl(x.homeURL);
            x.Buscar(x.webDriver, local_desejado);
            x.SelectRota(x.webDriver);
            x.DefinirLocalPartida(x.webDriver, local_atual);

        }

        public void TearDownTest()
        {
            x.webDriver.Close();
        }


    }


}

