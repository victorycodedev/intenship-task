// Task 1
string name = "John Doe";
int age = 25;
bool IsAdmin = true;
Console.WriteLine($"Name: {name}, Age: {age}");
Console.WriteLine($"Is Admin: {IsAdmin}");

// Task2
Console.WriteLine("Enter an integer:");
var input = Console.ReadLine();
var isValid = int.TryParse(input, out int number);

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
int[] interArray = [2, 4, 6, 8, 10];
// Print the sum of all elements in the array to the console.
int sum = 0;
foreach (int num in interArray)
{
    sum += num;
    Console.WriteLine(num);
}
Console.WriteLine($"Sum: {sum}");

// Task 5
Greet("Alice");

static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
