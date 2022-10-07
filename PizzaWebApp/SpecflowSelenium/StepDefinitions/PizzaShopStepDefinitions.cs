using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.StepDefinitions
{
    [Binding]
    public class PizzaShopStepDefinitions 
    {
        private ChromeDriver chromeDriver;

        public PizzaShopStepDefinitions() => chromeDriver = new ChromeDriver();
        

        [Given(@"I navigate to PizzaShop page")]
        public void GivenINavigateToPizzaShopPage()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://localhost:1007/");
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"I click on all pizza button and add pizza to the cart")]
        public void ThenIClickOnAllPizzaButtonAndAddPizzaToTheCart()
        {
            chromeDriver.FindElement(By.LinkText("All Pizza's")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"I click on veg pizza button and add veg pizza to the cart")]
        public void ThenIClickOnVegPizzaButtonAndAddVegPizzaToTheCart()
        {
            chromeDriver.FindElement(By.LinkText("Veg")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"I click on non veg pizza and add non veg pizza to the cart")]
        public void ThenIClickOnNonVegPizzaAndAddNonVegPizzaToTheCart()
        {
            chromeDriver.FindElement(By.LinkText("Non_Veg")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"I click on view cart button to check the order list")]
        public void ThenIClickOnViewCartButtonToCheckTheOrderList()
        {
            chromeDriver.FindElement(By.LinkText("View Cart")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"add or remove pizzas")]
        public void ThenAddOrRemovePizzas()
        {
            chromeDriver.FindElement(By.LinkText("Remove")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.LinkText("+")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.LinkText("-")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I click Checkout button order should be placed")]
        public void WhenIClickCheckoutButtonOrderShouldBePlaced()
        {
            chromeDriver.FindElement(By.LinkText("Checkout")).Click();
            System.Threading.Thread.Sleep(8000);
            chromeDriver.Close();
        }
    }
}
