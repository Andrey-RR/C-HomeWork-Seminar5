// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = GetNum("Введите размер массива");
int[] array = GetArray(size); 
PrintArray(array);
int[] resNumb = GetNumb(array);

Console.WriteLine($"\nколичество четных чисел = {resNumb[0]}");

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
        result[i] = new Random().Next(100,1000);
        // Console.Write($"{result[i]} "); 
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

int[] GetNumb(int[] evenarray)
{
    int[] evennumb = new int[2]; // создали новый массив, куда кладем массив из двух переменных
    foreach (int el in evenarray)
    {
        if (el % 2 == 0) evennumb[0] += 1;
        else evennumb[1] = evennumb[1] += 1;
    }
    return evennumb;
}