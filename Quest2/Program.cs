// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)  
{
	int[] result = new int[size];
	for(int i = 0; i < size; i ++)
	{
		result[i] = new Random().Next(-10, 100);
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

void OddPosition(int[] array)
{
	int parity = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
	parity = parity + array[i];
    }
    Console.Write($"Сумма чисел на нечётных позициях: {parity} ");
}


int leng = GetNumber("Введите длинну массива: ");
int[] arr =GetArray(leng);
PrintArray(arr);
OddPosition(arr);