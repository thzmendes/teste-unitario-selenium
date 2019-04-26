using OpenQA.Selenium;

namespace Utils
{
    public static class Utilitarios
    {

        public static void SetText(this IWebDriver webDriver,
            By by, string text)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.SendKeys(text);
        }

        public static void Submit(this IWebDriver webDriver, By by)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Submit();
        }

    }
}