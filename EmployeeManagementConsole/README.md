## Employee Management System

A simple C# console application designed to manage employee records and process salary adjustments. It allows the user to register multiple employees, search for them by ID, and apply a percentage-based salary increase.

## Description

The program uses a dynamic list to store employee objects. For each registration, the user provides:

- ID
- Name
- Salary

After the registration process, the application allows the user to input a specific Employee ID to apply a salary increase. If the ID exists in the system, the program calculates the new salary; otherwise, it informs the user that the ID was not found. Finally, a report is displayed showing the updated list of all employees and their respective salaries.

## Usage Example

Below is an example of how the interaction looks in the console:

How many employees will be registered? 2

Employee #1:
ID: 333
Name: Maria Brown
Salary: 4000.00

Employee #2:
ID: 536
Name: Alex Grey
Salary: 3000.00

List of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3000.00

Enter the employee id that will have salary increase: 536
Enter the percentage: 10.0

Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3300.00
