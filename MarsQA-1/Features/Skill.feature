Feature: Skill Feature

As a seller of the mars
I would like to add, edit and delete skill in the profile
So that i could look into my details in the profile page successfully

@Skill

Scenario Outline:1 Add skill  to the profile
		Given I logged into the mars successfully
		When I am in the skill tab
		When I clicked add new button in skill tab
		When I entered the '<skill>' '<skillLevel>' to add skill
		And I clicked add button to add skill
		Then The new '<skill>''<skillLevel>' was successfully created

	 Examples:
    | skill				| skillLevel			|
	|C++				|	Beginner			|
	|C#					|	Intermediate		|
	|Selenium WebDriver	|	Expert				|
	|Postman			|	Beginner			|
	|JMeter				|	Beginner			|
	|JMeter				|	Expert				|

   
Scenario Outline:2 Edit skill from the profile
		Given I logged into the mars successfully
		When I am in the skill tab
		When I click the edit button of the '<skillToBeEdited>' skill i want to edit
		When I entered the '<editSkill>' '<editSkillLevel>' to edit '<skillToBeEdited>' skill
		And I clicked update button to edit skill
		Then The skill was successfully updated with '<editSkill>''<editSkillLevel>'
 Examples:
    | skillToBeEdited	| editSkill		| editSkillLevel|
    |JMeter				|	Java		|	Beginner	| 

Scenario Outline:3 Delete skill from his profile
		Given I logged into the mars successfully
		When I am in the skill tab
		And I clicked delete button of the skill '<deleteSkill>' i want to delete
		Then the '<deleteSkill>' skill was deleted successfully
 Examples:
    | deleteSkill	|
    |	Java		|