## Sales Summary

This is a simple C# program that reads a CSV file containing product data, calculates the total value of each item (price × quantity), and generates a new summary file in a specific subfolder.

## Features

Data Reading: Processes .csv files with comma-separated fields.
Automatic Calculation: Instantiates Product objects to calculate the total stock value per item.
Output Organization: Automatically creates a folder named out in the source directory.
Export: Generates a summary.csv file with the product name and the formatted total value.

## File Structure

The source file must follow the format: name, price, quantity:

Chair, 50.00, 3

Generated Output:

The program will create a file at ./out/summary.csv:

Chair, 150.00
