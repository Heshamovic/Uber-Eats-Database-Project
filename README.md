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

