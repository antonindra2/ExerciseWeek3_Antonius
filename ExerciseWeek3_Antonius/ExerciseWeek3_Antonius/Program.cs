using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseWeek3_Antonius
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bas= new Base();
            Shape shape = new Shape();
            Triangle triangle = new Triangle();

            Console.WriteLine("Hitung Luas dan Keliling");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga Siku-Siku");
            Console.WriteLine("4. Lingkaran");
            Console.WriteLine("5. Belah Ketupat");
            Console.WriteLine("6. Jajar Genjang");
            Console.Write("Silahkan pilih salah satu : ");
            bas.Input = double.Parse(Console.ReadLine());
      
            switch (bas.Input)
            {
                case 1:
                    shape.Count(bas.S);
                    break;
                case 2:
                    shape.Count(bas.P, bas.L1);
                    break;
                case 3:
                    triangle.Count(bas.A, bas.T);
                    break;
                case 4:
                    triangle.Count(bas.R);
                    break;
                case 5:
                    triangle.Count(bas.S, bas.D1, bas.D2);
                    break;
                case 6:
                    shape.Count(bas.T, bas.A, bas.B);
                    break;
            }
        }
    }
}
