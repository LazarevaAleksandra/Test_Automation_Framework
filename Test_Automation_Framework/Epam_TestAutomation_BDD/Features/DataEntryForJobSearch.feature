Feature: DataEntryForJobSearch
As a user interested in EPAM Company
I want to be able to search for jobs by keywords
In order to apply for a job

@Profession
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Profession By Keyword
	Given The join our team page is opened from the main page
	When Enter the profession <profession> in the Keyword field
	Then The result that contains the <profession> is displayed on the JoinOurTeam page 

    Examples:    
    | profession |
    | manager |
    | android |

@Location
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Location By Keyword
	Given The join our team page is opened from the main page
	When Enter the location <location> in the All Locations field
	Then The result that contains the <location> is displayed on the JoinOurTeam page 

	Examples: 
	| location   |
	| Yerevan    |
	| Copenhagen |

@Skill
@Smoke
Scenario Outline: Epam Site - JoinOurTeam Page - Check Skill By Keyword
	Given The join our team page is opened from the main page
	When Enter the skill <skill> in the All Skills field
	Then The result that contains the <skill> is displayed on the JoinOurTeam page 

	Examples: 
	| skill                                  |
	| Business and Data Analysis             |
	| Software, System, and Test Engineering |

