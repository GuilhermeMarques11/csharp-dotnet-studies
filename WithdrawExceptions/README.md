## Withdraw Exceptions

Console application developed in C# to simulate bank account withdrawals with custom error handling.
The program validates withdrawal rules, such as sufficient balance and withdrawal limits, using a specialized exception structure to ensure the application's robustness.

## Features

Register bank account data (Number, Holder, Initial Balance, and Withdrawal Limit)

- Perform withdrawal operations
- Validate if the withdrawal amount exceeds the account limit
- Validate if there is enough balance for the operation
- Handle custom exceptions to provide clear error messages

## Concepts Practiced

This exercise focuses on Exception Handling and Domain Logic concepts:

- Custom Exceptions: Creating a specific class (e.g., DomainException) to handle business rule violations.
- Try-Catch Blocks: Implementing structured error handling to prevent application crashes.
- Encapsulation: Protecting the account balance and limit through methods.

## Domain Model

The application is structured using the following entities:

- Account: Contains the account data and the Withdraw() method, which is responsible for validating the business rules and throwing exceptions when necessary.
- DomainException: A custom exception class that inherits from ApplicationException, used to catch and display specific bank-related errors.
