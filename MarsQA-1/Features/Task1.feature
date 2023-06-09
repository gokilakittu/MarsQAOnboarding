Feature: Task1 Feature

As a seller of the mars portal
I would like to add more deatils to the profile
So that i could look into my details in the profile page successfully

Background: 
		Given Launch the URL for Mars portal
		And I logged into the Mars portal 
		Then Profile page is displayed

@SellerProfile 
Scenario: 1 Seller adds Description to his profile
		Given I click on the edit button near the description
		When I enter the '<description>'
		And I click save button
		Then I could see the newly added '<description>' successfully
Examples:
    | description |
    | Something about me |

@ignore @negativeTestcase
Scenario: 2 Seller adds Description with more characters to his profile
		Given I click on the edit button near the description
		When I enter the '<descriptionWithMoreCharacters>'
		And I click save button
		Then I could see the partial text of the description with showing any error message
Examples:
    | descriptionWithMoreCharacters |
    | Something about me which has more than 599 characters |

@ignore @negativeTestcase
Scenario: 3 Seller saves description with empty values
		Given I click on the edit button near the description
		When I clear the data in the description
		And I click save button
		Then an error message should appear for blank description

Scenario: 4 Seller edits the First name and the Last Name to his profile
		Given I click on the profile name on the right of the screen
		When I see my firstName and lastName
		When I edit my '<firstName>' and '<lastName>'
		And I click save button
		Then I could see the updated names successfully
Examples:
    | firstName | lastName |
    | fname     |    lname |  

@ignore @negativeTestcase
Scenario: 5  Seller edits the First name and the Last Name with empty names
		Given I click on the profile name on the right of the screen
		When I see my firstName and lastName
		When I clear all the data
		And I click save button
		Then an error message should appear for blank names

@ignore @negativeTestcase
Scenario: 6  Seller adds only the firstname without the lastname
		Given I click on the profile name on the right of the screen
		When I see my firstName and lastName
		When I enter the 'firstname'
		And I click save button
		Then an error message should appear for blank names

@ignore @negativeTestcase
Scenario: 7  Seller adds only the lastname without the firstname
		Given I click on the profile name on the right of the screen
		When I see my firstName and lastName
		When I enter the 'lastname'
		And I click save button
		Then an error message should appear for blank names

Scenario: 8 Seller adds availability to his profile
		Given I click on the edit button near the availability
		When I select the '<availability>'
		Then I could see the newly added '<availability>' availability successfully
Examples:
| availability |
| Part Time    |

Scenario: 9 Seller adds hours to his profile
		Given I click on the edit button near the hours
		When I select the '<hours>' 
		Then I could see the newly added '<hours>' hours successfully
Examples:
	| hours |
	| As needed    |

Scenario: 10 Seller adds Earn target to his profile
		Given I click on the edit button near the earn target
		When I select the '<earntarget>'
		Then I could see the newly added earn target successfully
Examples:
| earntarget |
| More than $1000 per month    |

Scenario: 11 Add language to the profile
		Given I am in the language tab
		When I click add new button in language tab
		When I enter the '<language>' '<languageLevel>' to add language
		And I click add button to add language
		Then The new '<language>''<languageLevel>' was successfully created
Examples:
    | language		| languageLevel			|
    |	Tamil		|	Native/Bilingual	|

	
@ignore @negativeTestcase
Scenario: 12 Seller trying to add empty language to the profile
		Given I am in the language tab
		When I click add new button in language tab
		And I click add button to add language
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 13 Seller trying to add just language level without language to the profile
		Given I am in the language tab
		When I click add new button in language tab
		When I select 'Native/Bilingual' in the language level
		And I clicked add button to add language
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 14 Seller trying to add just language without language level to the profile
		Given I am in the language tab
		When I click add new button in language tab
		When I select 'French' in the language 
		And I click add button to add language
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 15 Seller trying to add language that was already exists
		Given I am in the language tab
		When I click add new button in language tab
		When I select 'Tamil' 'Native/Bilingual' to add the language
		And I click add button to add language
		Then an error message should appear for data already exists

@ignore @negativeTestcase
Scenario: 16 Seller trying to add language that was already exists with differnt language level
		Given I am in the language tab
		When I click add new button in language tab
		When I select 'Tamil' 'Fluent' to add the language 
		And I click add button to add language
		Then an error message should appear for duplicate values

Scenario: 17 Edit language from the profile
		Given I am in the language tab
		When I click the edit button of the '<languageToBeEdited>' i want to edit
		When I enter the '<editLanguage>' '<editLanguageLevel>' to edit '<languageToBeEdited>' language
		And I click update button to edit language
		Then The language was successfully updated with '<editLanguage>''<editLanguageLevel>'
 Examples:
    | languageToBeEdited	| editLanguage	| editLanguageLevel |
    | Marathi				|   Malayalam   |   Basic           |

Scenario: 18 Delete language from his profile
		Given I am in the language tab
		And I click delete button of the '<deleteLanguage>' i want to delete
		Then the '<deleteLanguage>' language was deleted successfully
 Examples:
    | deleteLanguage |
    | Malayalam    |

Scenario: 19 Seller adds skill details to his profile
		Given I am in the skill tab
		When I click add new button in skill tab
		When I enter the '<skill>' '<skillLevel>' to add skill
		And I click add button to add skill
		Then The new '<skill>''<skillLevel>' was successfully created

Examples:
    | skill				| skillLevel			|
	|C++				|	Beginner			|

@ignore @negativeTestcase
Scenario: 20 Seller trying to add empty skill to the profile
		Given I am in the skill tab
		When I click add new button in skill tab
		And I click add button to add skill
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 21 Seller trying to add just skill level without skill to the profile
		Given I am in the skill tab
		When I click add new button in skill tab
		When I select 'Beginner' in the skill level
		And I click add button to add skill
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 22 Seller trying to add just skill without skill level to the profile
		Given I am in the skill tab
		When I click add new button in skill tab
		When I select 'Postman' in the skill 
		And I click add button to add skill
		Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 23 Seller trying to add skill that was already exists
		Given I am in the skill tab
		When I click add new button in skill tab
		When I select 'C++' 'Beginner' to add the skill
		And I click add button to add skill
		Then an error message should appear for data already exist

@ignore @negativeTestcase
Scenario: 24 Seller trying to add skill that was already exists with differnt skill level
		Given I am in the skill tab
		When I click add new button in skill tab
		When I select 'C++' 'Intermediate' to add the skill 
		And I click add button to add skill
		Then an error message should appear for duplicate values

Scenario: 25 Seller edits skill details from his profile
		Given I am in the skill tab
		When I click the edit button of the '<skillToBeEdited>' skill i want to edit
		When I enter the '<editSkill>' '<editSkillLevel>' to edit '<skillToBeEdited>' skill
		And I click update button to edit skill
		Then The skill was successfully updated with '<editSkill>''<editSkillLevel>'
 Examples:
    | skillToBeEdited	| editSkill		| editSkillLevel|
    |JMeter				|	Java		|	Beginner	| 

Scenario: 26 Seller deletes skill details from his profile	
		Given I am in the skill tab
		And I click delete button of the skill '<deleteSkill>' i want to delete
		Then the '<deleteSkill>' skill was deleted successfully
 Examples:
    | deleteSkill	|
    |	Java		|

Scenario Outline: 27 Seller adds education details to his profile
		Given I am in the education tab
		When I click add new button in education tab
		When I enter the '<country>' '<university>' '<title>' '<degree>' '<graduationYear>'
		And I click add button to add education
		Then The new Education was added successfully
 Examples:
| country	| university						| title		| degree	| graduationYear	|
|   NZ      |       University of Auckland		|   MSc		|     MSc   |      2010         |

Scenario Outline: 28 Seller edits education details from his profile
		Given I am in the education tab
		When i click the edit button of the <editDegree> i want to edit
		When I enter the <newCountry> <newUniversity> <newTitle>  <newDegree>  <newGraduationYear>
		And I click update button to update education
		Then The education was successfully updated
 Examples:
 | editDegree | newCountry		| newUniversity      | newTitle		| newDegree | newGraduationYear |
 | MSc        |    New Zealand  | Lincoln University |   BSc		| BSc       |       2009            |

Scenario Outline: 29 Seller deletes education details from his profile
		Given I am in the education tab
		And I click delete button of the <deleteDegree> i want to delete
		Then The  education was deleted successfully
Examples:	
|deleteDegree	|
|		BSc		|

Scenario Outline: 30 Seller adds certificate details to his profile
		Given I am in the certificate tab
		When I click add new button in certificate tab
		When I enter the <certificate> <from> <year> to add certificate
		And I click add button to add certificate
		Then The new certificate was added successfully
Examples:
| certificate			| from		| year		|
|    ISTQB-Foundation   | 2020		|  2021		|

Scenario Outline: 31 Seller edits certificate details from his profile
		Given I am in the certificate tab
		When I click the edit button of the <certificate> i want to edit
		When I enter the <newCertificate> <newFrom> <newYear> to update certificate
		And I click update button to update certificate
		Then The certificate was successfully updated
Examples:
| certificate		| newCertificate	| newFrom	| newYear	|
| ISTQB-Foundation	| ISTQB-Agile		|2020       |2021       |

Scenario Outline: 32 Seller deletes certificate details from his profile
		Given I am in the certificate tab
		When I click delete button of the <deleteCertificate> i want to delete
		Then The certificate was deleted successfully
Examples:	
|deleteCertificate	|
|		ISTQB-Agile	|