using System;
using System.Collections.Generic;
using odintsov;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path = @"..\..\..\build_output\version.txt";
                string file_version_from_txt = File.ReadAllText(path);

                OdintsovLog.I().log("Версия программы " + file_version_from_txt + "вывести текущую версию из файла version");
                /*LinearEquation a = new LinearEquation();
                List<float> qwe = a.a_linear_equation(2, 6);
                foreach (var item in qwe)
                {
                    Console.WriteLine(item + " ");
                }
                QuadraticEquation b = new QuadraticEquation();
                List<float> qwe2 = b.solve(1, 3, -4);
                foreach (var item in qwe2)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();

                OdintsovLog.I().log("test");
                OdintsovLog.I().log("test2");
                OdintsovLog.I().write();*/
                Console.Write("Введите 3 параметра a, b, c: ");
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());

                OdintsovLog.I().log("Введенное уравнение: " + a + "x^2" + "+(" + b + "x)" + "+(" + c + ")=0" );
                QuadraticEquation urv = new QuadraticEquation();
                List<float> mas = urv.solve(a, b, c);

                OdintsovLog.I().log("Корни уравнения: " + string.Join(" ", mas));
            }
            catch (OdintsovException ex)
            {
                OdintsovLog.I().log(ex.Message);
            }
            catch (Exception ex)
            {
                OdintsovLog.I().log(ex.Message);
            }
            OdintsovLog.I().write();
            Console.ReadKey();
        }
    }
}
