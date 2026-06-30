void Main(string[] args)
{
    
}

public class ValidNumbers(int num1, int num2)
{
    private readonly List<int> _validNumbers = GetValidNumbers(num1, num2);

    public List<int> GetValidNumbers()
    {
        return _validNumbers;
    }

    private void PrintValidNumbers()
    {
        foreach (var num in _validNumbers)
        {
            Console.WriteLine(num);
        }
    }
    
    private static List<int> GetValidNumbers(int num1, int num2)
    {
        var upperBound = num1 > num2 ? num1 : num2;
        var divisor = num1 < num2 ? num1 : num2;
        var validNumbers = new List<int>();

        for (var i = divisor; i <= upperBound; i += divisor)
        {
            if (IsEven(i))
            {
                validNumbers.Add(i);
            }
        }

        return validNumbers;
    }

    private static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}
