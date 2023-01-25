Feature: DataEntryForJobSearch
As a user interested in EPAM Company
I want to be able to search for jobs by keywords
In order to apply for a job

@Profession
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Profession By Keyword
	Given The join our team page is opened from the main page
	When Enter profession <profession>
	Then The result that contains the <profession> is displayed on the page 

    Examples:    
    | profession |
    | manager |
    | android |

@Location
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Location By Keyword
	Given The join our team page is opened from the main page
	When Enter location <location>
	Then The result that contains the <location> is displayed on the page 

	Examples: 
	| location   |
	| Yerevan    |
	| Copenhagen |

@Skill
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Skill By Keyword
	Given The join our team page is opened from the main page
	When Enter skill <skill>
	Then The result that contains the <skill> is displayed on the page 

	Examples: 
	| skill                                  |
	| Business and Data Analysis             |
	| Software, System, and Test Engineering |

