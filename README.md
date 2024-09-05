# ASP.NET Interview

## Goal: Build the backend to a task management app

### Acceptance Criteria:

- unit test your work
- create a database class called "User" with the following columns
  - first_name
  - email
  - password
- create a database class called "Task" with the following columns
  - id
  - title, String
  - created_on, Datetime
  - completed, Bool
  - completed_on, Datetime
  - user, User
- Create an endpoint that allows for the creation of a new task
  - Should require a logged in User
  - should create the database object
  - return the created task
- Create an endpoint that marks the task as complete
  - Should require a logged in User
  - mark completed as true
- Create an endpoint that marks the task as incomplete
  - Should require a logged in User
  - mark completed as false
- Create an endpoint that deletes the task
- Create an endpoint that fetches all tasks for a given user
