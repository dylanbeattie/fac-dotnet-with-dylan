# fac-dotnet-with-dylan
"Dotnet with Dylan" sessions at Founders and Coders

Session 1: .NET Fundamentals

### **Background**

* What is .NET anyway? [https://dotnet.microsoft.com/en-us/](https://dotnet.microsoft.com/en-us/)
* Just enough history (and why the history sticks)
* C#, F#, VB.NET - 
  * [https://www.statista.com/statistics/793628/worldwide-developer-survey-most-used-languages/](https://www.statista.com/statistics/793628/worldwide-developer-survey-most-used-languages/)
  * [https://www.tiobe.com/tiobe-index/](https://www.tiobe.com/tiobe-index/)

### Our First .NET App

dotnet new console.

Console.WriteLine()

Variables - use console.readline to store the user's name.

String interpolation

Methods

Collections and loops

### Understanding Types

#### Exercise: Build a calculator

Your program  should ask the user to enter two numbers, and then display the sum of those numbers.

```
C:\dotnet\Calculator>dotnet run
Enter first number:
23
Enter second number:
45
23 + 45 = 68
```

* Somebody will probably end up with `23 + 45 = 2345`
* Introduce Int32.Parse

#### Exercise: build a better calculator

Your program should ask the user to enter a simple equation, or enter `quit` if they're finished calculating.

Your program should support four **operations**: addition (`+`), multiplication (`*`), division (`/`) and subtraction (`-`).

**Tip:** [String.Split](https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-8.0) will break a string into substrings

```dotnetcli
C:\dotnet\BetterCalculator>dotnet run calc
Enter expression:
23+45
Sorry, I can't parse that expression. (Did you put spaces around the operator?)

Enter expression:
23 + 45
Result: 23 + 45 = 68

Enter expression:
15 / 3
Result: 15 / 3 = 5 

Enter expression:
quit
Bye!
```

Classes and objects

* Create a class representing a Car
* Make, model, doors, engine size, colour, year of first registration
* Colours: introduce enumerations
* Build a big old list of cars

Create a PricingEngine - this **can be static**.

Introduce LINQ:

* Where - find all the red cars
* OrderBy - most expensive cars first
* GroupBy
* First
* Sum

Exercise:

* Find the most expensive red car in the collection
* Find the total price of all the brown cars in the collection
* What's the average price of cars with engine size greater than 2 litres?
* What is the most popular year for cars?









