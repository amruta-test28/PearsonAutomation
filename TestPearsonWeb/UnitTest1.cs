using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestPearsonWeb
{
    [TestClass]
    public class UnitTest1
    {
        
        public IWebDriver driver;
        

        [SetUp]
        public void SetUp()
        {
           
            //Initialize Chromebrowser
            driver = new ChromeDriver();

            //Open URL"www.pearson.com"
            driver.Navigate().GoToUrl("https://www.pearson.com/");

            //Maximize browser window
            driver.Manage().Window.Maximize();
            
        }

        
        [TearDown]
       public void TearDown()
        {
            //Close the browser
            
            driver.Quit();
        }

        [Test]
        public void Section_Student()
        {
            
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                //Find link to 'Students' page and click on it
                driver.FindElement(By.CssSelector("#navbar-collapse-grid .dropdown:nth-child(3) > .dropdown-toggle")).Click();

                //Wait for new page to load
                System.Threading.Thread.Sleep(10000);
              //driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

                //Scroll page down
                js.ExecuteScript("window.scrollBy(0,1200);");

                //Accept Cookies
                driver.FindElement(By.XPath("//div[3]/div[2]/div[4]/div[2]/div/button")).Click();


                //Find link to'Discover MyLab' page and click on it
                driver.FindElement(By.LinkText("Discover MyLab®")).Click();

                //Wait for new page to load
                System.Threading.Thread.Sleep(10000);

                //Scroll page down
                js.ExecuteScript("window.scrollBy(0,1200);");

                //Find link to 'Accounting' page and click on it
                driver.FindElement(By.CssSelector(".slick-current .c-collection__banner-title")).Click();

                //Wait for page to load
                System.Threading.Thread.Sleep(10000);

                //Find link to 'Students' page and click on it
                driver.FindElement(By.LinkText("Learning platforms")).Click();
                System.Threading.Thread.Sleep(10000);

                //If survet pop up then decline survey
                CheckSurvey();
                System.Threading.Thread.Sleep(10000);

                js.ExecuteScript("window.scrollBy(0,1200);");
                //Find link to 'Discover Mastering' page and click on it
                driver.FindElement(By.LinkText("Discover Mastering®")).Click();
                System.Threading.Thread.Sleep(10000);

                js.ExecuteScript("window.scrollBy(0,1200);");
                //Find link to 'Biology' page and click on it
                //driver.FindElement(By.CssSelector(".slick-active .\\33 24948628158974850 .c-collection__banner-title")).Click();
                driver.FindElement(By.XPath("//div[7]/div/div/a/span"));
                System.Threading.Thread.Sleep(10000);

                //Find link to 'Students' page and click on it
                driver.FindElement(By.LinkText("Learning platforms")).Click();
                System.Threading.Thread.Sleep(10000);
                //If survet pop up then decline survey
                CheckSurvey();
                System.Threading.Thread.Sleep(10000);

                js.ExecuteScript("window.scrollBy(0,1200);");
                //Find link to 'Discover Revel' page and click on it
                driver.FindElement(By.LinkText("Discover Revel®")).Click();
             System.Threading.Thread.Sleep(10000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            js.ExecuteScript("window.scrollBy(0,1200);");
              
            //Find link to 'Economics' page and click on it
            // driver.FindElement(By.CssSelector(".slick-active .\\39 10804884651701900 .c-collection__banner-title")).Click();
            //driver.FindElement(By.XPath("//div[6]/div/div/a/span"));
            driver.FindElement(By.XPath("//div[@class='slick-slide slick-active']//div//span[@class='c-collection__banner-title'][normalize-space()='Economics']")).Click();

                System.Threading.Thread.Sleep(10000);

                //Find link to 'Students' page and click on it
                driver.FindElement(By.LinkText("Learning platforms")).Click();
                System.Threading.Thread.Sleep(10000);

                //If survet pop up then decline survey
                CheckSurvey();
                System.Threading.Thread.Sleep(10000);

                js.ExecuteScript("window.scrollBy(0,1200);");
               //Find linkbutton to 'Find your eText' page and click on it
                driver.FindElement(By.LinkText("Shop Pearson eText")).Click();
                System.Threading.Thread.Sleep(10000);

                //Find link to 'Home' page and click on it
                driver.FindElement(By.LinkText("Home")).Click();


         //This function checks whether Survey pop up appears and declines it.
            
         void CheckSurvey()
        {

                if (driver.FindElement(By.Id("mcxInvitationContainer")).Displayed)
                {
                    //driver.FindElement(By.Id("declinesurvey")).Click();
                    driver.FindElement(By.LinkText("No Thanks")).Click();
                    Console.WriteLine("survey decline");
                }

                else
                    Console.WriteLine("no survey pop up");
        }

    }
        

        [Test]
        public void Page_WhoWeAre() {
            
            //Find Menu icon and click on it
            driver.FindElement(By.CssSelector(".mega-nav-hamburger .navbar-toggle")).Click();

            //Wait for Menu to load
            System.Threading.Thread.Sleep(5000);

            // Find link 'Who we are' and click on it 
            driver.FindElement(By.LinkText("Who we are")).Click();
            //Wait for sub-menu to open
            System.Threading.Thread.Sleep(5000);

            // Find link 'Our company' and click on it
            driver.FindElement(By.LinkText("Our company")).Click();

            //Wait for new page to load
            System.Threading.Thread.Sleep(5000);

            //Check text 'Our company' exists on the page and store it in string        
            String str = driver.FindElement(By.XPath("//span[contains(.,'Our company')]")).Text;

            //Display text on console output
            Console.WriteLine(str);
          
            
        }

        [Test]
        public void Page_WhatWeDo()
        {
            //Find Menu icon and click on it
            driver.FindElement(By.CssSelector(".mega-nav-hamburger .navbar-toggle")).Click();

            //Wait for menu to load
            System.Threading.Thread.Sleep(5000);

            // Find link 'Waht we do' and click on it
            driver.FindElement(By.LinkText("What we do")).Click();

            System.Threading.Thread.Sleep(5000);

            //Find link 'Clinical & classroom assessments' and click on it
            driver.FindElement(By.LinkText("Clinical & classroom assessments")).Click();

            System.Threading.Thread.Sleep(5000);

            //Check text 'Clinical assessments' exists on the page and store it in string
            string str = driver.FindElement(By.CssSelector(".slick-slide:nth-child(2) h1:nth-child(1)")).Text;

            //Display text on console output
            Console.WriteLine(str);
           
           
            
        }

        [Test]
        public void Page_EText()
        {
            IJavaScriptExecutor js =(IJavaScriptExecutor) driver;

            //Find page link 'Save with eTexts' and click on it
            driver.FindElement(By.LinkText("Save with eTexts")).Click();
            
            System.Threading.Thread.Sleep(5000);

            //Scroll page down
            js.ExecuteScript("window.scrollBy(0,500);");
            
            //Find linkbutton 'Browse eTexts'and click on it
            driver.FindElement(By.Id("primaryButton")).Click();

            System.Threading.Thread.Sleep(5000);

            // Find home page logo and click on it 
            driver.FindElement(By.CssSelector("picture > img:nth-child(2)")).Click();
       
            
        }
    }
}
