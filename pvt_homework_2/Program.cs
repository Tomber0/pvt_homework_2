using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_homework_2
{
    class Program
    {
        static void Main(string[] args)

        {
            SpecialTask1();
            //TODO:
            //1) прочитать про систему типов Рихтера
            //2) 
            //
            //
            //

            //Array


        }
        static void FirstTask() {

            // найти мин.макс и меняет их местами 
            int[] inputArray = new int[4];

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Out.Write("\n{0}:", i);
                inputArray[i] = Convert.ToInt32(Console.In.ReadLine());
            }


            int minOfArray1 = inputArray[0];
            int maxOfArray1 = inputArray[0];

            int indexOfMin = 0;
            int indexOfMax = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (minOfArray1 > inputArray[i])
                {
                    minOfArray1 = inputArray[i];
                    indexOfMin = i;

                }
                if (maxOfArray1 < inputArray[i])
                {
                    maxOfArray1 = inputArray[i];
                    indexOfMax = i;

                }


            }
            Console.Out.WriteLine("Массив до перестановки:");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Out.WriteLine("{0} : {1}", i, inputArray[i]);
            }


            Console.Out.WriteLine("min - {0}\nmax - {1}", minOfArray1, maxOfArray1);
            int bufForArray = inputArray[indexOfMin];
            inputArray[indexOfMin] = inputArray[indexOfMax];
            inputArray[indexOfMax] = bufForArray;

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Out.WriteLine("{0} : {1}", i, inputArray[i]);
            }



        }
        static void SecondTask() {
            //заполняет двумерный массив без счетчика
            int arrayTofill1VerticalSize = 5, arrayTofill1HorisontalSize = 5;
            int[,] arrayTofill1 = new int[arrayTofill1VerticalSize, arrayTofill1HorisontalSize];

            for (int i = 0; i < arrayTofill1VerticalSize; i++)
            {
                for (int j = 0; j < arrayTofill1HorisontalSize; j++)
                {
                    arrayTofill1[i, j] = i*arrayTofill1VerticalSize + j;
                    Console.Out.Write("{0}\t",arrayTofill1[i,j]);
                }
                Console.Out.Write("\n");

            }

        }
        static void SpecialTask1() {

            int baseArray1SizeVertical = 3, baseArray1SizeHorisontal = 2;
            int[,] baseArray1 = {
                { 1,-1},
                { 2,0},
                { 3,0}
                   }; //new int[baseArray1SizeVertical, baseArray1SizeHorisontal];
            

            int baseArray2SizeVertical = 2, baseArray2SizeHorisontal = 2;
            int[,] baseArray2 = { { 1, 0 }, { 2, 0 } };// new int[baseArray2SizeVertical, baseArray2SizeHorisontal];

            int[,] resutArray1 = new int[baseArray1SizeVertical, baseArray1SizeHorisontal];

            if (baseArray1SizeHorisontal == baseArray2SizeVertical)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 1 ; j++)
                    {
                        resutArray1[i, j] = 0;
                        for (int z = 0; z < 2; z++)
                        {                        
                        resutArray1[i, j] += baseArray1[i, z] * baseArray2[z, j] ;
                            Console.Out.Write("{0}\t", resutArray1[i, j]);

                        }
                        Console.Out.Write("\n");

                    }

                }
            }
            else {
                Console.Out.WriteLine("Произвести умножение невозможно!");
            }

        }
    }
}
//Д\з
// найти мин и макс элемент массива и поменять их местами
//заполнить массив без счетчика
//два двум массива в согл виде, перемножить матрицы
