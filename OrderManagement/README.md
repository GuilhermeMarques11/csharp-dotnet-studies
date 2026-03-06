# Order System

Simple console application developed in **C#** to simulate a basic **order management system**.

The program collects client information, order details, and a list of purchased products, then generates a formatted **order summary**.

## Features

- Register client information
- Create an order with a specific status
- Add multiple items to the order
- Calculate subtotals and total price
- Display a complete order summary

## Concepts Practiced

This exercise focuses on **Object-Oriented Programming (OOP)** concepts:

- Classes and Objects
- Composition
- Lists
- Enums
- DateTime handling
- Console input/output

## Domain Model

The application is structured using the following entities:

- **Client**
- **Order**
- **OrderItem**
- **Product**
- **OrderStatus (Enum)**

These classes demonstrate **composition**, where an `Order` contains multiple `OrderItems`, and each item references a `Product`.
