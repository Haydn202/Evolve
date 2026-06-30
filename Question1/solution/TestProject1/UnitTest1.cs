namespace TestProject1;

public class Tests
{
    [Test]
    [TestCase(17, 4, new[] { 4, 8, 12, 16 })]
    [TestCase(21, 7, new[] { 14 })]
    [TestCase(5, 20, new[] { 10, 20 })]
    [TestCase(3, 10, new[] { 6 })]
    [TestCase(2, 2, new[] { 2 })]
    public void Test1(int num1,  int num2, int[] expectedValidNumbers)
    {
        var valid = new ValidNumbers(num1, num2);
        
        Assert.That(valid.GetValidNumbers(), Is.EqualTo(expectedValidNumbers));
    }
}
