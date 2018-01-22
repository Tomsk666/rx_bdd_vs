Feature: NewEntries
	In order to create entries
	As a KeePass user
	I want to be able to add, delete and edit entries


Scenario: Add User
	Given That I am logged in to KeePass
	When i add an entry to the 'Windows' category
	Then the entry should be listed in the main table

