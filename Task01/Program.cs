// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int [] GetArray(int demension)
{
    
    int[] arr = new int[demension];

    for (int i = 0; i < demension; i++)
    {
        Console.WriteLine("Введите число");
        arr[i] = int.Parse(Console.ReadLine()??"");
    }
    return arr;
}

void PrintArray(int[] array) 
{ 
for (int i = 0; i < array.Length; i++) 
{ 
Console.Write(array[i] + ", "); 
} 
Console.WriteLine(); 
} 

int CountOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел");
int demension = int.Parse(Console.ReadLine()??"");
int[] numbersFromUser = GetArray(demension);
PrintArray(numbersFromUser);
Console.WriteLine();
Console.WriteLine($"Количество введенных вами положительных чисел: {CountOfPositive(numbersFromUser)}");