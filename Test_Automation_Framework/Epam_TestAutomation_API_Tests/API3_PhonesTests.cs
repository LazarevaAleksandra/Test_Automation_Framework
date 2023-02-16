using Epam_TestAutomation_API;
using Epam_TestAutomation_API.Controllers;
using Epam_TestAutomation_API.RequesModelsPhone;
using Epam_TestAutomation_API.ResponseModels;
using Epam_TestAutomation_API.SharedModelsPhone;
using RestSharp;
using NUnit.Framework;

namespace Epam_TestAutomation_API_Tests
{
    [TestFixture]
    public class API3_PhonesTests
    {
        private string deleteThePhone;

        [Test]
        public void CheckTheCapacityOfTheCreatedObjectTest()
        {
            var addPhone = new PhonesModels
            {
                name = "Apple iPhone 12 Pro Max",
                data = new PhonesData
                {                  
                    color = "Cloudy White",
                    CapacityGb = 512
                }
            };

            var createdPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivedPhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createdPhone.id).Phone;
            deleteThePhone = receivedPhone.id;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(receivedPhone.data.CapacityGb, Is.EqualTo(createdPhone.data.CapacityGb),
                "The capacity of the created phone in GB is not equal to the original!");
        }

        [Test]
        public void CheckThatThereAreNoPhonesWithARandomIdTest()
        {
            var addPhone = new PhonesModels
            {
                name = "Apple iPhone 12",
                data = new PhonesData
                {
                    price = 1500,
                    color = "White",
                    CapacityGb = 512
                }
            };

            var createdPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivedPhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createdPhone.id).Phone;
            deleteThePhone = receivedPhone.id;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(receivedPhone, Is.Not.Null, "Phone not created!");
        }

        [Test]
        public void CheckForNewPropertyTest()
        {
            var addPhone = new PhonesModels
            {
                name = "Apple iPhone 12 Pro Max",
                data = new PhonesData
                {
                    color = "Cloudy White",
                    CapacityGb = 512
                }
            };

            var createdPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivedPhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createdPhone.id).Phone;
            deleteThePhone = receivedPhone.id;
            addPhone.data.color = "Black";
            var updatePhone = new PhoneController(new CustomRestClient()).UpdatePhone<AllPhonesModels>(receivedPhone.id, addPhone);
            receivedPhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(receivedPhone.id).Phone;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(createdPhone.data.color, Is.EqualTo(receivedPhone.data.color), "New color not installed!");
        }
    }
}
