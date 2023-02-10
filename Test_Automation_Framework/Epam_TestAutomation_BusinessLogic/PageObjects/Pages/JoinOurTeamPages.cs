using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Core.Utils;
using Epam_TestAutomation_Utilities.Logger;
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

        public Dropdown DropdownLocations => new Dropdown(By.XPath("//*[@class='select2-results__options open']"));

        public TextInput LocationInput => new TextInput(By.XPath("//*[@class='select2-search__field']"));

        public Button CitiesLineButton => new Button(By.XPath("//*[@class='select2-results__option select2-results__option--highlighted']"));

        public Label SkillsLabel => new Label(By.XPath("//*[@class='default-label']"));

        public Label SkillFilter => new Label(By.XPath("//*[@class='filter-tag']"));

        public Dropdown SkillsDropdown => new Dropdown(By.XPath("//*[@class='multi-select-dropdown']"));

        public Checkbox SkillsCheckBox(string skill) => new Checkbox(By.XPath($"//*[@class='checkbox-custom-label'][contains(text(), '{skill}')]"));

        public Label ErrorMessage => new Label(By.XPath("//*[@class='search-result__error-message' and @role ='alert']"));

        public Label SearchResultTitle => new Label(By.XPath("//*[@class='search-result__heading']"));

        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.JoinOurTeamUrl);

        public void JoinOurTeamPagesIsOpened()
        {
            CareerButton.MoveToElement();
            Waiters.WaitForCondition(CareersBlog.IsDisplayed);
            JobListingsButton.Click();
        }

        public void FillInSearchFilter(string profession = null, string location = null, string skill = null)
        {
            if (!string.IsNullOrEmpty(profession))
            {
                KeywordInput.SendKeys(profession);
            }

            if (!string.IsNullOrEmpty(location))
            {
                LocationDropdown.Click();
                LocationInput.SendKeys(location);
                CitiesLineButton.Click();
            }

            if (!string.IsNullOrEmpty(skill))
            {
                SkillsLabel.Click();
                Waiters.WaitForCondition(() => !SkillsDropdown.GetAttribute("class").Contains("hidden"));               
                SkillsCheckBox(skill).Click();              
            }
            FindButton.Click();
        }

        public bool ErrorMessageDisplayed() => ErrorMessage.IsDisplayed();

        public string ActualErrorMessage() => ErrorMessage.GetAttribute("innerText");
    }
}
