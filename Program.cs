//Задача: на вход пользователем вводится строковый массив, необходимо в консол вывести строковый массив из элементов входного
//количество символов в каждом из которых <= 3
Console.WriteLine("Введите количество элементов в исходном массиве");
int N = Convert.ToInt32(Console.ReadLine());
string[] arr = FillStringArray(N);
string[] resultArray = SortArray(arr, 3);
PrintArray(resultArray);

string[] FillStringArray(int n)
{
    string[] array = new string[n];
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

string[] SortArray(string[] arr, int m)
{
    string[] sortArray = new string[arr.Length];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        sortArray[i] = Convert.ToString(random.Next(0, 0));
    }

    int count = 0;
    for (int i = 0; i < sortArray.Length; i++)
    {
        if (arr[i].Length <= m)
        {
            sortArray[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref sortArray, count);
    return sortArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]} , ");
    }
    int a = array.Length - 1;
    Console.Write($"{array[a]} ]");

}