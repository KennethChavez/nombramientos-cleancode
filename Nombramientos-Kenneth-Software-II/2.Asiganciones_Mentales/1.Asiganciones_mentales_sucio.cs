public class NumberProcessor
{
    public void ProcessNumbers(List<int> numbers)
    {
        int evenSum = 0, oddSum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0) evenSum += number;
            else oddSum += number;
        }
        Console.WriteLine("Sum of even numbers: " + evenSum);
        Console.WriteLine("Sum of odd numbers: " + oddSum);
    }
}