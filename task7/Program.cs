// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//     // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//         return array[x - 1, y - 1];

//     }

//     // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//         if (x <= 0 || x >= array.GetLength(0))
//         {
//             Console.Write("Позиция по рядам выходит за пределы");
//             return false;
//         }
//         if (y <= 0 || y >= array.GetLength(1))
//         {
//             Console.Write("Позиция выходит за рамки по столбцам");
//             return false;
//         }
//         return true;

//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//         int result = FindElementByPosition(numbers, x, y);
//         Console.WriteLine(result);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }
//     }
// }




using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
        int [] = new int[3, 5]


    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (i > 0 && i < array.GetLength(1))

    }

        // Обмен элементами массива
        public static void SwapItems(int[,] array, int i)
        {
            //Напишите свое решение здесь
            int temporary = array[i, j];


        }




        public static void PrintResult(int[,] numbers)
        {
            //Напишите свое решение здесь
            int temporary = array[i, j];
            array[i, j] = array[(array.GetLength(1) + 1), j];
            array[(array.GetLength(1) + 1), j] = temporary;
        }
    }

    //Не удаляйте и не меняйте класс Answer!
    class Answer
    {
        public static void Main(string[] args)
        {
            int[,] numbers;

            if (args.Length >= 1)
            {
                // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
                string[] rows = args[0].Split(',');

                int rowCount = rows.Length;
                int colCount = rows[0].Trim().Split(' ').Length;

                numbers = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] rowElements = rows[i].Trim().Split(' ');

                    for (int j = 0; j < colCount; j++)
                    {
                        if (int.TryParse(rowElements[j], out int result))
                        {
                            numbers[i, j] = result;
                        }
                        else
                        {
                            Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                            return;
                        }
                    }
                }
            }
            else
            {
                // Если аргументов на входе нет, используем примерный массив
                numbers = new int[,]
                {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
                };
            }
            UserInputToCompileForTest.PrintResult(numbers);
        }
    }






// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         //Напишите свое решение здесь

//         int min = SumRows[0];
//         for (int i = 1; i < array.GetLength; i++)




//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         //Напишите свое решение здесь
//         if (SumRows[i] <= MinIndex) ;
//         {
//             MinIndex = SumRows[i];


//         }
//     }
//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь

//         Console.WriteLine(MinIndex);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }