using OpenQA.Selenium;
using Utils;

namespace Teste_Geral.PageObjects
{
    public class Youtube
    {
        public  IWebDriver webDriver;
        public string homeURL;

        public void Buscar(IWebDriver webDriver, string busca)
        {
            webDriver.SetText(By.Id("search"), busca);
            webDriver.Submit(By.Id("search-icon-legacy"));
        }

        public void SelecionarVideo(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='video-title']")).Click();
        }

       
    }
}
