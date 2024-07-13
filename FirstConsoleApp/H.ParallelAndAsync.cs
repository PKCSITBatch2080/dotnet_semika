public class ParallelAndAsync
{
    //Parallel Programming
    //Tasks - TAkes time and independent
    int[] numbers = [32342, 23432, 43213, 12526, 37621, 53323, 35423, 736546];
    private void CalculateSquare(int n)
    {
        var square = n * n;
        Console.WriteLine($"Square of{n} is {square}");
        Thread.Sleep(1000);
    }
    public void ProcessNumbers()
    {
        Console.WriteLine("Sequential loop:");
        foreach(var num in numbers)
        {
            CalculateSquare(int n)
        }
    }
}