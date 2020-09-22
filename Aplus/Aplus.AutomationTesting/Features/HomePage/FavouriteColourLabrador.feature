Feature: FavouriteColourLabrador
	As a user 
	I want to select my favourite colour labrador
	So that...

Scenario: Homepage page displays favourite colour labrador dropdown
	Given the I am on the homepage
	Then the favourite colour labrador dropdown is displayed

Scenario: Favourite colour labrador dropdown contains colours
	Given the I am on the homepage
	Then the favourite colour labrador dropdown contains colours

	| colour    |
	| Black     |
	| Yellow    |
	| Chocolate |