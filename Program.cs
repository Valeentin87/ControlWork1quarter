//Задача: на вход пользователем вводится строковый массив, необходимо в консол вывести строковый массив из элементов входного
//количество символов в каждом из которых <= 3
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите количество элементов в исходном массиве");
int N = Convert.ToInt32(Console.ReadLine());
string[] arr = FillStringArray(N);

string[] FillStringArray(int n)
{
    string[] array = new string[n];
    string element = string.Empty;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите очередной элемент строкового массива");
        array[i] = Convert.ToString(Console.ReadLine());
        if (array[i] == String.Empty)
        {
            Console.WriteLine("вы не ввели элемент типа string - Пустой элемент");
            array[i] = Convert.ToString(Console.ReadLine());
        }

    }
    return array;
}
