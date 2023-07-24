// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(int size)  
{
    Random rand = new Random();
	double[] result = new double[size];
	for(int i = 0; i < size; i ++)
	{
		result[i] = Math.Round(rand.NextDouble(),2);
	}
	return result; 
}

int GetNumber(string message) 
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

void PrintArray(double[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    {
        Console.Write($"{arrays[i]} ");
    }
    Console.WriteLine();
}

double SearchMin (double[] a)
{   
	double Min = a[0];
	for(int i=1; i < a.Length; i++)
	{
		if(Min>a[i])
		{
	    Min=a[i];
		}
	}
    return Min;
}

double SearchMax (double[] mass)
{
	double Max = mass[0];
    for(int i=1; i < mass.Length; i++)
    {
    if(Max<mass[i])
        {
        Max=mass[i];
        }           
    }
    return Max;
}

int leng = GetNumber("Введите длинну массива: ");
double[] arr =GetArray(leng);
PrintArray(arr);
double minimum = SearchMin(arr);
double maximum = SearchMax(arr);
Console.Write($"Разница между максимальным и минимальным элементами массива = { Math.Round((maximum-minimum),2)}");