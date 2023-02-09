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

            var createPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivePhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createPhone.id).Phone;
            deleteThePhone = receivePhone.id;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(receivePhone.data.CapacityGb, Is.EqualTo(createPhone.data.CapacityGb),
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

            var createPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivePhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createPhone.id).Phone;
            deleteThePhone = receivePhone.id;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(receivePhone, Is.Not.Null, "Phone not created!");
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

            var createPhone = new PhoneController(new CustomRestClient()).AddPhone<AllPhonesModels>(addPhone).Phone;
            var receivePhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(createPhone.id).Phone;
            deleteThePhone = receivePhone.id;
            addPhone.data.color = "Black";
            var updatePhone = new PhoneController(new CustomRestClient()).UpdatePhone<AllPhonesModels>(receivePhone.id, addPhone);
            receivePhone = new PhoneController(new CustomRestClient()).GetPhonesID<AllPhonesModels>(receivePhone.id).Phone;
            new PhoneController(new CustomRestClient()).DeletePhone<RestResponse>(deleteThePhone);

            Assert.That(createPhone.data.color, Is.EqualTo(receivePhone.data.color), "New color not installed!");
        }
    }
}
