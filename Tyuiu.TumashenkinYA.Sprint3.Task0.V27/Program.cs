using Tyuiu.TumashenkinYA.Sprint3.Task0.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input n");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input start value");
        int startvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input stop value");
        int stopvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result" + ds.GetSumSeries(value, startvalue, stopvalue));
    }
}