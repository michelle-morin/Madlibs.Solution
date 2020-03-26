# _Mad Libs_

#### _ASP.NET MVC practice Epicodus_, _Mar. 9, 2020_

#### By _**Michelle Morin, Antonio Cruz**_

## Description

_This project is a web application that presents users with a form with fields for various parts of speech. After filling out the form, the user is directed to a page containing a story that has used their provided words in its text._ 

## Specifications:

| Specification | Example Input | Example Output | 
| ------------- |:-------------:| :-------------:|
| Application allows user to navigate to form at URL route "/form" | user enters URL in web browser | web browser displays view associated with the form route |
| Application includes a form where users can submit words for various form fields and their responses are stored as properties of a madlibs class | user submits form | property values are assigned to form responses  |
| Application navigates to madlibs (story) view when user submits form | user submits form | webpage redirects to "/story" URL |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd Madlibs.Solution``

_Confirm that you have navigated to the Madlibs.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_To view/edit the source code of this application, open the contents of the Madlibs.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

_Run this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd Madlibs``
* ``dotnet run``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Antonio Cruz_**
