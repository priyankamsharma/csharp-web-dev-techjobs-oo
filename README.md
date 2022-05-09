# csharp-web-dev-techjobs-oo
Assignment #2: Tech Jobs (Object-Oriented Edition)
Learning Objectives

Read and understand code written by others.
Work with objects to encapsulate data and methods.
Use the generator in Visual Studio to automate routine tasks.
Use unit testing and Test-Driven-Development (TDD) to verify and create new methods.
Apply the concept of inheritance to streamline your classes (the DRY idea—Don’t Repeat Yourself).
Get the Starter Code
Set up a local copy of the project. Visit the repository page for this project and fork the repo to create a copy in your own GitHub account.
Open Visual Studio.
If the app opens up to an existing project, close it.
From the Visual Studio dialog box, open your copy of the starter code.
TechJobs (Object-Oriented Edition)

Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.
Complete the Job class.
Use unit testing to verify the constructors and Equals() methods for the Job class.
Use TDD to design and code a custom ToString() method for the Job class.
Use inheritance to DRY the code within Employer, Location, CoreCompetency, and PositionType.
Explore the Employer Class

Assign a Unique ID
TODO comment with instructions for coding a second constructor:

It should call the first constructor to initialize the id field.
It must also initialize the value field for a new Location object.
The CoreCompetency Class
Open the class file. In this case, the constructors and custom methods are ready. Change the id and value fields to auto-implemented properties, but NOT nextId.

The PositionType Class
Open the class file and add the custom methods.

Code a ToString() method that just returns the value of a PositionType object.
Use the Generate option again to add the Equals() and GetHashCode() methods.

Complete the Job Class
Now open the Job file. OOF! There are a lot of fields and properties declared and not much else.

Code a constructor to initialize the id field with a unique value. This constructor should take no parameters.
Code a second constructor that takes 5 parameters and assigns values to name, employerName, employerLocation, jobType, and jobCoreCompetency. Also, this constructor should call the first in order to initialize the id field.
Generate the Equals() and GetHashCode() methods. Consider two Job objects equal when their id fields match.

Use Unit Testing to Verify Parts of the Job Class
Create a new project inside the TechJobsOO solution called TechJobsTests, then rename the existing class inside this folder to JobTests.cs. Add the appropriate dependency to TechJobsTests to test the classes in the TechJobsOO project. The JobTests.cs file will hold all of the tests for the Job class.

Test the Empty Constructor
Each Job object should contain a unique ID number, and these should also be sequential integers.

In JobTests, define a test called TestSettingJobId.

Create two Job objects using the empty constructor. Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1.

Run the test to verify that your Job() constructor correctly assigns ID numbers.

Test the Full Constructor
Each Job object should contain six properties—Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency.

In JobTest, define a test called TestJobConstructorSetsAllFields.
Declare and initialize a new Job object with the following data: "Product tester" for Name, "ACME" for EmployerName, "Desert" for JobLocation, "Quality control" for JobType, and "Persistence" for JobCoreCompetency.
Use Assert statements to test that the constructor correctly assigns the value of each field.
Test the Equals() Method
Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ. Similarly, the two objects are NOT equal if their id values differ, even if all the other fields are identical.

In JobTest, define a test called TestJobsForEquality.
Generate two Job objects that have identical field values EXCEPT for id. Test that Equals() returns false.
It might seem logical to follow up the false case by testing to make sure that Equals() returns true when two objects have the same ID. However, the positive test is irrelevant in this case.

The way you built your Job class, each id field gets assigned a unique value, and the class does not contain a setter for the id field. You also verified that each new object gets a different ID when you tested the constructors. Without modifying the constructors or adding a setter, there is no scenario in which two different jobs will have the same ID number. Thus, we can skip the test for this condition.

Use TDD to Build The ToString() Method
To display the data for a particular Job object, you need to implement a custom ToString() method. Rather than creating this method and then testing it, you will flip that process using TDD.

Create First Test for ToString()
Before writing your first test, consider how we want the method to behave:

When passed a Job object, it should return a string that contains a blank line before and after the job information.

The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.

ID:  _______
Name: _______
Employer: _______
Location: _______
Position Type: _______
Core Competency: _______
If a field is empty, the method should add, “Data not available” after the label.

Finish the TDD for ToString()
Code a new test for the second required behavior, then run the tests to make sure the new one fails.
Modify ToString() to make the new test pass. Also, make sure that your updates still pass all of the old tests.

Create a new class called JobField.Finally, to prevent the creation of a JobField object, make this class abstract.
Extend JobField into Employer. Now that you have the common code located in the JobField file, we can modify the other classes to reference this shared code. 

Provided are some commented-out code in Program.cs that prints out a small list of Job objects. Go ahead and activate this code and run it. Properly done, your output should look something like:

ID: 1
Name: Product tester
Employer: ACME
Location: Desert
Position Type: Quality control
Core Competency: Persistence


ID: 2
Name: Web Developer
Employer: LaunchCode
Location: St. Louis
Position Type: Front-end developer
Core Competency: JavaScript


ID: 3
Name: Ice cream tester
Employer: Data not available
Location: Home
Position Type: UX
Core Competency: Tasting ability
