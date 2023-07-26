//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sizeArray = GetNum("ВВедите длину массива");
int[] array = GetArray(sizeArray); 
PrintArray(array);


Console.WriteLine($"Сумма нечетных элементов массива = {Sum(array)}");


int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10,10);
     }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int Sum (int[] array1)
{
   int ressum = 0;
   for (int i = 1 ; i < array1.Length; i += 2)    
      ressum += array1[i];
   return ressum;
  }