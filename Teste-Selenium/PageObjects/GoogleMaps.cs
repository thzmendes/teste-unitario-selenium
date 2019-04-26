using OpenQA.Selenium;
using Utils;

namespace Teste_Geral.PageObjects
{
    public class GoogleMaps
    {
        public  IWebDriver webDriver;
        public string homeURL;

        public void Buscar(IWebDriver webDriver, string local)
        {
            webDriver.SetText(By.XPath("//*[@id=searchboxinput']"), local);
            webDriver.Submit(By.XPath("//*[@id=searchboxinput']"));
        }

        public void SelectRota(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='pane']/div/div[1]/div/div/div[3]/div[1]/div/button/img")).Click();
        }

        public void DefinirLocalPartida(IWebDriver webDriver, string local)
        {
            webDriver.SetText(By.XPath("//*[@id='sb_ifc51']/input"), local);
            webDriver.Submit(By.XPath("//*[@id='sb_ifc51']/input"));
        }
    }
}
