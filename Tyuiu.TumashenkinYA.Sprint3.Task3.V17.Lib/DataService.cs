using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TumashenkinYA.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char ch in value)
            {
                if (Char.IsDigit(ch))
                {
                    res += ch;
                }
            }
            int num = Int32.Parse(res);
            return num;
        }
    }
}