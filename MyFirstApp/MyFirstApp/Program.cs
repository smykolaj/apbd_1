// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}