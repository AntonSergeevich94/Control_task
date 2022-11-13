// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте ввыполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше йобойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

Console.Clear();
Console.WriteLine("Сколько строк будем вводить?");
Console.WriteLine();
int size = int.Parse(Console.ReadLine()!);
if (size <= 0) 
{
    Console.WriteLine("Число строк должно быть больше 0");
}
else
{
Console.WriteLine("Заполните строки");
string[] array = StringArray(size);
Console.WriteLine("Исходный массив");
PrintArray(array);
string[] arraynew = NewStringArray(array, size);
Console.WriteLine("Итоговый массив");
PrintArray(arraynew);
}



string[] StringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}, ");
    }
        Console.WriteLine();
}

string[] NewStringArray(string [] array, int size)
{
    int sizeNew = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) 
        {
           sizeNew = sizeNew + 1;
        } 
    }
    string[] arraynew = new string[sizeNew];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) 
        {
            arraynew[j] = array[i];
            j++;
        }
    }
return arraynew;
}