using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium_ExecuteAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement rejectAll = driver.FindElement(By.Id("W0wltc"));
            rejectAll.Click();

            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);

        }

        [Test]

        public void EAWebsiteTest()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            //find the login link
            IWebElement loginLink = driver.FindElement(By.LinkText("Login")); // BY.Id("loginLink")
            //click on login link
            loginLink.Click();
            // find & complete the username text box
            IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            txtUserName.SendKeys("admin");
            // find & complete the password text box
            IWebElement txtPassword = driver.FindElement(By.Id("Password"));
            txtPassword.SendKeys("password");
            //identify the login button using class name 
            //IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
            //btnLogin.Submit();
            //identify the login button using css selector
            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));
            btnLogin.Submit();

        }


        [Test]

        public void EAWebsiteTestReducedSizecode()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            //find& click the login link
            //driver.FindElement(By.Id("loginLink")).Click(); // BY.Id("loginLink")
            SeleniumCustomMethods.Click(driver, By.Id("loginLink"));
            //driver.FindElement(By.Name("UserName")).SendKeys("admin");
            SeleniumCustomMethods.EnterText(driver, By.Name("Username"), "admin");
            driver.FindElement(By.Id("Password")).SendKeys("password");
            driver.FindElement(By.CssSelector(".btn")).Submit();

        }

        [Test]

        public void WorkingWithAdvancedControl()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");
            driver.Manage().Window.Maximize();

            //dropdown
            //driver.FindElement(By.Id("oldSelectMenu"));
            //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("oldSelectMenu")));
            //selectElement.SelectByValue("7");
            //selectElement.SelectByText("white");


            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            //multipleselect
            //SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("cars")));
            ////selectElement.SelectByValue("Opel");
            //IList<IWebElement> selectedOption =  multiSelect.AllSelectedOptions;
            //foreach (IWebElement option in selectedOption)
            //{
            //    Console.WriteLine(option.Text);
            //}

            //->
            IWebElement loginLink = driver.FindElement(By.Id("loginLink"));
            loginLink.Click();
            //->with methods
            SeleniumCustomMethods.Click(driver, By.Id("loginLink"));




        }


    


    }
}