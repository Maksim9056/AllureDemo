using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AllureDemo
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
            Assert.Pass();
        }
    }

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