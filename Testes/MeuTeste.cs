using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Testes
{
    [TestClass]
    public class MeuTeste
    {

        private IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://pt.wikipedia.org/wiki/Wikip%C3%A9dia:P%C3%A1gina_principal");
        }

        [TestCleanup]
        public void testCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void Pesquisar_Resultado()
        {
            
            IWebElement searchInput = driver.FindElement(By.Id("searchInput"));
            searchInput.SendKeys("Ronaldo");
            searchInput.SendKeys(Keys.Enter);
            string firstHeading = driver.FindElement(By.Id("firstHeading")).Text;
            Assert.AreEqual("Ronaldorr", firstHeading);
        }

        [TestMethod]
        public void Pesquisar_Sem_Resultado()
        {
            IWebElement searchInput = driver.FindElement(By.Id("searchInput"));
            searchInput.SendKeys("asdnjhj");
            searchInput.SendKeys(Keys.Enter);
            string createLink = driver.FindElement(By.ClassName("mw-search-nonefound")).Text;
            Assert.IsTrue(createLink.Contains("A pesquisa não produziu resultados"));
        }

    }
}
