using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDDLearning.Hooks
{
    public  class AssertClass
    {
        public bool IfElementExist(IWebElement element)
        {
            bool present;
            try
            {
               present= element.Displayed;
                                
            }catch(Exception e)
            {
                present = false;

            }
            return present;


        }
    }
}
