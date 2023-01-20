using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using OpenQA.Selenium;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class JoinOurTeamPages : BasePage
    {
        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.ApplicationUrl);

        public TextInput KeywordInput => new(By.XPath("//*[@id='new_form_job_search_1445745853_copy-keyword']"));

        public Button FindButton => new(By.XPath("//*[@type='submit']"));

        public Dropdown LocationDropdown => new Dropdown(By.XPath("//*[@class='select2-selection select2-selection--single']"));

        public TextInput LocationInput => new TextInput(By.XPath("//*[@class='select2-search__field']"));

        public Button CitiesLineButton => new Button(By.XPath("//*[@class='select2-results__option select2-results__option--highlighted']"));

        public Label SkillsLabel => new Label(By.XPath("//*[@class='default-label']"));

        public Checkbox SkillsCheckBox(string skill) => new Checkbox(By.XPath($"//*[@class='checkbox-custom-label'][contains(text(), '{skill}')]"));

        public MainPage? _mainPage;

        public JoinOurTeamPages JoinOurTeamPagesIsOpened()
        {
            var career = _mainPage.CareerButton;
            BrowserFactory.Browser.Action.MoveToElement(career.OriginalWebElement);
            BrowserFactory.Browser.Action.Perform();
            _mainPage.JobListingsButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetProfessionKeyword(string keyword)
        {
            KeywordInput.SendKeys(keyword);
            FindButton.Click();

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
            SkillsCheckBox(keyword).Click();
            FindButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetSearchFilters(string profession, string location, string skill)
        {
            KeywordInput.SendKeys(profession);
            LocationDropdown.Click();
            LocationInput.SendKeys(location);
            CitiesLineButton.Click();
            SkillsLabel.Click();
            SkillsCheckBox(skill).Click();
            FindButton.Click();

            return new JoinOurTeamPages();
        }

        public JoinOurTeamPages GetErrorMessage(string profession, string location)
        {
            KeywordInput.SendKeys(profession);
            LocationDropdown.Click();
            LocationInput.SendKeys(location);
            CitiesLineButton.Click();
            FindButton.Click();

            return new JoinOurTeamPages();
        }
    }
}
