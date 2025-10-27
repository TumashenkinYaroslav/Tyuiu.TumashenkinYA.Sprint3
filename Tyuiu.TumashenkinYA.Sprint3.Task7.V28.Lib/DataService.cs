using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TumashenkinYA.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (0 == (i + 2.5)) result[index] = 0;
                else result[index] = Math.Round((Math.Cos(2 * i) + (Math.Sin(i) / (2.5 + i)) + 2 * i), 2);
                index++;
            }
            return result;
        }
    }
}
