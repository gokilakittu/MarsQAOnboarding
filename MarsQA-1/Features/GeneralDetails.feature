Feature: GeneralDetails Feature

As a seller of the mars
I would like to add, edit general details in the profile
So that i could look into my details in the profile page successfully

@GeneralDetails

Scenario Outline:1 Add/Edit decription to the profile
		Given I logged into the mars successfully
		When I am in the profile page
		When I Click the edit button near the decription
		When I enter the '<decription>' in decription
		And I click on the save button
		Then i could see '<decription>' of the profile successfully

Examples:
| decription		|
| Something about me		|

Scenario Outline:2 Add/Edit the firstname and the lastname to the profile
		Given I logged into the mars successfully
		When I am in the profile page
		When I Click on my fullname 
		When I enter the '<firstname>' '<lastname>'   
		And I click on the save button to save the names
		Then I could see the '<firstname>' '<lastname>' saved to the profile successfully
Examples:
| firstname		| lastname		|
| Test1			| Data1			|
		
Scenario Outline:3 Add/Edit the availability to the profile
		Given I logged into the mars successfully
		When I am in the profile page
		When I click the edit button near the availability
		And I select the availability to '<availability>'
		Then i could see the '<availability>' availability successfully
Examples:
| availability |
| Part Time    |

Scenario Outline:4 Add/Edit the hours to the profile
		Given I logged into the mars successfully
		When I am in the profile page
		When I Click the edit button near the hours
		When I select the hours to '<hours>'
		Then i could see the '<hours>' hours successfully
Examples:
| hours |
| As needed    |

Scenario Outline:5 Add/Edit the earn target to the profile
		Given I logged into the mars successfully
		When I am in the profile page
		When I Click the edit button near the earn target
		When I select the earn target  to '<earntarget>'
		Then i could see the '<earntarget>' earn target successfully
Examples:
| earntarget |
| More than $1000 per month    |