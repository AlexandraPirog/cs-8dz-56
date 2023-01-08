// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
int[,] arr = new int[m, n];
FillArrayWithRandomNumbers(arr);
System.Console.WriteLine();
CountSumArray(arr,n);


int TheLineWithMinSum=0;
int sumLine = CountSumArray(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int temp = CountSumArray(arr, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    TheLineWithMinSum = i;
  }
}
System.Console.WriteLine($"строка с наименьшей суммой элементов { sumLine} имeет индекс { TheLineWithMinSum}");

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("не удалось распознать число");

    }
    return number;
}

void FillArrayWithRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int CountSumArray(int[,] arr, int i)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    return sum;
    System.Console.WriteLine($"сумма строки с индексом {i} равна {sum}");
}
