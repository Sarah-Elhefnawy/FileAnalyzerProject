# FileAnalyzerProject
The File Analysis Project is a console application developed in C# that allows users to analyze text files and CSV files. The project demonstrates the use of object-oriented programming principles, file reading, and string manipulation.

## Overview
The project is structured with an abstract base class FileAnalyzer that defines the common interface and properties. Concrete implementations for analyzing text files (TextFileAnalyzer) and CSV files (CSVFileAnalyzer) are provided. The AnalysisResult class is used to hold the results of the file analysis, and the FileExtensions class provides extension methods for checking file types.

## Features
- Analyze text files and CSV files
- Calculate word count, character count, and line count
- Extensible design for adding more file types in the future

## Project Structure
- Program.cs: Entry point of the application. Handles user input and orchestrates file analysis.
- FileAnalyzer.cs: Abstract base class for file analyzers. Defines the interface and common properties.
- CSVFileAnalyzer.cs: Concrete implementation for analyzing CSV files.
- TextFileAnalyzer.cs: Concrete implementation for analyzing text files.
- AnalysisResult.cs: Data class to hold the results of the file analysis.
- FileExtensions.cs: Extension methods for checking file types.

## Installation
1. Clone the repository:
   ```
        git clone https://github.com/yourusername/FileAnalyzerProject.git
   ```
3. Open the project in Visual Studio or your preferred C# development environment.
4. Build and run the application.

## Video Tutorial Reference

This project was inspired by a tutorial video created by Piece of Cake Dev channel titled: [[C# Level-B][عربى][20 - C# OOP Exercise 3 - Text Data Analyzer Project](https://youtu.be/CtE8sEe_mWA?si=vboa6aA0AbfFnq9v). The project focuses on collections, lists, stack, dictionary, and data structures, with object-oriented programming principles not fully implemented.

## Usage
1. Run the console application.
2. The application will prompt you to enter a directory path to analyze.
3. The application will scan the directory and its subdirectories for text files and CSV files.
4. For each file, the application will display the analysis results, including word count, character count, and line count.

## Acknowledgements
[Piece of Cake Dev Channel](https://www.youtube.com/@poclearn) for the original idea and implementation.
