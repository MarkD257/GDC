# GDC
The code for this project was constructed with some code borrowed from a PluralSight Dependency Injection course. I have worked on projects that used Unity for DI. I have only used Di with existing projects. With .Net Core, DI became a code standard but not with console applications. I used VS 2019 not VS Code.
 Players.csv is a test file.  
 
I added the Directory Search feature as a last item after double-checking the requirement. Test file copied to bin folder. Okay, not really a "search" technically , because a real search would be a recursive function. I am sure that is out on Google somewhere.  
 
Technical Assignment

1.	Develop a solution based upon the requirements and details below.
2.	When completed, check the code into your repository of choice (GitHub tends to be the most popular).
3.	Submit the link to the repository back to your recruiter.

Application Requirements
1.	Create a .NET console application that:
a.	Prompts user for a file name.
b.	Searches directory for a .csv file with that name.
c.	Parse CSV File
i.	If the file exists, iterate through each row and validate that the email address is valid syntax.
1.	Track separate lists for valid and invalid email addresses. (e.g. test@gdcit.com is valid,  test@gmail is not valid)
ii.	If the file does not exist, return an error message to the user.
d.	Output the lists of valid and invalid email addresses found.
2.	Use a DI Container library to register and scope your objects. Whichever library you prefer is fine. (e.g. Microsoft Extensions, Simple Inject, Ninject, etc. )
3.	Implement some unit testing for your application’s core functionality.
a.	Not looking for complete code coverage, just enough to cover the business logic basics.


Other Details
1.	CSV File Structure
a.	Fields in the CSV file should be First Name, Last Name, Email Address
2.	.NET Starting Point
a.	https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code

