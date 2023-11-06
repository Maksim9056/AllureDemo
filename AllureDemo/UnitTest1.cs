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

    [TestFixture(Author = "Maksim Bobretsov", Description = "Examples")]
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
            //Код отправки Get 
            string url = "https://api.sampleapis.com/futurama/questions";

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("GET Response content: " + content);
                    Console.WriteLine("GET Status code: " + (int)response.StatusCode);
                    Assert.AreEqual(200, (int)response.StatusCode);

                }
            }
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("API")]
        public void TestApiPost()
        {
            string url = "https://api.sampleapis.com/futurama/questions";

            //Код для отправки POST-запроса

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("POST Response content: " + content);
                    Console.WriteLine("POST Status code: " + (int)response.StatusCode);
                    Assert.AreEqual(200, (int)response.StatusCode);


                }
            }
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("API")]

        public void TestApiPut()
        {
            string url = "https://api.sampleapis.com/futurama/questions";

            //Код для отправки PUT-запроса

            // Пример:
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, url))
            {
                using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("PUT Response content: " + content);
                    Console.WriteLine("PUT Status code: " + (int)response.StatusCode);
                    Assert.AreEqual(200, (int)response.StatusCode);
                }
            }
        }
    }
}