# ASP.NET Interview

## Goal: Build the backend to a task management app

### Acceptance Criteria:

- unit test your work
- create a database class called "User" with the following columns
  - firstName
  - email
  - password
- create a database class called "TaskItem" with the following columns
  - id
  - title, String
  - createdOn, Datetime
  - completed, Bool
  - completedOn, Datetime
  - user, User
- Create a login endpoint that logs a user in if username and password are correct
- Create an endpoint that allows for the creation of a new task
  - Should require a logged in User
  - should create the database object
  - automatically assign "user" to the logged in user
  - return the created task
- Create an endpoint that marks the task as complete
  - Should require a logged in User
  - mark completed as true
- Create an endpoint that marks the task as incomplete
  - Should require a logged in User
  - mark completed as false
- Create an endpoint that deletes the task
- Create an endpoint that fetches all tasks for a given user
  - use authentication to pick user
