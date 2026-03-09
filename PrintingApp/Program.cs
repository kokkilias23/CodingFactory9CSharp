namespace PrintingApp
{
    /// <summary>
    /// Basic C# program that demonstrates how to print output to the console.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Num = {0}", num);    // placeholder
            Console.WriteLine($"Num = {num}");      // interpolation
        }
    }
}
