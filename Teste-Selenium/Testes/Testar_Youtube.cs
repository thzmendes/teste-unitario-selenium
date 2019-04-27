using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Teste_Geral.PageObjects;

namespace Teste_Youtube
{
    [TestFixture]
    public class TestarYoutube
    {
        Youtube x = new Youtube();

        [SetUp]
        public void SetupTest()
        {
            x.homeURL = "https://www.youtube.com/";
            x.webDriver = new ChromeDriver();
        }

        [TestCase("Toto - Africa")]
        public void TesteYoutube(string busca)
        {
            x.homeURL = "https://www.youtube.com/";
            x.webDriver.Navigate().GoToUrl(x.homeURL);
            x.Buscar(x.webDriver, busca);
            x.SelecionarVideo(x.webDriver);
        }

        public void TearDownTest()
        {
            x.webDriver.Close();
        }
    }
}

