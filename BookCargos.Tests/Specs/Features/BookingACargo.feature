Feature: BookingACargo
	In order to send a cargo on a route
	As a cargo owner
	I want to book a cargo on a vessel

Scenario: booking a cargo on a vessel with enough capacity left
	Given a vessel with 1000 cubic feet capacity
	And the vessel is empty
	When I book a cargo of 100 cubic feet
	Then the cargo is added to the vessel
	And I receive a booking confirmation

Scenario: booking a cargo on a vessel without enough capacity left
	Given a vessel with 1000 cubic feet capacity
	And the vessel has 50 cubic feet left
	When I book a cargo of 100 cubic feet
	Then the cargo is not added to the vessel
	And I receive a notification that the vessel has not capacity