## Tax Payment

Simple console application developed in C# to calculate income tax for different types of taxpayers.
The program processes data for individuals and companies, applying specific tax rules and deductions based on annual income and additional criteria.

## Features

- Register individual taxpayers
- Register company taxpayers
- Apply progressive tax rates (15% or 25%) for individuals
- Apply tax deductions for health expenditures (50% rebate)
- Apply differentiated tax rates based on the number of employees for companies
- Calculate the total tax collected by all taxpayers

## Concepts Practiced

This exercise focuses on Object-Oriented Programming (OOP) concepts:

- Abstract Classes and Methods: The base class TaxPayer is abstract, forcing the implementation of the tax calculation in subclasses.
- Inheritance: Specialized rules for Individual and Company.
- Polymorphism: Calculating taxes for a diverse list of taxpayers using a single loop.
- Lists and Collections
- Conditional Logic and Math Operations

## Domain Model

The application is structured using the following entities:

- TaxPayer (Abstract): Base class containing Name and AnualIncome.
- Individual: Derived class that handles health expenditures and progressive tax brackets.
- Company: Derived class that handles the number of employees and fixed tax rates (14% or 16%).

These classes demonstrate the use of an abstract method Tax(), ensuring that every taxpayer type has its own specific calculation logic.
