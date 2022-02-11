using System;
using System.Linq;

namespace ConsoleApp2
{

    class program
    {
        static void Main(string[] args)
        {
            Task8();
        }
        public static void Task1()
        {
            int a = 5;
            int result = 1;
            for (int i = 1; i < a + 1; i++)
            {
                result = result * i;

            }
            Console.WriteLine(result);
        }
        /*найти одинаковые жлемены массива*/
        public static void Task3()
        {
            int[] array = new int[] { 2, 5, 7, 8, 9, 3, 5, 5 };
        int resul;
            for (int i = 0; i<array.Length; i++)
            {
                resul = array[i];
               
            }
            foreach (var item in array)
            {
                Console.Write(item);

            }
           
        }

        //найти одинаковые элементы массива
        public static void Task4()
        { 
            int[]arr = new int[] { 3, 4,6, 5, 8, 9, 3,4 };
            int count=0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =0; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        count =arr[j];
                        count= arr[j];
                    }
                  
                }
            }
            Console.WriteLine(count);
            Console.WriteLine();

        }
        //найти наименьший элемент массива
        public static void Task5()
        {
            int[] array = { 2, 59, 6, 85, 80, 9, 4, 70, 8, };
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                

            }
            Console.WriteLine(min);
        }
        //нати миимальное значение
        public static void Task6()
        {
            int[] array = { 2, 45, 89, 5, 89, };
            int min = array.Max();
            Console.WriteLine(min);
        
        }
        //найти сумму всех четных элементов массива
        public static void Task7()
        {

            int[] array = { 2, 3, 4 ,5};
            int sum = array.Where(i=>i%2!=0). Min();
            Console.WriteLine(sum);
        }
        //отсортировать элементы массива по возрастанию
        public static void Task8()
        {
            int[] array = { 45, 2, 56, 45 };
            int[] result = array.OrderBy(i => i).ToArray();
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }


        }
        public static void Task9()








}   }

