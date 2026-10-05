string name = "John Doe";
int age = 25;
Console.WriteLine($"Name: {name}, Age: {age}");
// takes an integer input from the user and prints out whether the number is even or odd.
// Task1
Console.WriteLine("Enter an integer:");
var input = Console.ReadLine();
var isValid = int.TryParse(input, out int number);

// Task 2
if (isValid)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}

// Task 3
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Task 4
int[] interArray = [1, 2, 3, 4, 5];
// Print the sum of all elements in the array to the console.
int sum = 0;
foreach (int num in interArray)
{
    sum += num;
    Console.WriteLine(num);
}
Console.WriteLine($"Sum: {sum}");


