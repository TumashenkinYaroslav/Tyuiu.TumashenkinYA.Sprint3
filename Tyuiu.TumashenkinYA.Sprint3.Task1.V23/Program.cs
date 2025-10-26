using Tyuiu.TumashenkinYA.Sprint3.Task1.V23.Lib;

namespace Tyuiu.TumashenkinYA.Sprint3.Task1.V23
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");


            int value = 5;
            int startValue = 1;
            int stopValue = 5;
            Console.WriteLine("X:" + value);
            Console.WriteLine("старт шага:" + startValue);
            Console.WriteLine("конец шага:" + stopValue);


            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine($"Ответ = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}