Feature: Task1 Feature

As a seller of the mars portal
I would like to add more details to the profile
So that i could look into my details in the profile page successfully

Background: 
Given I logged into the mars portal successfully

@SellerProfile 
Scenario Outline: 1 Seller adds Description to his profile
When I click on the edit button near the description
And I enter the '<description>'
Then I could see the newly added '<description>' successfully
Examples:
|description		|
|Something about me	|

@ignore @negativeTestcase
Scenario Outline: 2 Seller adds Description with more characters to his profile
When I click on the edit button near the description
And I enter the '<descriptionWithMoreCharacters>'
Then I could see the partial text of the description with showing any error message
Examples:
| descriptionWithMoreCharacters |
#|When deciding where to put some common context, the key question should be “is this important for the purpose of the scenario, or just for the process of testing?”. This is the same question we explored in the challenge How to fix a chain of dependent scenarios? (see the section “Write set-up in a declarative way”).Tags and hooks are best to use for sharing context that’s not really important for the purpose of the test, but it may be important for how the test gets executed. For example, the actual username for the logged in user is not important for ratings, we just need to have a user and|
|When deciding where to put		|

@ignore @negativeTestcase
Scenario: 3 Seller saves description with empty values
When I click on the edit button near the description
And I clear the data in the description
Then an error message should appear for blank description

Scenario Outline: 4 Seller edits the First name and the Last Name to his profile
When I click on the profile name 
And I edit my '<firstName>' and '<lastName>'
Then I could see the updated '<firstName>' and '<lastName>' successfully
Examples:
|firstName |lastName |
|fname     |lname	 |  

@ignore @negativeTestcase
Scenario: 5  Seller edits the First name and the Last Name with empty names
When I click on the profile name
And I clear all the data
Then an error message should appear for blank names

@ignore @negativeTestcase
Scenario: 6  Seller adds only the firstname without the lastname
When I click on the profile name 
And I enter only the firstname 'firstname'
Then an error message should appear for blank names

@ignore @negativeTestcase
Scenario: 7  Seller adds only the lastname without the firstname
When I click on the profile name
And I enter only the lastname 'lastname'
Then an error message should appear for blank names

Scenario Outline: 8 Seller adds availability to his profile
When I click on the edit button near the availability
And I select the availability '<availability>'
Then I could see the newly added '<availability>' availability successfully
Examples:
|availability |
|Part Time    |

Scenario Outline: 9 Seller adds hours to his profile
When I click on the edit button near the hours
And I select the hours '<hours>' 
Then I could see the newly added '<hours>' hours successfully
Examples:
|hours		|
|As needed	|

Scenario Outline: 10 Seller adds Earn target to his profile
When I click on the edit button near the earn target
And I select the  earntarget '<earntarget>'
Then I could see the newly added '<earntarget>' earn target successfully
Examples:
|earntarget					|
|More than $1000 per month  |

Scenario Outline: 11 Add language to the profile
When I click add new button in language tab
And I enter the '<language>' '<languageLevel>' to add language
Then The new language '<language>''<languageLevel>' was successfully created
 Examples:
| language | languageLevel    |
| Tamil    | Native/Bilingual |
| English  | Fluent           |
| Hindi    | Conversational   |
| English  | Conversational   |
| Marathi  | Basic            |
| Urudu    | Basic            |

@ignore @negativeTestcase
Scenario: 12 Seller trying to add empty language to the profile
When I click add new button in language tab
And I click add button to add language
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 13 Seller trying to add just language level without language to the profile
When I click add new button in language tab
And I select 'Native/Bilingual' in the language level
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 14 Seller trying to add just language without language level to the profile
When I click add new button in language tab
And I select 'French' in the language 
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 15 Seller trying to add language that was already exists
When I click add new button in language tab
And I select 'Tamil' 'Native/Bilingual' 
Then an error message should appear for data already exists

@ignore @negativeTestcase
Scenario: 16 Seller trying to add language that was already exists with differnt language level
When I click add new button in language tab
And I select 'Tamil' 'Fluent' to add the language 
Then an error message should appear for duplicate values

Scenario Outline: 17 Edit language from the profile
When I edit '<languageToBeEdited>' with '<editLanguage>' '<editLanguageLevel>' to update language
Then The language was successfully updated with '<editLanguage>''<editLanguageLevel>'
Examples:
|languageToBeEdited	|editLanguage|editLanguageLevel |
|Marathi			|Malayalam   |Basic				|

Scenario Outline: 18 Delete language from his profile
When I click delete button of the '<deleteLanguage>' language i want to delete
Then The '<deleteLanguage>' language was deleted successfully
Examples:
|deleteLanguage |
|Malayalam		|

Scenario Outline: 19 Seller adds skill details to his profile
When I am in the skill tab
And I enter the '<skill>' '<skillLevel>' to add the skill
Then The new '<skill>''<skillLevel>' was successfully created
Examples:
|skill	|skillLevel	|
|JMeter	|Beginner	|

@ignore @negativeTestcase
Scenario: 20 Seller trying to add empty skill to the profile
When I am in the skill tab
And I click add button to add skill
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 21 Seller trying to add just skill level without skill to the profile
When I am in the skill tab
And I select 'Beginner' in the skill level
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 22 Seller trying to add just skill without skill level to the profile
When I am in the skill tab
And I select 'Postman' in the skill 
Then an error message should appear for empty values

@ignore @negativeTestcase
Scenario: 23 Seller trying to add skill that was already exists
When I am in the skill tab
And I select 'C++' 'Beginner' 
Then an error message should appear for data already exist
 
@ignore @negativeTestcase
Scenario: 24 Seller trying to add skill that was already exists with differnt skill level
When I am in the skill tab
And I select 'C++' 'Intermediate' to add the skill 
Then an error message should appear for duplicate values

Scenario Outline: 25 Seller edits skill details from his profile
When I am in the skill tab
And I update '<skillToBeEdited>' with '<editSkill>' '<editSkillLevel>' to update skill
Then The skill was successfully updated with '<editSkill>''<editSkillLevel>'
Examples:
|skillToBeEdited	|editSkill	|editSkillLevel	|
|JMeter				|Java		|Beginner		| 

Scenario Outline: 26 Seller deletes skill details from his profile	
When I am in the skill tab
And I click delete button of the skill '<deleteSkill>' i want to delete
Then the '<deleteSkill>' skill was deleted successfully
Examples:
|deleteSkill|
|Java		|

@ignore
Scenario Outline: 27 Seller adds education details to his profile
When I am in the education tab
And I enter the '<country>' '<university>' '<title>' '<degree>' '<graduationYear>'
Then The new Education was added successfully
Examples:
|country|university				|title	|degree	|graduationYear	|
|NZ     |University of Auckland	|MSc	|MSc    |2010           |

@ignore
Scenario Outline: 28 Seller edits education details from his profile
When I am in the education tab
And I update 'editDegree>' with '<newCountry>' '<newUniversity>' '<newTitle>' '<newDegree>' '<newGraduationYear>'
Then The education was successfully updated
Examples:
|editDegree |newCountry  |newUniversity      |newTitle	|newDegree |newGraduationYear |
|MSc        |New Zealand |Lincoln University |BSc	    |BSc       |2009              |

@ignore
Scenario Outline: 29 Seller deletes education details from his profile
When I am in the education tab
And I click delete button of the degree '<deleteDegree>' i want to delete
Then The  education was deleted successfully
Examples:	
|deleteDegree	|
|BSc			|

@ignore
Scenario Outline: 30 Seller adds certificate details to his profile
When I am in the certificate tab
And I enter the '<certificate>' '<from>' '<year>' to add certificate
Then The new certificate was added successfully
Examples:
|certificate		|from	|year	|
|ISTQB-Foundation   |2020	|2021	|

@ignore
Scenario Outline: 31 Seller edits certificate details from his profile
When I am in the certificate tab
And I update '<certificate>' with '<newCertificate>' '<newFrom>' '<newYear>'
Then The certificate was successfully updated
Examples:
|certificate		|newCertificate |newFrom	|newYear	|
|ISTQB-Foundation	|ISTQB-Agile	|2020       |2021       |

@ignore
Scenario Outline: 32 Seller deletes certificate details from his profile
When I am in the certificate tab
And I click delete button of the '<deleteCertificate>' i want to delete
Then The certificate was deleted successfully
Examples:	
|deleteCertificate	|
|ISTQB-Agile	    |

