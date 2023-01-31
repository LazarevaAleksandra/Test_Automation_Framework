using Epam_TestAutomation_API.Controllers;
using Epam_TestAutomation_API;
using NUnit.Framework;
using RestSharp;
using System.Net;
using Epam_TestAutomation_API.ResponseModels;

namespace Epam_TestAutomation_API_Tests
{
    [TestFixture]
    public class PhonesTests
    {
        [Test]
        public void CheckPhonesResponseTest()
        {
            var response = new PhoneController(new CustomRestClient()).GetPhones<RestResponse>();

            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK),
                "Invalid status code was returned while sending GET request to /objects!");
        }

        [Test]
        public void CheckSinglePhonesResponseTest()
        {
            var phone = new PhoneController(new CustomRestClient()).GetPhones<List<AllPhonesModels>>();
            var listOfPhone = phone.Phones.ToList();
            var receivedPhone = new PhoneController(new CustomRestClient())
                .GetPhonesID<List<AllPhonesModels>>(listOfPhone.Select(item => item.id).Last());

            Assert.That(listOfPhone.Last().id, Is.EqualTo(receivedPhone.Phone.First().id),
                "Invalid status code was returned while sending GET request to /objects?id={0}");
        }
    }
}
