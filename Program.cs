using System;

namespace Seminar3HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход пятизначное число и 
            // проверяет, является ли оно палиндромом

            // void Pal (int [] array){
            // index = 4;
            // size = 5;
            //     for ( array [0] == array [4] && array [1] == array [3], index<size, index++; )
            //     {
            //         Console.WriteLine ("Число является палиндромом");
            //     }
            //     Console.WriteLine("Число не является палиндромом");
            // }

            // int [] array = {0,0,0,0,0};
            // int [] array = new int[5];
            // Console.WriteLine("Введите пятизначное число: ");
            // int [] array = Convert.ToInt32(Console.ReadLine());
            // if (index != 4){
            //     Console.WriteLine("Введенное число не соответствует условию");
            // }
            
            // Pal (array);
        

            //Напишите программу, которая принимает на вход координаты двух точек 
            // и находит расстояние между ними в 3Д пространстве

            // double average (int x1, int x2, int y1, int y2, int z1, int z2){
            //     double sq1 = Math.Pow((x2 - x1),2);
            //     double sq2 = Math.Pow((y2 - y1),2);
            //     double sq3 = Math.Pow((z2 - z1),2);
            //     double sum = sq1 + sq2 + sq3;
            //     double result = Math.Sqrt (sum);
            //     return result;
            // }

            
            // Console.WriteLine("Введите координаты первой точки: ");
            // int x1 = Convert.ToInt32 (Console.ReadLine());
            // int y1 = Convert.ToInt32 (Console.ReadLine());
            // int z1 = Convert.ToInt32 (Console.ReadLine());
            // Console.Write ($"{x1} {y1} {z1}");
            
            // Console.WriteLine("Введите координаты второй точки: ");
            // int x2 = Convert.ToInt32 (Console.ReadLine());
            // int y2 = Convert.ToInt32 (Console.ReadLine());
            // int z2 = Convert.ToInt32 (Console.ReadLine());
            // Console.Write ($"{x2} {y2} {z2}");

            // average (x1, x2, y1, y2, z1, z2);

        //Напишите программу, которая принимает на ввод число (N) и выдает таблицу кубов чисел от 1 до N

        void Cube (int num){
            for (int i=num; i<=10; i++){
                Console.WriteLine ($"{i}*{i}*{i} = {Math.Pow(i,3)}");
            }
        }
        
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Cube (num);

            
        }
    }
}
