using Epam_TestAutomation_API;
using Epam_TestAutomation_API.Controllers;
using Epam_TestAutomation_API.ResponseModels;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace Epam_TestAutomation_API_Tests
{
    [TestFixture]
    public class BiblesTests
    {
        [Test]
        public void CheckAudioBiblesResponseTest()
        {
            var response = new BiblesController(new CustomRestClient()).GetAudioBibles<RestResponse>();

            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK),
                "Invalid status code was returned while sending GET request to /v1/audio-bibles!");
        }

        [Test]
        public void CheckSingleAudioBibleResponseTest()
        {
            var bibles = new BiblesController(new CustomRestClient()).GetBibles<AllBiblesModel>().Bibles.data;
            var response = new BiblesController(new CustomRestClient()).GetAudioBible<RestResponse>(bibles.First().id);

            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK),
                "Invalid status code was returned while sending GET request to /v1/audio-bibles/{0}!");
        }

        [Test]
        public void CheckAudioBiblesResponseWithoutAuthorizationTest()
        {
            var response = new BiblesController(new CustomRestClient(), string.Empty).GetAudioBibles<RestResponse>();

            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized),
                "Invalid status code was returned while sending GET request to /v1/audio-bibles without authorization!");
        }

        #region Books
        [Test]
        public void CheckThatChaptersAreNotEmptyTest()
        {
            var bibles = new BiblesController(new CustomRestClient()).GetBibles<AllBiblesModel>().Bibles.data;
            var biblesId = bibles.First().id;
            var book = new BiblesController(new CustomRestClient()).GetBook<SingleBible>(biblesId).Books.data;
            var bookVersion = new BiblesController(new CustomRestClient()).GetBooks<AllBooksModels>(book.id).Books.data;
            var chapters = new BiblesController(new CustomRestClient()).GetChapters<Chapters>(biblesId ,bookVersion.First().id).Chapters.data;

            Assert.IsTrue(chapters.Any(), "Book chapters are empty!");
        }
        #endregion
    }
}
