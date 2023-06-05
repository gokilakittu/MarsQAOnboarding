Feature: Task1 Feature

As a seller of the mars
I would like to add more deatils to the profile
So that i could look into my details in the profile page successfully

@SellerProfile

Scenario: 1 Seller adds Description to his profile
		Given I logged into the mars successfully
		When I am click on the edit button near the description
		And I entered the description 
		And I clicked save button
		Then I could see the newly added description successfully
				
Scenario: 2 Seller edits the First name and the Last Name to his profile
		Given I logged into the mars successfully
		When I am click on the profile name on the right of the screen
		When I see my firstName and lastName
		And I edit my firstName and lastName
		And I clicked save button
		Then I could see the updated names successfully

Scenario: 3 Seller adds availability to his profile
		Given I logged into the mars successfully
		When I am click on the edit button near the availability
		And I select the availability
		Then I could see the newly added availability successfully

Scenario: 4 Seller adds hours to his profile
		Given I logged into the mars successfully
		When I am click on the edit button near the hours
		And I select the hours 
		Then I could see the newly added hours successfully

Scenario: 5 Seller adds Earn target to his profile
		Given I logged into the mars successfully
		When I am click on the edit button near the earn target
		And I select the target
		Then I could see the newly added earn target successfully

Scenario:6 Add language  to the profile
		Given I logged into the mars successfully
		When I am in the language tab
		When I clicked add new button in language tab
		When I entered the language languageLevel to add language
		And I clicked add button to add language
		Then the new language languageLevel was successfully created


Scenario:7 Edit language from the profile
		Given I logged into the mars successfully
		When I am in the language tab
		When I click the edit button of the language i want to edit
		When I entered the language languageLevel to edit language
		And I clicked update button to edit language
		Then The language was successfully updated with language languageLevel


Scenario:8 Delete language from his profile
		Given I logged into the mars successfully
		When I am in the language tab
		And I clicked delete button of the deleteLanguage i want to delete
		Then the deleteLanguage language was deleted successfully


Scenario:9 Seller adds skill details to his profile
		Given I logged into the mars successfully
		When I am in the skill tab
		When I clicked add new button in skill tab
		When I entered the skill skillLevel to add skill
		And clicked add button
		Then the new skills was added successfully
	
Scenario:10 Seller edits skill details from his profile
		Given I logged into the mars successfully
		When I am in the skill tab
		When i click the edit button of the Skill i want to edit
		And I entered the Skill SkillLevel to update skill 
		And I clicked update button to update skill
		Then the skill was successfully updated

Scenario:11 Seller deletes skill details from his profile	
		Given I logged into the mars successfully
		When I am in the skill tab
		And I clicked delete button of the skill i want to delete
		Then the new skills was deleted successfully

Scenario Outline:12 Seller adds education details to his profile
		Given I logged into the mars successfully
		When I am in the education tab
		When I clicked add new button in education tab
		And I entered the '<country>' '<university>' '<title>' '<degree>' '<graduationYear>'
		And I clicked add button to add education
		Then the new Education was added successfully

Scenario Outline:13 Seller edits education details from his profile
		Given I logged into the mars successfully
		When I am in the education tab
		When i click the edit button of the <editTitle> i want to edit
		And I entered the <newCountry> <newUniversity> <newTitle>  <newDegree>  <newGraduationYear>
		And I clicked update button to update education
		Then the education was successfully updated

Scenario Outline:14 Seller deletes education details from his profile
		Given I logged into the mars successfully
		When I am in the education tab
		And I clicked delete button of the <deleteTitle> i want to delete
		Then the  education was deleted successfully

Scenario Outline:15 Seller adds certificate details to his profile
		Given I logged into the mars successfully
		When I am in the certificate tab
		When I clicked add new button in certificate tab
		And I entered the <certificate> <from> <year> to add certificate
		And I clicked add button to add certificate
		Then the new certificate was added successfully
	
Scenario Outline:16 Seller edits certificate details from his profile
		Given I logged into the mars successfully
		When I am in the education tab
		When i click the edit button of the <editTitle> i want to edit
		And I entered the <newCertificate> <newFrom> <newYear> to update certificate
		And I clicked update button to update certificate
		Then the education was successfully updated

Scenario Outline:17 Seller deletes certificate details from his profile
		Given I logged into the mars successfully
		When I am in the certificate tab
		And I clicked delete button of the <Certificate> i want to delete
		Then the  certificate was deleted successfully