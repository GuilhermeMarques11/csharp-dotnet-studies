// Get matrix dimensions (Rows and Columns) from user input
Console.Write("Enter the number of rows and columns in the matrix: ");
string[] line = Console.ReadLine().Split(' ');
int rows = int.Parse(line[0]);
int columns = int.Parse(line[1]);
// Initialize the 2D array (matrix) based on dimensions
int[,] mat = new int[rows, columns];

// Populate the matrix by reading values for each row
Console.WriteLine("Fill in the rows of the matrix:");
for(int i = 0; i < rows; i++)
{
  string[] values = Console.ReadLine().Split(' ');
  for(int j = 0; j < columns; j++)
  {
    mat[i, j] = int.Parse(values[j]);
  }
}
Console.WriteLine();

// Get the target number X to search for within the matrix
Console.Write("Enter a number from the matrix: ");
int x = int.Parse(Console.ReadLine());

// Iterate through the matrix to find every occurrence of number 'n'
for (int i = 0; i < rows; i++)
{
  for (int j = 0; j < columns; j++)
  {
    // If the current element matches the target number
    if (x == mat[i, j])
    {
      Console.WriteLine($"Position: {i}, {j}:");
      // Check and print the Left neighbor if it exists (not in the first column)
      if (j > 0)
      {
        Console.WriteLine($"Left: {mat[i, j - 1]} ");
      } 
      // Check and print the Right neighbor if it exists (not in the last column)
      if (j < columns - 1)
      {
        Console.WriteLine($"Right: {mat[i, j + 1]} ");
      } 
      // Check and print the Top neighbor if it exists (not in the first row)
      if (i > 0)
      {
        Console.WriteLine($"Up: {mat[i - 1, j]}");
      }
      // Check and print the Bottom neighbor if it exists (not in the last row)
      if (i < rows - 1)
      {
        Console.WriteLine($"Down: {mat[i + 1, j]}");
      } 
      Console.WriteLine();
    }
  }
}
