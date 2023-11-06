using Allure.Commons;
using Microsoft.VisualBasic;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AllureDemo
{
    //public class Tests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {
    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        Assert.Pass();
    //    }
    //}



    [TestFixture(Author = "unickq", Description = "Examples")]
    [AllureNUnit]
    [AllureLink("https://github.com/allure-framework/allure-csharp")]
    public class Tests
    {
        private HttpClient httpClient;

        [OneTimeSetUp]
        public void Setup()
        {
            httpClient = new HttpClient();
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("API")]
        public void TestApiStatus()
        {
            string url = "https://api.sampleapis.com/futurama/questions";

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
                {
                    Assert.AreEqual(200, (int)response.StatusCode);
                }
            }
        }
    }


    //[TestFixture(Author = "unickq", Description = "Examples")]
    //[AllureNUnit]
    //[AllureLink("https://github.com/allure-framework/allure-csharp")]
    //public class Tests
    //{



    //    [OneTimeSetUp]
    //    public void ClearResultsDir()
    //    {
    //        AllureLifecycle.Instance.CleanupResultDirectory();
    //    }

    //    [AllureStep("This method is just saying hello")]
    //    private void SayHello()
    //    {
    //        Console.WriteLine("Hello!");
    //    }

    //    [Test]
    //    [AllureTag("NUnit", "Debug")]
    //    [AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
    //    [AllureSeverity(SeverityLevel.critical)]
    //    [AllureFeature("Core")]
    //   //[AllureId(123)]
    //    public void EvenTest([Range(0, 5)] int value)
    //    {
    //        SayHello();

    //        //Wrapping Step
    //        AllureLifecycle.Instance.WrapInStep(
    //            () => { Assert.IsTrue(value % 2 == 0, $"Oh no :( {value} % 2 = {value % 2}"); },
    //            "Validate calculations");
    //    }
    //}
    [Binding]
    public class ValidateUserSteps
    {

        [Given(@"Setup is done")]
        public void GivenSetupIsDone()
        {

        }


        [When(@"User is created")]
        public void WhenUserIsCreated()
        {

        }

        [Then(@"Validate user info")]
        public void ThenValidateUserInfo()
        {

        }
    }
}