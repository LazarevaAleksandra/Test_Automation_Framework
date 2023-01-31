using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Core.Utils;
using OpenQA.Selenium;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class JoinOurTeamPages : BasePage
    {     
        public Button CareersBlog => new Button(By.XPath("//*[@href='/careers/blog']"));

        public Link CareerButton => new Link(By.XPath("//*[@href = '/careers']"));

        public Button JobListingsButton => new Button(By.XPath("//*[@href = '/careers/job-listings']"));

        public TextInput KeywordInput => new(By.XPath("//*[@id='new_form_job_search_1445745853_copy-keyword']"));

        public Button FindButton => new(By.XPath("//*[@type='submit']"));

        public Dropdown LocationDropdown => new Dropdown(By.XPath("//*[@class='select2-selection select2-selection--single']"));

        public TextInput LocationInput => new TextInput(By.XPath("//*[@class='select2-search__field']"));

        public Button CitiesLineButton => new Button(By.XPath("//*[@class='select2-results__option select2-results__option--highlighted']"));

        public Label SkillsLabel => new Label(By.XPath("//*[@class='default-label']"));

        public Label SkillFilter => new Label(By.XPath("//*[@class='filter-tag']"));

        public Checkbox SkillsCheckBox(string skill) => new Checkbox(By.XPath($"//*[@class='checkbox-custom-label'][contains(text(), '{skill}')]"));

        public Label ErrorMessage => new Label(By.XPath("//*[@class='search-result__error-message' and @role ='alert']"));

        public Label SearchResultTitle => new Label(By.XPath("//*[@class='search-result__heading']"));

        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.JoinOurTeamUrl);

        public JoinOurTeamPages JoinOurTeamPagesIsOpened()
        {
            CareerButton.MoveToElement();
            Waiters.WaitForCondition(CareersBlog.IsDisplayed);
            JobListingsButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetProfessionKeyword(string keyword)
        {
            KeywordInput.SendKeys(keyword);
            FindButton.Click();
            Waiters.WaitForCondition(SearchResultTitle.IsDisplayed);

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetLocationKeyword(string keyword)
        {
            LocationDropdown.Click();
            LocationInput.SendKeys(keyword);
            CitiesLineButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetSkillKeyword(string keyword)
        {
            SkillsLabel.Click();
            Thread.Sleep(2000);
            SkillsCheckBox(keyword).Click();
            Waiters.WaitForCondition(SkillFilter.IsDisplayed);
            FindButton.Click();
           
            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetSearchFilters(string profession, string location, string skill)
        {
            KeywordInput.SendKeys(profession);
            LocationDropdown.Click();
            Thread.Sleep(2000);
            LocationInput.SendKeys(location);
            CitiesLineButton.Click();
            SkillsLabel.Click();
            Thread.Sleep(2000);
            SkillsCheckBox(skill).Click();
            FindButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetErrorMessage(string profession, string location)
        {
            KeywordInput.SendKeys(profession);
            LocationDropdown.Click();
            Thread.Sleep(2000);
            LocationInput.SendKeys(location);
            CitiesLineButton.Click();
            FindButton.Click();

            return new JoinOurTeamPages();
        }

        public bool ErrorMessageDisplayed() => ErrorMessage.IsDisplayed();

        public string ActualErrorMessage() => ErrorMessage.GetAttribute("innerText");
    }
}
