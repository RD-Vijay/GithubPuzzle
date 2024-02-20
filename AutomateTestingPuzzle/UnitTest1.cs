using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationTestingPuzzle
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "file:///C:/Users/Vijay.Bagdi/source/repos/SeleniumPractice/AutomateTestingPuzzle/Testingquiz.html";
            Thread.Sleep(5000);
        }


        //[Test]
        //public void CheckAnswers()
        //{
        //    driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("file:///C:/Users/Vijay.Bagdi/source/repos/SeleniumPractice/AutomateTestingPuzzle/Testingquiz.html");
        //    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //    executor.ExecuteScript("document.body.style.zoom = '0.5'");
        //    Thread.Sleep(5000);
        //    IWebElement first = driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][1]"));
        //    Thread.Sleep(3000);
        //    first.Click();
        //    first.SendKeys("Interface");
        //    Thread.Sleep(3000);
        //    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //    executor.ExecuteScript("document.body.style.zoom = '0.5'");
        //    Thread.Sleep(5000);
        //    driver.FindElement(By.XPath("//div[@class='menu-button when-closed']")).Click();
        //    IWebElement first = driver.FindElement(By.XPath("//a[@id='check-button-mobile']"));
        //    first.Click();
        //    Thread.Sleep(3000);

        //    driver.FindElement(By.LinkText("check-button")).Click();
        //    string count = driver.FindElement(By.XPath("//*[@id='check-correct-words']")).Text;
        //    Assert.AreEqual(1, count);
        //}

        [Test]
        public void SolvePuzzle()
        {
            // WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.Id("entry-box-mobile")));
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][3]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][17]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][16]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][18]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][25]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][28]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][32]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][37]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][47]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][59]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][82]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][84]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][98]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//a[@id='solve-button-mobile']//span[@data-locid='solve']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div//*[name()='svg']/*[name()='g']/*[name()='rect'][109]")).Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
