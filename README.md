# T&G-Case
Case study listing products by category. Developed with ASP.Net API, ASP.Net MVC, JQuery.

1-Server name will be updated from appsettings.json in MiniETrade.Service

2-MiniETrade.Service - Set as Startup Project

3-From the Tools tab NuGet Package Manager from Package Manager Console
a-Default project-MiniETrade.Dal
b-Update-Database

4-After running the project right click on MiniETrade.UI
a-Debug - Start New Instance

<img src="https://user-images.githubusercontent.com/107270736/216539851-bdaa5559-2a6a-4d16-9c93-6052c4d5a00c.png"></img>


o How you make a JS async call to an URL within the same application handled by a
backend controller
-In my example it uses the $.ajax method from jQuery to perform a GET request to the specified URL.
The success function is called with the response data if the request is successful, and the error function with an error if the request fails.
With asynchronous programming, the request is made in the background, allowing the user to continue interacting with the page while the request is in progress.

o How you’ve structured your solution from a N-Layer perspective
Entities Layer & Dal Layer: First, I created my required entities in the Entity layer.
Then I came to the Dal layer and created Context and connected it to the database with Entity framework.
I associated the tables and classes in the database with dbset
Core Layer: I performed basic Crud operations in the Core layer
Repository Layer:Repository Layer is abstracting the data access layer and providing a more flexible and maintainable design for database interactions in software applications.
Unit of work Layer:I keep all the operations to be done with the database via interfaces in a unit of work class.
In this way, I ensure that transactions are performed in batches and can be rolled back in case of error.
Service Layer:Service layer, UI layer and data access layer.It provides an abstraction layer between
Presentation-UI Layer:This is the layer the user interacts with. The layer where I code the UI and user input

The reason I use a layered architecture is because it provides a software development framework that helps build maintainable, testable, scalable and reusable applications.

o How your data model is implemented (USE CODE-FIRST approach if possible)
After I create my classes and make the associations, I add migration, edit if there is any place that needs to be edited in the migration and update my database.
