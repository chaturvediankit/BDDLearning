using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDDLearning.Hooks
{
    
    public  class BaseClass
    {

        public static IWebDriver MyDriver;

        public void EneterText(IWebElement element,String text)
        {
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }
        public void SelectDropDownByValue(IWebElement element, String value)
        {

        }
        public void SelectDropDownByVisibleText(IWebElement element, String visibleText)
        {

        }
        public void SelectDropDownByIndiex(IWebElement element, int index)
        {

        }
    }
}
