# Scope AR Job Application

This is my submission for the Scope AR programming test. This is a console application which takes in user input and outputs two different shapes according to the specifications of the assignment. I've created this with C# in the .NET Core 2.0. I believe I've gone past what may have been originally intended for scope of this assignment. This was done to better demonstrate how I thought these problems should be solved if it were to be integrated into other code. I've made each solution to the two problems into their own class. Furthermore I've added a factory for the creation of each solution. The actual solution of each problem is called in the constructor of each class so that each can be drawn multiple time without the need to recalculate each shape. 


```ScopeARJobApplication/Program.cs``` contains Main function which takes user input to create console shapes.
```ScopeARJobApplication/ConsoleShape``` contains the classes with the actual solutions.
```ScopeARJobApplication/ConsoleShapeFactory``` contains the code for the factory.
```ScopeARJobApplicationTests/ConsoleShapeTests``` contains the tests for the ConsoleShapes and Factory. 

## Getting Started

Clone the repo from https://github.com/swbenson11/ScopeARApplication.git

### Prerequisites

Ideally visual studios should be used to view and run this application as well as run the tests.
Alternatively you can run the application via command line with .net core 2.0 installed. 

### Installing

Pull repo from the git.

With Visual Studios:
  Open the solutions file in Visual Studio. Once the project is open you should be able to run the application, or run the tests.  

Without Visual Studio:
  Open the cmd line and navigate to the directory which you pulled the git to. Open the ScopeARJobApplication folder and run 
  ```dotnet build```
  This set isn't nessesary as running will also call the build command. 

### Running

With Visual Studios:
  Open the solutions file in Visual Studio. The project can be run with F5. Make sure that ScopeARJobApplication is set as the start up project. 

Without Visual Studio:
  Open the cmd line and navigate to the directory which you pulled the git to. Open the ScopeARJobApplication folder and enter
  ```dotnet run```
  

## Running the tests

With Visual Studios:
  Open the solutions file in Visual Studio. Once the project is open you should be able to run the application, or run the tests. You should be able to run them through the test explorer or, with "ctrl + R, A" 

Without Visual Studio:
  Open the cmd line and navigate to the directory which you pulled the git to. Open the ScopeARJobApplicationTests folder and enter: ```dotnet test```
  
  
Test were created with Visual Studio default testing library, for the sake of simplicity. I've created tests for just the ConsoleShape namespace. This was because I was working under the assumption that you wanted me to create those solutions as example code in a larger project and that the user input section was less important. It was a little redundant to put them in folder called ConsoleShapeTests, but if there were more parts to this project it would make more sense. 

## Authors

* **Stephen Benson** - [swbenson11](https://github.com/swbenson11)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
