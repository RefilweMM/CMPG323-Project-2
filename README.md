# CMPG323-Project-2
In this project,I'm requiredd to create a CRUD RESTful API as part of the EcoPower Logistics project that will connect to a database storing basic logistics data. The API should contain at least one get, post, patch and delete method per resource – aligning to the project's requirements. The API will be created using visual studio .NET core and will be tested using Swagger

# How to test the API

Step 1: Go to this url - https://proj2api20230831022147.azurewebsites.net/index.html<br/>

Step 2: Register a user first(if you are not registered yet) by clicking the arrow on the far right of the "Post/api/Authenticate/register" endpoint under _Authenticate_. Add your custome username and password and click on execute.

Step 3: Once you're registered your details, you need to login. You do this by clicking the arrow on the right of the "Post/api/Authenticate/login" endpoint under _Authenticate_ and click on "try it out".

Step 4: Login with your registered details. The will be a white box with heading "Response body", login w the account details that you registered with in step 1. 

Step 5: Click the blue "Execute" button

Step 6: Under "Responses" the "Sever response" will return a token.

Step 7: Copy the token from after the open quotes till just before to close quotes. Example of what you copied must look something like this:

eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZmlmaSIsImp0aSI6ImI2NmM5M2YzLTdhN2MtNGUyYi04ZTc5LTdkMjkxOWM1MWNhMSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjoxNjYyNjU3NTAxLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjYxOTU1IiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.Co8MyT3ESa46KrI-TE71dBuQ_SteaShNTHa3XAfVRU8

Step 8: Authorize by clicking the _Authorize_ button at the top right corner. Type "Bearer" in the box and copy the token from the previous step, then click login, and close.

Step 9: Now test the endpoints by scrolling down to "Customers" and click the arrow on the right "Get/api/Customers" and click "try it out". Then "Execute".
If you scroll down to "server response" you should see a list of all customers.

NB!!! If you have been authenticated, the gray lock needs to be black and locked. This applies for all the other methods.

Step 10: Test the rest of the API endppoints in a similar manner.

**HOWEVER**, when tesing APIs that requires you to POST, PUT or PATCH, you want to ensure that you first GET ALL records for that specific record to see what attributes encompasses that resource. From there, you will delete everything in the response body that does not contain the attributes that are contained within this resource. 

Example:

<img src="https://github.com/RefilweMM/CMPG323-Project2-36787426/blob/main/Customer1.jpg" width="750" height="500" alt="Flowers in Chania">

You will see that the attributes for this resource are customerID, Title, Name, Surname, and Cellphone.

From there you, you will see that whenever you want to run the e.g the PUT endpoint. you will see this screen after pressing "try it out":

<img src="https://github.com/RefilweMM/CMPG323-Project2-36787426/blob/main/Customer2.jpg" width="750" height="500" alt="Flowers in Chania">

You will then delete everything after cellPhone including the last comma after "cellPhone" until you have this: 

<img src="https://github.com/RefilweMM/CMPG323-Project2-36787426/blob/main/Customer3.jpg" width="750" height="500" alt="Flowers in Chania">

From there, you will be able to PUT, POST, or PATCH.

Therefore, whenever you run the 3 above mentioned endpoints, you need to ensure that you get ALL records from that resource and delete additional attributes in your request body so that it matches with the attributes that have values in your resource.

You also wnat to ensure that the ID you enter in the textbox matches the ID you type in your request body. 
Example:
<img src="https://github.com/RefilweMM/CMPG323-Project2-36787426/blob/main/Cutomer4.jpg" width="750" height="500" alt="Flowers in Chania">


