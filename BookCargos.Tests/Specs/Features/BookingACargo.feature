Feature: BookingACargo
	In order to send a cargo on a route
	As a cargo owner
	I want to book a cargo on a vessel

Scenario: booking a cargo on a vessel with enough capacity left
	Given a vessel with 2000 cubic feet capacity
	And a cargo of 50 cubic feet in size
	When I book the cargo on the vessel
	Then the vessel will transport the cargo
	And I received a booking confirmation with a number

#Scenario: booking a cargo on a vessel without enough capacity left
#	Given a vessel with 2000 cubic feet capacity
#	And the vessel has been booked for a total of 1800 cubic feet
#	And a cargo of 50 cubic feet in size
#	When I book the cargo on the vessel
#	Then the vessel doesn't accept the cargo
#	And I received a notification for missing capacity on the vessel
