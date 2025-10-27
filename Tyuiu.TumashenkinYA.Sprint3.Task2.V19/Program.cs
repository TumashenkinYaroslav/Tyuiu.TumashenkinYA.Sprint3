using Tyuiu.TumashenkinYA.Sprint3.Task2.V19.Lib;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int startValue = 1;
int stopValue = 10;
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " +  stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
Console.ReadKey();