# SQLite-Project

- This is asp.net core mvc project
- First run the code in visual studio
- So goes to Home controller Index action
- And from that action it first go to a service which create the database if not created yet in SQLite and create table from there based on the credentials
- After successfull creation it back to action and execute the api by using restclient and execute
- and the response is deserialized and is save to a model that named as salesResponse with 2 field success and record
- if success then read the record from api to salesData model
- and after that the list of response is read one by one and added to database
