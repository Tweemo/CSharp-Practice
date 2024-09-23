// See https://aka.ms/new-console-template for more information
using System.Text;
using CSharp_Practice;

// Task 1: Display each record in the provided csv file.
static void DisplayCSV()
{
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

// Task 2: Using Console.ReadLine and Console.WriteLine create an interface that allows users to input their own filepath.


// Task 3: Create a function that generates a csv file of any number of records.

// StringBuilder Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0
// Random Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
// File Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-8.0

// I have provided some values here for your convenience.
string[] firstNames = ["John", "James", "Michael", "Robert", "David", "Mary", "Patricia", "Jennifer", "Linda", "Susan"];
string[] lastNames = ["Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Wilson", "Thomas"];
string[] hairColours = ["black", "blonde", "ginger", "brown", "grey", "white", "blue"];
string[] eyeColours = ["blue", "brown", "green", "hazel"];
int age;

// Task 4: Now that we have another function in the program lets add an additional option to our interface to let us use this functionality.


// Task 5: Create a loop that allows the user to create and read a .csv without running the program more than once 