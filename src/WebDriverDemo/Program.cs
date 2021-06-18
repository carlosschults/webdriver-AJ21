using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("testes automatizados");
            element.SendKeys(Keys.Return);
        }
    }
}
