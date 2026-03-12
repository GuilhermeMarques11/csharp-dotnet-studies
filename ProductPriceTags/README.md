## Product Price Tags

Simple console application developed in C# to simulate a product management system with different pricing rules.
The program collects product details, handles specific data for imported or used items, and generates a formatted price tag summary using inheritance and polymorphism.

## Features

- Register common, used, or imported products
- Apply customs fees to imported products
- Store manufacture dates for used products
- Calculate total prices dynamically
- Display a formatted list of all price tags

## Concepts Practiced

This exercise focuses on Object-Oriented Programming (OOP) concepts:

- Classes and Objects
- Inheritance
- Polymorphism (Method Overriding)
- Lists and Collections
- DateTime handling

## Domain Model

The application is structured using the following entities:

- Product: Base class for all products.
- ImportedProduct: Specialized class for items with customs fees.
- UsedProduct: Specialized class for second-hand items with manufacture dates.

These classes demonstrate inheritance, where ImportedProduct and UsedProduct derive from the base Product class to extend functionality and override the label generation logic.
