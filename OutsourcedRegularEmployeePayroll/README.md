## Employees and Outsourced Employees Payroll

Small C# console application created as part of my C# and Object-Oriented Programming studies.

This exercise focuses on practicing specific programming concepts through a simple problem solved in a console application.

## Objective

Develop a system to manage employee data (internal and outsourced), calculate their respective payments based on hours worked and hourly rates, and apply a specific bonus for outsourced staff based on additional expenses.

## Concepts Practiced

- Inheritance: Extending a base class to create specialized behavior for different types of employees.
- Polymorphism: Overriding methods to ensure the correct payment calculation is executed for each object type at runtime.
- Encapsulation: Managing object data through properties and constructors. - Lists and Collections: Using List<Employee> to store and iterate through a heterogeneous collection of objects.

## Domain Model

Entities used in the application:

- Employee: The base class containing the name, hours worked, and hourly rate. It implements the standard payment logic: $Payment = Hours \times ValuePerHour$.
- OutsourcedEmployee: A subclass that inherits from Employee and includes an AdditionalCharge. It overrides the payment method to add a bonus equivalent to 110% of that charge.

Relationship:
The OutsourcedEmployee is a specialization of Employee. By using a list of the base type (Employee), the program can store both types of workers together and use polymorphism to call the correct Payment() calculation for each one automatically.
