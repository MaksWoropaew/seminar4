//1. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

//2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] array = new int[8];
           for (int i = 0; i < array.Length;i++)
           {
            array[i] = new Random().Next(0,2);
            Console.Write(array[i]);
           }              
        
        }
    }
}
