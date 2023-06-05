Feature: Language Feature

As a seller of the mars
I would like to add, edit and delete language in the profile
So that i could look into my details in the profile page successfully

@Language

Scenario Outline:1 Add language  to the profile
		Given I logged into the mars successfully
		When I am in the language tab
		When I clicked add new button in language tab
		When I entered the '<language>' '<languageLevel>' to add language
		And I clicked add button to add language
		Then the new '<language>''<languageLevel>' was successfully created

	 Examples:
    | language		| languageLevel			|
    |	Tamil		|	Native/Bilingual	|
    |	English		|	Fluent				|
	|	Hindi 		|	Conversational		|
	|	English		|	Conversational		|
	|	Marathi		|	Basic				|
	|	Urudu		|	Basic				|

Scenario Outline:2 Edit language from the profile
		Given I logged into the mars successfully
		When I am in the language tab
		When I click the edit button of the '<languageToBeEdited>' i want to edit
		When I entered the '<editLanguage>' '<editLanguageLevel>' to edit '<languageToBeEdited>' language
		And I clicked update button to edit language
		Then The language was successfully updated with '<editLanguage>''<editLanguageLevel>'
 Examples:
    | languageToBeEdited	| editLanguage	| editLanguageLevel |
    | Marathi				|   Malayalam   |   Basic           |

Scenario Outline:3 Delete language from his profile
		Given I logged into the mars successfully
		When I am in the language tab
		And I clicked delete button of the '<deleteLanguage>' i want to delete
		Then the '<deleteLanguage>' language was deleted successfully
 Examples:
    | deleteLanguage |
    |      Malayalam    |