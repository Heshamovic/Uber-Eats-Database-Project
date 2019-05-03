Uber Eats Project is a 3rd Year Fcis Students database team project (Desktop C# Application) like Uber Eats.

You will find two SQL Worksheets, the first named "Uber Eats Procedures" contains all the procedures used in the project. The second named "Uber Eats Tables" contains the script for the database tables.

The projcet may not run from visual studio due to different versions of .Net Framework so please follow these steps if your oracle connection shows an error when you start run althogh it is working correctly.

1-From project select Manage NUGet Packages 

2- Uninstall the following with same order listed

    a) Oracle.ManagedDataAccess.EntityFramework
    b) Oracle.ManagedDataAccess
    c) EntityFramework
3- Restart Visual Studio

4- install the following with same order listed

    a) EntityFramework (6.2.0)
    b) Oracle.ManagedDataAccess (18.6.0)
    c) Oracle.ManagedDataAccess.EntityFramework (18.3.0)
5- Open Project folder -> bin -> debug

6- Right click on Uber Eats Database Project.exe the open it with any xml viewer

7- Remove the section tag which has oracle.managedDataAccess you'll find this section inside configSections tag inside configuration tag

8- Save the file

9- Run the project

                                                                Description
Uber Eats  is an online food ordering and delivery platform that has hundreds of restaurants to choose from.  The application detects the user's location and displays restaurants open at the time separately from those that are closed.  Users can read the menu, order, and pay for food from participating restaurants using the application. When users open the application, they can scroll through the feed for inspiration or search for a particular restaurant or cuisine. 
The restaurants are classified either by prices, location or cuisine type. Each restaurant has its own top dishes and its own rating. Restaurants may also offer a discount on any type of food. When users find something that they like, they can tap to add it to their cart. Upon ordering, the user is notified of the total price combining delivery fee and meal price calculated from all food price minus discount on each food item. Delivery fees is calculated by the consumption of vehicle fuel multiply trip distance plus application constant fee. Users additionally have the option of giving a tip for delivery. Meals are delivered by couriers using cars, bikes, or on foot. Users can track the delivery status after the order is placed. Users can sign up to deliver food orders for Uber Eats using their car, bike, scooter, or on foot. Delivery partners earn money for each delivery trip based on number of trips and the distance between the restaurant and the dropoff location. Payment method is either cash or visa. If the payment is done by visa, check the User’s credit if it’s valid or not. The User can either cancel or edit the order within 15 minutes of ordering. User can get vouchers to a restaurant on a specific food with a specific amount.


