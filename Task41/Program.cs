// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] massive = new double[size];
FillArray(massive);
CountPositive(massive);


void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}
void CountPositive(double[] arr)
{
int count = 0;
    for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        count++;
   
}
Console.WriteLine($"Кол-во элементов больше 0: {count}");
}