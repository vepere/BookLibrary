Feature: BookLibrary Api Tests

Background: 
	Given User is created with the following fields:
	| username   | emailAddress         | password      |
	| testuser_1 | testuser_1@yahoo.com | 1234241412412 |

@POST
Scenario: Verify the POST method on the Books endpoint
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200

@POST
Scenario: Verify Posting a book without a title
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title | Publisher | ReleaseDate |
	|       | Humanitas | 1850        |
	Then Verify The book is not and status code received is 400

@POST
Scenario: Verify Posting a book without an author
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	When I post a book without author
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is not saved and status code received is 500

@GET
Scenario: Verify a posted book can be retrieved successfully
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And The book can be retrieved successfully by First Name: Ion and Last Name: Creanga
	And Verify book data is returned correctly

@GETbyId
Scenario: Verify a posted book can be retrieved successfully by id
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And Save the Book Id
	And The book can be retrieved successfully by bookId
	And Verify book data is returned correctly

@GET
Scenario: Verify that posted book cannot be retrieved by first name only
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And The book can be retrieved successfully by firstname: Ion
	And Verify book data is not returned

@DELETE
Scenario: Verify you can successfully delete a posted book
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And Save the Book Id
	When I delete the book by the book id
	Then Verify the book was deleted
@DELETE
Scenario: Verify you cannot delete a book that doesn't exist
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	When I delete the book by the book id
	Then Verify the book was not deleted
	
@PUT
Scenario: Verify you can update a posted book
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And Save the Book Id
	When I update a book
	| Title        | Publisher         | ReleaseDate |
	| UpdatedTitle | Updated Publisher | 1850        |
	Then I verify the book is updated

@PUT
Scenario: Verify that you cannot update a non existing book
	Given User is logged in
	| emailAddress         | password      |
	| testuser_1@yahoo.com | 1234241412412 |
	And The Author
	| FirstName | LastName | DateOfBirth              |
	| Ion       | Creanga  | 2022-07-08T11:57:36.907Z |
	When I post a book
	| Title              | Publisher | ReleaseDate |
	| Capra cu Trei Iezi | Humanitas | 1850        |
	Then Verify The book is saved and status code received is 200
	And Save the Book Id
	When I update a book without authToken
	| Title        | Publisher         | ReleaseDate |
	| UpdatedTitle | Updated Publisher | 1850        |
	Then Verify the book is not updated