// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите любые числа (через пробел): ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] massiv = new int[5];
FillArray(massiv);
PrintArray(massiv);