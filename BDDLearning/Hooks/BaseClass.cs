using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDDLearning.Hooks
{
    
    public  class BaseClass
    {


        public static void EneterText(IWebElement element,String text)
        {
            System.Threading.Thread.Sleep(10000);
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }
        public static void SelectDropDownByValue(IWebElement element, String value)
        {

        }
        public static void SelectDropDownByVisibleText(IWebElement element, String visibleText)
        {

        }
        public static void SelectDropDownByIndiex(IWebElement element, int index)
        {

        }
    }
}
