using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        public static void Sum(int A, int B, out int sum)
        {
            sum = A + B;
        }

        public static void Change(int _c, ref int _d)
        {
            _d += _c;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Статик переменная сейчас: " + Vector.Count);
            Console.WriteLine(Vector.labName);
           
           
            Vector v1 = new Vector();
            v1.PrintArray();
            Console.WriteLine(v1.GetType());
            Console.WriteLine("\n Введите значение переменной");

           int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Сумма : "); v1.SumArray(number); v1.PrintArray();
            Console.WriteLine(" Произведение : "); v1.MulpiplyArray(number); v1.PrintArray();
            Console.WriteLine("\n--------------------------------");
            
            Vector v2 = new Vector(8);
            v2.PrintArray();
            Console.WriteLine("\n Сумма : "); v2.SumArray(number); v2.PrintArray();
            Console.WriteLine(" Произведение :"); v2.MulpiplyArray(number); v2.PrintArray();
            Console.WriteLine("\n--------------------------------");

            Vector v3 = new Vector(43, -5, 1, 90, 4);
            v3.PrintArray();
            Console.WriteLine("\n Сумма :"); v3.SumArray(number); v3.PrintArray();
            Console.WriteLine(" Произведение :"); v3.MulpiplyArray(number); v3.PrintArray();
            Console.WriteLine("\n--------------------------------\n");

            Console.WriteLine("А сейчас она не изменилась: " + Vector.Count);
            Console.WriteLine("Всего объектов: " + Vector.GetCount());

            Vector[] vectors = { v1, v2, v3 };

            for (int i = 0; i < vectors.Length; i++)
            {
                if (vectors[i].IsNullInArray())
                    Console.WriteLine("В массиве {0}-го объекта есть ноль! ", (i + 1));
            }

            for (int i = 0; i < vectors.Length; i++)
                Console.WriteLine("Минимальный элемент {0} в массиве: {1}", i + 1, vectors[i].GetMin());
            Console.WriteLine("\n--------------------------------\n");

            int a, b, c, d, sum;
            a = 5;
            b = 10;
            c = 20;
            d = 25;
            Console.WriteLine("a = {0}\nb = {1}\nc = {2}\nd = {3}", a, b, c, d);
            Sum(a, b, out sum);
            Console.WriteLine("Сумма a и b равна: " + sum);
            Change(c, ref d);
            Console.WriteLine("После работы с ref: ");
            Console.WriteLine("\nc = {0} \nd = {1}", c, d);
            Console.WriteLine("\n--------------------------------\n");


            vector0 Vector1 = new vector0("Vector1", 10);
            vector0 Vector2 = new vector0("Vector2", 20);

            Console.WriteLine("\nназвание: {0}", Vector1.name);
            Console.WriteLine("\nколичество: {0}", Vector1.numb);
            Console.WriteLine("Хеш-код: {0}", Vector1.GetHashCode());

            Console.WriteLine("\nназвание: {0}", Vector2.name);
            Console.WriteLine("\nколичество: {0}", Vector2.numb);
            Console.WriteLine("Хеш-код: {0}", Vector2.GetHashCode());
            Console.WriteLine(Vector2.Equals(Vector1) ? " \nЭти объекты одинаковы\n" : "\nЭти объекты НЕ одинаковы\n");
            Console.WriteLine("Тип объекта Vector1: {0}", Vector1.GetType());
            Console.WriteLine("\n--------------------------------\n");
            var anon = new { x = 5, Name = "vectorX" };
            Console.WriteLine(anon.GetType());
            Console.ReadKey();


        }


    }
}

