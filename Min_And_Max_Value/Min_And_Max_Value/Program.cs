using System;
using System.Collections.Generic;
using System.Linq;

namespace Min_And_Max_Value
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };

            Result.miniMaxSum(arr);
        }
    }

    class Result
    {
        public static void miniMaxSum(List<int> arr)
        {
            //PEGA OS NUMEROS MAXIMOS E MINIMOS
            var maxValue = getNumberMax(arr);
            var minValue = getNumberMin(arr);

            //PRECISA RETORNAR A LISTA SEM OS NUMEROS DO PARAMETRO 
            var listMin = getList(arr, maxValue);
            var listMax = getList(arr, minValue);

            //SOMA OS VALORES DA LISTA
            Console.WriteLine(Sum(listMin.ToArray()) + " " + Sum(listMax.ToArray()) );
            
        }

        public static List<int> getList(List<int> arr, long number)
        {
            var quantNumberIgual = 0;

            quantNumberIgual = arr.Count(i => i == number);

            if (quantNumberIgual == arr.Count) // SE TODOS ITENS DO ARRAY FOREM IGUAL
                return arr.Skip(1).ToList();
            else
                return arr.ToArray().Where(x => x != number).ToList();
            
        }

        public static long Sum(int[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static long getNumberMax(List<int> arr)
        {
            var number = 0;
            foreach (var item in arr)
            {
                if (item > number)
                    number = item;
            }
            return number;
        }

        public static long getNumberMin(List<int> arr)
        {
            var number = long.MaxValue;
            foreach (var item in arr)
            {
                if (item < number)
                    number = item;
            }
            return number;
        }
    }
}
