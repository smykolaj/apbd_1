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

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int maxNum;
    if(numbers.Length >= 1)
    {
        maxNum = numbers[0];
        foreach (var number in numbers)
        {
            if (number > maxNum)
                maxNum = number;
        }

        return maxNum;
    }

    return 0;
}
Console.WriteLine(GetMax(numbers));