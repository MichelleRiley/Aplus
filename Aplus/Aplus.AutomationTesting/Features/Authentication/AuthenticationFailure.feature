﻿Feature: AuthenticationFailure
	As a user
	I want my credentials authenticated
	So that the website can identify me

Scenario: Invalid login displays validation message
	Given the login form contains invalid email and invalid password
	When I submit the login form
	Then a validation message is displayed "Invalid login attempt."