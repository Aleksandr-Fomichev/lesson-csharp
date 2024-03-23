// See https://aka.ms/new-console-template for more information
// Задайте масс           х целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2




// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else
//         {
//             Console.Write($"{array[i]}");
//         }

//     }
//     Console.Write("]");
// }

// int CountPrime(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(IsPrime(array[i])) count++;
//     }

//     return count;
// }

// // 2 3 4 5 6 7 8 9 10 11 12 13
// bool IsPrime(int num)
// {
//     for (int i = 2; i <= Math.Sqrt(num); i++)
//     {
//         if(num % i == 0) return false;
//     }
//     return true;
// }

// int[] arr = CreateArrayRndInt(10, 1, 1000);
// PrintArray(arr);

// Console.WriteLine();

// int result = CountPrime(arr);
// Console.WriteLine(result);







// int[] CreateArrayRndInt(int size, int min, int max)
// {
// 	int[] array = new int[size];
// 	Random rnd = new Random();

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		array[i] = rnd.Next(min, max);
// 	}
// 	return array;
// }

// void PrintArray(int[] array)
// {
// 	Console.Write("[");
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (i < array.Length - 1)
// 		{
// 			Console.Write($"{array[i]}, ");
// 		}
// 		else
// 		{
// 			Console.Write($"{array[i]}");
// 		}

// 	}
// 	Console.Write("]");
// }

// int NumberCountCheck(int[] arr)
// {
// 	int count = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 10 == 1 && arr[i] % 7 == 0) count++;
// 	}
// 	return count;
// }

// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArrayRndInt(n, 1, 100);
// PrintArray(newArray);
// Console.WriteLine();
// Console.WriteLine(NumberCountCheck(newArray));


// int[] CreateArrayRndInt(int size, int min, int max)
// {
// 	int[] array = new int[size];
// 	Random rnd = new Random();

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		array[i] = rnd.Next(min, max);
// 	}
// 	return array;
// }

// void PrintArray(int[] array)
// {
// 	Console.Write("[");
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (i < array.Length - 1)
// 		{
// 			Console.Write($"{array[i]}, ");
// 		}
// 		else
// 		{
// 			Console.Write($"{array[i]}");
// 		}

// 	}
// 	Console.Write("]");
// }

// int NumberCountCheck(int[] arr,int lastDigit, int multiple)
// {
// 	int count = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 10 == lastDigit && arr[i] % multiple == 0) count++;
// 	}
// 	return count;
// }

// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArrayRndInt(n, 1, 100);
// PrintArray(newArray);
// Console.WriteLine();
// Console.WriteLine(NumberCountCheck(newArray,1,7));











// //Разница между максимальным и минимальным элементов массива

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива
    
//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         //Напишите свое решение здесь
//         double min = numbers[0];
//       foreach(double e in numbers)
//       {
//         if (e < min)
//           min = e;
//       }
//       return min;
//     }
    
//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         //Напишите свое решение здесь
//       double max = numbers[0];
//       foreach(double e in numbers)
//        {
//         if (e > max)
//           max = e;
//        }
//        return max;
//     }
    
    
    
//     public static void PrintResult(double[] array)
//     {
//         //Напишите свое решение здесь
//       double a = FindMax(array) - FindMin(array);
//       Console.Write(a);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }



// НЕРЕШЕННАЯ ЗАДАЧА.

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//       int arr = 0;
//       int count = 0;
//       for(int i = 0; i < arr.Length; i++)
//       {
//         if (numbers[i] % 2 == 0)
//         {
//           count = count + 1;
//         }

//       }
//       return count;
//     }
    
//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь 
//     int count = CountEvenItems(array);
//       Console.Write(count);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }