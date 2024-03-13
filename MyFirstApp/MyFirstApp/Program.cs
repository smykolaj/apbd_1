// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    double numbersSum = 0.0;
    foreach (var number in numbers)
    {
        numbersSum += number;
    }

    return numbersSum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int max;
    if(numbers.Length >= 1)
    {
        max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
                max = number;
        }

        return max;
    }

    return 0;
}
Console.WriteLine(GetMax(numbers));