This is a C# console application designed to process 2D arrays (matrices). The program allows a user to input matrix dimensions, fill the grid with integers, and then search for a specific value to identify its immediate neighbors.

## How it works

- Input Dimensions: The user provides the number of rows and columns.
- Populate Matrix: The user enters the values for each row of the matrix.
- Search Value: The user inputs a target integer X.
- Analyze Neighbors: The program locates every occurrence of X and prints the values located to its Left, Right, Up, and Down, while respecting the matrix boundaries (to avoid index out of bounds errors).

## Example

Input:

Plaintext
Enter a number of rows and columns in the matrix: 3 4
Fill in the rows of the matrix:
10 8 15 12
21 11 23 8
14 5 13 19

Enter a number from the matrix: 8
Output:

Plaintext
Position: 0, 1:
Left: 10
Right: 15
Down: 11

Position: 1, 3:
Left: 23
Up: 12
Down: 19
