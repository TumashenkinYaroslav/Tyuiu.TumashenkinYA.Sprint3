using Tyuiu.TumashenkinYA.Sprint3.Task3.V17.Lib;
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания,            *");
Console.WriteLine("* оставить цифру затем преобразовать в число в строке: *vn98n! b,         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string value = "*vn98n! b,";
int res = ds.ConvertStringToInt(value);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("После удаления всех букв и знаков препинания, осталось только число: " + res);
Console.ReadKey();