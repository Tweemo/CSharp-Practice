## Practice Exercise for learning C#
#### Handy things to know:
* `Console.WriteLine` will print text to the console, can be used similarly to `Console.log` in js.
* `Console.ReadLine` will be our way to save user input to a variable.
* Strings in C# unlike javascript can only exist in double quotes ("").
* If you are using Visual Studio there is a play button to run the program, otherwise if you are using Visual Studio Code, use `dotnet run` in the terminal to run the program

#### What is provided:
* `.csv` with 100 records.
* Utility file to help display the data.
* My belief that you can do this!
* Help at any point, you can either message me or looking at a working example at https://github.com/Tweemo/CSV-Practice

---

### Task 1: Display each record in the provided `.csv` well (up for interpretation)
Consider using the StreamReader class. \
StreamReader Documentation: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-8.0
</br>
</br>
### Task 2: Create an interface that allows users to input the file path of any `.csv` they wish to read
Consider using `Console.ReadLine` and `Console.WriteLine`.
</br>
</br>
### Task 3: Create a function that generates a `.csv` file of any number of records.
Hint: Consider what a `.csv` is in simple terms.
Consider using the StringBuilder, Random and File Class.
</br>
StringBuilder Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0
</br>
Random Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
</br>
File Class documentation: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-8.0
</br>
</br>
### Task 4: Add our new functionality to our interface
</br>

### Task 5: Create a loop that allows the user to create and read a `.csv` without running the program more than once
I want to be able to constantly create and read `.csv` files until I decide I don't want to anymore and give me a way to cleanly exit out of the program.
</br>
</br>

### EXTRA CREDIT
* Adding validation to allow the program to handle exceptions.





