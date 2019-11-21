using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Vector
    {
        public const String labName = "Лабороторная работа №3";

        static int VectorCount = 0;
        int number;
        int status;
        string some, thing;
            string total;
        public static int Count { get; private set; } = 0;
       
        int[] array;
        int Length = 0;
        
        public readonly string myName = " Шевченко Елизавета";
        Random rnd = new Random();

         private Vector( string some, string thing )
        {
            some = "some";
            thing = "thing";
            total = some + thing;
        }


        static Vector()
        {
            Count++;
            
        }
        
       
        public Vector()
        {
            array = new int[10];
            Length = 10;
            for (int count = 0; count < Length; count++)
                array[count] = (rnd.Next(-10, 15));
            VectorCount++;
        }

        public Vector(int size)
        {
            array = new int[size];
            Length = size;
            for (int count = 0; count < Length; count++)
                array[count] = (rnd.Next(-10,15));
            VectorCount++;
        }
        

        public Vector(int a, int b, int c, int d, int size)
        {
            
                array = new int[] { a, b, c, d, size };
                Length = size;
                VectorCount++;

                
            
        }
        

        public int this[int i]
        {
            get
            {
                if (i < 0 && i > Length)
                {
                    Console.WriteLine("Пpоверьте диапазон элементов массива");
                    status = 100;
                    return status;
                }
                return array[i];
            }
            set
            {
                if (i >= 0 && i <= Length)
                {

                    if (value <= 15 & value > -10)
                        array[i] = value;
                    else
                    {
                        Console.WriteLine("Пpоверьте введённое значение!");
                        status = -100;
                    }
                }
                else
                    Console.WriteLine("Пpоверьте диапазон элементов массива!");
                status = 100;
            }
        }

        public void PrintArray()
        {
            
            for (int count = 0; count < this.Length; count++)
                Console.Write(array[count] + " ");
        }

        public void SumArray(int number)
        {

           
            for (int i = 0; i < this.Length; i++)
                array[i] += number;
            
            
            
        }

         public void MulpiplyArray(int number)
          {
           
              for (int i = 0; i < this.Length; i++)
                  array[i]*=number;
            

        }

        public bool IsNullInArray()
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (array[i] == 0)
                    return true;
            }
            return false;
        }
        public int GetMin()
        {
            return array.Min();
        }
        public static int GetCount()
        {
            return VectorCount;
        }
    }


   

    partial class vector0
    {
        public string name { get; private set; }
        public int numb { get; private set; }

        public override bool Equals(object obj)
        {
           
            if (obj.GetType() != this.GetType())
                return false;
            vector0 arr1 = (vector0)obj;
            return (this.name == arr1.name && this.numb == arr1.numb);
        }

        public override int GetHashCode()
        {
           return name.GetHashCode();
            
        }
    }

    partial class vector0
    {

        public vector0(string Name, int Numb)
        {
            this.name = Name;
            this.numb = Numb;

        }





    }
}