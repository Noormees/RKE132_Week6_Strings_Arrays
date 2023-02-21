

using System.Diagnostics.CodeAnalysis;

int[] numbers = new int[10];

Random rnd= new Random();

int sum = 0;

// populating the array - massivi taitmine
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 100); 
    // numbers[i] = rnd.Next(1, numbers.Length + 1)
    
    sum = sum + numbers[i];

}

// kuvame vaartused
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");    
