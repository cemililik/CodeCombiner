# CodeCombiner
A simple .NET 6 console application that combines source code files from a specified directory, with a specified file extension, into a single output file.

## Features
- Combines code files from a specified directory and its subdirectories.
- Supports various file extensions (e.g., cs, py, go, etc.).
- Automatically appends file paths as comments in the combined output file.

## Prerequisites
NET 6 SDK

## How to Use
1. Clone the repository or copy the provided code into a new .NET 6 console application project.
2. Open a terminal/command prompt, navigate to the project directory, and build the project:
```bash
dotnet build
```
3. Run Application 
```bash
dotnet run 
```
4. Follow the prompts to provide the Source Path, Output Path, and File Extension:
  - Source Path: The directory containing the code files you want to combine. If left empty, the current directory will be used.
  - Output Path: The path to the output file where the combined code will be written (e.g., C:\your_output_file_path\output.txt).
  - File Extension: The file extension of the code files you want to combine (e.g., cs, py, go, etc.).
5. The application will combine the code files and save the result to the specified output file.
