## Worker Contracts Manager

This is a C# console application designed to manage employee data and calculate total income based on multiple work contracts. The program demonstrates the practical use of Enumerations to define worker levels and Object Composition to associate a worker with their department and various contracts.

## How it works

- Input Worker Data: The user provides the department name, worker's name, professional level (Junior, MidLevel, or Senior), and base salary.

- Manage Contracts: The user specifies the number of contracts and provides the date, value per hour, and duration (hours) for each.

- Income Calculation: The user inputs a specific month and year (MM/YYYY). The program then calculates the total income by adding the base salary to the sum of all contract values for that specific period.

- Boundary Logic: The system filters the list of contracts to ensure only the ones matching the requested month and year are included in the final calculation.
