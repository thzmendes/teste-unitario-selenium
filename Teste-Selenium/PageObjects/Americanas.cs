using OpenQA.Selenium;
using Utils;

namespace Teste_Selenium.PageObjects
{
    public class Americanas
    {
        public IWebDriver webDriver;
        public string homeURL;

        public void Buscar(IWebDriver webDriver, string produto)
        {
            webDriver.SetText(By.Id("h_search-input"), produto);
            webDriver.FindElement(By.Id("h_search-input")).SendKeys(Keys.Enter);
        }

        public void SelecionarProduto(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='content-middle']/div[5]/div/div/div/div[1]/div[3]/div/div[2]/a/section/div[1]")).Click();
        }

        public void ProsseguirCompra(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='btn-buy']/div")).Click();
        }

        public void SelecionarQuantidade(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='app']/section/section/div[1]/div[1]/section/ul/li/div[2]/div[2]/div/select")).Click();
            webDriver.FindElement(By.XPath(" //*[@id='app']/section/section/div[1]/div[1]/section/ul/li/div[2]/div[2]/div/select/option[3]")).Click();

        }

        public void AvancarParaCadastro(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("//*[@id='buy-button']")).Click();
        }

        public void PreencherEmail(IWebDriver webDriver, string email)
        {
            webDriver.SetText(By.Id("email-input"), email);

        }

        public void PreencherSenha(IWebDriver webDriver, string senha)
        {
            webDriver.SetText(By.Id("password-input"), senha);
        }
      
    }
}
