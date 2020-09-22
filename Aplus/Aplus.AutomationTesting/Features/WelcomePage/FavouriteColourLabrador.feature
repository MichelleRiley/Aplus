Feature: FavouriteColourLabrador
	As a user 
	I want to select my favourite colour labrador
	So that...

Scenario: Welcome page displays favourite colour labrador dropdown
	Given the I am on the welcome page
	Then the favourite colour labrador dropdown is displayed

Scenario: Favourite colour labrador dropdown contains colours
	Given the I am on the welcome page
	When I select the favourite colour labrador dropdown
	Then the list contains colours

	| colour    |
	| black     |
	| yellow    |
	| chocolate |