using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseWeek3_Antonius
{
    public class Base
    {
        private double s;
        private double p;
        private double l;
        private double L;
        private double K;
        private double a;
        private double b;
        private double t;
        private double r;
        private double input;
        private double temp;
        private double d1;
        private double d2;

        public double S { get => s; set => s = value; }
        public double P { get => p; set => p = value; }
        public double L1 { get => l; set => l = value; }
        public double L2 { get => L; set => L = value; }
        public double K1 { get => K; set => K = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double T { get => t; set => t = value; }
        public double R { get => r; set => r = value; }
        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double Input { get => input; set => input = value; }
        public double Temp { get => temp; set => temp = value; }
    }
    public class Shape : Base
    {
        public void Count(double S)
        {
            try
            {
                Console.Write("Masukan sisi = ");
                S = double.Parse(Console.ReadLine());
                L2 = S * S;
                K1 = 4 * S;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Persegi = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Persegi = " + K1);
                Console.ReadLine();
            }
        }
        public void Count(double P, double L1)
        {
            try
            {
                Console.Write("Masukan panjang = ");
                P = double.Parse(Console.ReadLine());
                Console.Write("Masukan lebar = ");
                L1 = double.Parse(Console.ReadLine());
                L2 = P * L1;
                K1 = 2 * (P + L1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Persegi Panjang = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Persegi Panjang = " + K1);
                Console.ReadLine();
            }
        }
        public void Count(double T, double A, double B)
        {
            try
            {
                Console.Write("Masukan sisi alas = ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Masukan sisi miring = ");
                B = double.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi = ");
                T = double.Parse(Console.ReadLine());
                L2 = A * T;
                K1 = 2 * (A + B);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Jajar Genjang = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Jajar Genjang = " + K1);
                Console.ReadLine();
            }
        }
    }
    public class Triangle : Shape
       {
        public void Count(double A, double T)
        {
            try
            {
                Console.Write("Masukan alas = ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi = ");
                T = double.Parse(Console.ReadLine());
                L2 = 0.5 * (A * T);
                Temp = Math.Sqrt((A * A) + (T * T));
                K1 = A + T + Temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Segitiga Siku-Siku = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Segitiga Siku-Siku = " + K1);
                Console.ReadLine();
            }
        }
        public void Count(double R)
        {
            try
            {
                Console.Write("Masukan jari-jari = ");
                R = double.Parse(Console.ReadLine());
                L2 = 3.14 * (R * R);
                K1 = 2 * (3.14 * R);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.Write("Luas Lingkaran = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Lingkaran = " + K1);
                Console.ReadLine();
            }
        }
        public void Count(double S, double D1, double D2)
        {
            try
            {
                Console.Write("Masukan sisi = ");
                S = double.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 1 = ");
                D1 = double.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 2 = ");
                D2 = double.Parse(Console.ReadLine());
                L2 = 0.5 * (D1 * D2);
                K1 = 4 * S;
            }
            catch(Exception e)
            {       
                 Console.WriteLine(e);  
            }
            finally
            {
                Console.Write("Luas Belah Ketupat = " + L2);
                Console.WriteLine();
                Console.Write("Keliling Belah Ketupat = " + K1);
                Console.ReadLine();
            }
        }
    }
}      



    

