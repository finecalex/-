using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args)
{

Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ! Вас приветствует программа по нахождению коэффициента финансовой независимости. РАЗВИВАЙТЕСЬ И БУДЬТЕ ФИНАНСОВО НЕ-ЗА-ВИ-СИ-МЫ!");
Console.WriteLine();
Console.WriteLine("==========================================");
double a, b, c, d;
Console.WriteLine("Какой вариант развития у вашей компании? 1=традиционный; 0=стартап");
d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество собственны][ средств");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество заемных средств");
b = Convert.ToDouble(Console.ReadLine());
c = a/b;
Console.WriteLine("Коэффициент финансовой независимости равен " + c);
Console.ReadKey();
}
}
}
