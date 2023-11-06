using Allure.Commons;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AllureDemo
{
    [Binding]
    public class Hooks
    {

       public static  AllureLifecycle allure = AllureLifecycle.Instance;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory();



        }
    }
}
