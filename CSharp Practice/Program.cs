// See https://aka.ms/new-console-template for more information
using System.Text;
using CSharp_Practice;

// Handy things to know:
// - Console.WriteLine will print text to the console, can be used similarly to Console.log in js.
// - Console.ReadLine will be our way to save user input to a variable. 
// - Strings in C# unlike javascript can only exist in double quotes ("").
// - If you are using Visual Studio there is a play button to run the program, otherwise if you are using Visual Studio Code, use `dotnet run` in the terminal to run the program.

// What I have provided:
// - csv with 100 records of data.
// - Utility file to help display the data.
// - Belief you can do this!
// - Help at any point, you can either message me or looking at a working example at https://github.com/Tweemo/CSV-Practice

static void DisplayCSV()
{
// Task 1: Display each record in the provided csv file.
// Do this by using the StreamReader Class
// see https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-8.0 for StreamReader documentation.
    var filepath = ""; // Copy path from provided csv.
}

try
{
    DisplayCSV();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



// As a user I would like to be able to choose which csv file to read.
// Task 2: Using Console.ReadLine and Console.WriteLine create an interface that allows users to input their own filepath.



// Task 3: Create a function that generates a csv file of any number of records.
// Hint: Consider what a csv is in simple terms.

// StringBuilder Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0
// Random Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
// Use the File Class to save the file: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-8.0

// These values are just an example. Add or remove any fields you like, get creative with it.
string[] firstNames = ["John", "James", "Michael", "Robert", "David", "Mary", "Patricia", "Jennifer", "Linda", "Susan"];
string[] lastNames = ["Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Wilson", "Thomas"];
string[] hairColours = ["black", "blonde", "ginger", "brown", "grey", "white", "blue"];
string[] eyeColours = ["blue", "brown", "green", "hazel"];
int age;



// Task 4: Now that we have another function in the program lets add an additional option to our interface to let us use this functionality.



// At this stage we should have a program that let's us either create or display a csv. 
// BUT! I want to be able to create a csv then read it without running the program twice. 
// Task 5: Create a loop that allows for this functionality. 



// EXTRA CREDIT:
// - Adding validation to allow the program to handle incorrect values that can break the program. 
// - Refactor as much as you can. 