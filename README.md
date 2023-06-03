# _The Factory_

#### By _**Joseph Wahbeh**_

#### Project implements C# to create a secret confectionery where they can store information about treats and flavors that they like.

## Technologies Used

* _C#_
* _Microsoft.NET.Sdk v6.0_
* _MySQL WorkBench v8.0_
* _Entity Framework v6.0.0_

## Description

_This is a web page application that allows a user to store information about Treats and Flavors. The user can assign Treats and Flavors to each other. A Treat can have multiple Flavors and a Flavor cand be listed under multiple Treats. The User must log in if they want to access and create or edit Functionality._

## Setup/Installation Requirements

* _Clone `TheSecretConfectionery.Solution` from the repository to desired location_
* _Navigate to cloned directory via your local terminal command line_
* _Navigate to this project's production directory called `theconfectionery` through the terminal_.
* _In the terminal, run the command `touch appsettings.json` and open the file using the command `code appsettings.json`_ 


* _Copy and paste the follwing code into the `appsettings.json` file_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=the_super_secret_database_filled_with_good_things;uid=[user-id-Name];pwd=[user-password];"
  } 
}
```
* _Replace `[user-id-Name]`, `[user-password]` Brackets included with the correct information_
* _Save and exit `appsettings.json`_

* _In the terminal, run the command `dotnet ef database update`_
* _In the terminal, run the command `dotnet restore`_
* _In the terminal, run the command `dotnet watch run`_

## Known Bugs

* _No known bugs as of 06/02/23_

## License
MIT License

Copyright (c) 2023 Joseph Wahbeh

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
