using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double oper1;
            double oper2;
            double res;

            Console.WriteLine("Выберите операцию: 1 - сложение 2 - вычитание 3 - умножения 4 - деление ");
            try
            {
                int caseSwitch = Convert.ToInt16(Console.ReadLine());
                if (caseSwitch < 1 || caseSwitch>4)   // 4 операции
                {
                    Console.WriteLine("Неверные данные");
                }

                switch (caseSwitch)
                {
                    case 1:                       
                        Console.WriteLine("Введите первое число:");
                        oper1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        oper2 = Convert.ToDouble(Console.ReadLine());
                        Calc sum = new Calc();
                        res = Calc.Sum(oper1, oper2);
                        Console.WriteLine("Результат " + res);

                        break;
                    case 2:
                        Console.WriteLine("Введите первое число:");
                        oper1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        oper2 = Convert.ToDouble(Console.ReadLine());
                        Calc min = new Calc();
                        res = Calc.Sub(oper1, oper2);
                        Console.WriteLine("Результат " + res);

                        break;
                    case 3:
                        Console.WriteLine("Введите первое число:");
                        oper1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        oper2 = Convert.ToDouble(Console.ReadLine());
                        Calc umn = new Calc();
                        res = Calc.Mult(oper1, oper2);
                        Console.WriteLine("Результат " + res);


                        break;
                    case 4:
                        Console.WriteLine("Введите первое число:");
                        oper1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        oper2 = Convert.ToDouble(Console.ReadLine());
                        Calc del = new Calc();
                        res = Calc.Div(oper1, oper2);
                        Console.WriteLine("Результат " + res);


                        break;

                }


            }
            catch {
                Console.WriteLine("Упс!!! Неверные данные.");
            }


        }
          
    }
}
