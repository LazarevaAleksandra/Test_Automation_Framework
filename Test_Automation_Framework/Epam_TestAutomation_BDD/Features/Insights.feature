Feature: Insights
As a user interested in EPAM Company
I want to be able to follow the link
In order to get information about Company

@Blog
@Smoke
Scenario: Epam Site - Insights Page - Check Blog link 
	Given I navigate to Epam site 
	When I click 'Insights' link on Epam site
	Then I check that Insights page is opened
