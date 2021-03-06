# _Hair Salon_

![Gordon Ramsy](https://media.giphy.com/media/ulUNA7uAC1o3e/giphy.gif)

#### _A project with C Sharp in Databases with a Hairsalon., 2020 ver 1.0_

#### By _Ian Gregg_
[Eau-Claires-Salon-Solution](https://github.com/oldgregg89/Eau-Claire-s-Salon-Solution)

## Description

_A project with C Sharp in Databases with a Hairsalon. Helping a nice lady set up a datbase of her stylists and all the clients that they have to keep track of._

## Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program
* run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`  &
`dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
in the terminal
* add a file called `appsetting.json` in the HairSalon directory.
* in `appsetting.json` add ![appsetting.json](Assets/setup.png)
* fill in your `server`, `port`,`database`,`uid`, and `pwd`

## Setup Database Instruction
* open your cloned file on your desktop and move the `ian_gregg.sql` document from the `EauClairsSalon.Solution` on to your dekstop. ![ian_gregg.sql](Assets/DBfilename.png)
* Open your MySQL and open the tab to the `Administration` tab and click on `Data Import/Restore`. 
![Sql-Import-tab](Assets/SqlImport.png)
* Locate the file `ian_gregg.sql` and click `load folder contents`. ![Data-Import](Assets/DataImport.png)
* Double check your `appsetting.json` is working properly with proper naming conventions & from there you should be good to go!

## Specs

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| `Delete` a Client | `click` Delete client , "Bob" | `Display` no dipslay |
| `Create` a Client | `click` Create client , "Bob" | `Display` "Bob" |
| `Edit` a Client | `click` Edit client, "Bob" change to "Jill" | `Display` "Jill" |
| `Detail` Stylist | `click` stylist "Avon" | `Display` "Avon & `clients`" |



## Known Bugs

_No known bugs_

## Support and contact details

_Contact Ian Gregg: <iangregg188@gmail.com>_

## Technologies Used

_The Technologies used in the making of this software was Chrome browser, Visual Studio editor, and Mac, C#, .Net_

### License

Copyright (c) 2020 **_Ian Gregg_**

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

