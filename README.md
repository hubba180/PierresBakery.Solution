# _Pierre's Bakery_
#### _This application is a practice with C# by creating a program for a fictional bakery, 2020 ver 1.0.0_
#### By _Kyle Hubbard_
(https://github.com/hubba180/pierres-bakery)
## Description
_This application is a programming practice with the C# language utilizing TDD concepts for development. It is accomplished with a console application that takes a users fictional order to Pierre's Bakery and return the price taking into account quantity and sales promos._
## Setup/Installation Requirements
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program
__
## Specs
| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Should prompt the user to specify what they'd like to buy and in what quantity | Bread 4 |  |
| Should calculate a price based on product and quantity | Bread 4 | $20 |
| Should factor sales promos like "Buy 2 get 1 free" into price calculation | Bread 4 | $15 |
| Should calculate price for orders with both Bread and Pastry quantities | Bread 4 Pastry 2 | $19 |
| Should calculate a price for orders with multiple bread and pastry quantities | Bread 2 Bread 2 Pastry 2 | $19


## Known Bugs
_No known bugs_
## Support and contact details
_Contact Kyle Hubbard <kyle.james.hubbard@gmail.com>_
## Technologies Used
_The Technologies used in the making of this software was Visual Studio editor, Mac, C#, .Net_
### License
Copyright (c) 2020 **_Kyle Hubbard_**