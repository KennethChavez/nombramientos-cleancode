public class NumberProcessor
{
    public void ProcessNumbers(List<int> numbers)
    {
        int evenSum = CalculateEvenSum(numbers);
        int oddSum = CalculateOddSum(numbers);
        DisplaySums(evenSum, oddSum);
    }

    private int CalculateEvenSum(List<int> numbers)
    {
        int sum = 0;
        numbers.ForEach(number => { if (number % 2 == 0) sum += number; });
        return sum;
    }

    private int CalculateOddSum(List<int> numbers)
    {
        int sum = 0;
        numbers.ForEach(number => { if (number % 2 != 0) sum += number; });
        return sum;
    }

    private void DisplaySums(int evenSum, int oddSum)
    {
        Console.WriteLine("Sum of even numbers: " + evenSum);
        Console.WriteLine("Sum of odd numbers: " + oddSum);
    }
}