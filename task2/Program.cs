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

