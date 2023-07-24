// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size) 
{
	int[] result = new int[size];
	for(int i = 0; i < size; i ++)
	{
		result[i] = new Random().Next(100, 1000);
	}
	return result; 
}

int GetNumber(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumParity(int[] array)
{
	int parity = 0;
    for (int i = 0; i < array.Length; i++)
    {
	    if( array[i] %2 == 0)
		{
		parity = parity + 1;
		}
    }
    Console.Write($"Количество чётных чисел: {parity} ");
}

int leng = GetNumber("Введите длинну массива: ");
int[] arr =GetArray(leng);
PrintArray(arr);
SumParity(arr);

// int evenNumber = 0;       
// foreach (var el in arr)
// {
// 	if(el%2 == 0)
// 	{
// 		evenNumber=evenNumber + 1;
// 	}
// }
// Console.WriteLine($"Количество чётных чисел: {evenNumber}");