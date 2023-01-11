using Epam_TestAutomation_Core.BasePage;
using OpenQA.Selenium;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class SearchResultsPage : BasePage
    {
        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.ApplicationUrl);

        public Label OurOfficesCareer => new Label(By.XPath("//*[@class='tabs__ul js-tabs-links-list']"));

        public Button CareerButton = new Button(By.XPath("//*[@href = '/careers']"));

        public Button SearchButton = new Button(By.XPath("//*[@class = 'header-search__button header__icon']"));

        public Label FormSearch = new Label(By.XPath("//*[@id='new_form_search']"));

        public Button HeaderSearchButton = new Button(By.XPath("//*[@class = 'header-search__submit']"));

        public Label Articles = new Label(By.XPath("//*[@class = 'search-results__item']"));

        public Label Title = new Label(By.XPath("//*[@class = 'search-results__title-link']"));

        public Label TitleOfTheFirstArticle = new Label(By.XPath("//*[@class = 'search-results__title-link']"));

        public Button OnetrustAcceptButton = new Button(By.XPath("//button[@id='onetrust-accept-btn-handler']"));

        public Label TitleBusinessAnalysis = new Label(By.XPath("//*[@class='layout-box__wrapper']//h1"));
    }   
}

