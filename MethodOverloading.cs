using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    class Vector
    {
        internal int x, y, z;
        internal Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        internal Vector() { }
    }
    class Matrix
    {
        internal int [,] m = new int[2,2];
        internal Matrix(){}
    }
    class Program
    {
	 static void add(int a, int b)
        {
            int temp = a + b;
            Console.WriteLine(temp);
        }
        static void add(Vector a, Vector b)
        {
            Vector temp = new Vector();
            temp.x = a.x + b.x;
            temp.y = a.y + b.y;
            temp.z = a.z + b.z;
            Console.WriteLine("{0}x {1}y {2}z", temp.x, temp.y, temp.z);

        }
        static void add(Matrix a, Matrix b)
        {
            Matrix temp = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temp.m[i, j]=a.m[i,j]+b.m[i,j];
                    Console.Write(temp.m[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
       	Console.WriteLine("Enter Vector");
	Vector a = new Vector(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Vector b = new Vector(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            add(a, b);
            Console.WriteLine("Enter integer");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            add(x, y);
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();
            m1.m[0, 0] = 2;
            m1.m[0, 1] = 2;
            m1.m[1, 0] = 2;
            m1.m[1, 1] = 2;
            m2.m[0, 0] = 3;
            m2.m[0, 1] = 3;
            m2.m[1, 0] = 3;
            m2.m[1, 1] = 3;
            add(m1, m2);
            Console.ReadKey();
        }
    }
}
