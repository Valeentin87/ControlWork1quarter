# Описание работы программы из контрольной работы

Задача: необходимо ввести строковый массив с клавиатуры и введенный массив отсортировать (оставить в конечном массиве члены, имеющие три и менее сивмола) и вывести его в консоль

## **СОДЕРЖИМОЕ РЕПОЗИТОРИЯ:**



1. *Блок-схема решения задачи (файл типа *.json) можно открыть с помощью редактора https://programforyou.ru/block-diagram-redactor

2. Файл **BlockDiagram.png** иллюстрирующий алгоритм решения задачи 

3. Файл **Program.cs** с кодом программы

## *СТРУКТУРА ПРОГРАММНОГО КОДА:*
Программа реализована на языке С# и включает в себя:
* **блок ввода с клавиатуры количества элементов в массиве**

        Console.WriteLine("Введите количество элементов в исходном массиве");

        int N = Convert.ToInt32(Console.ReadLine());

* **реализация метода ввода массива с клавиатуры** причём при вводе пустого элемента программа предложит ввести его заново

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

* **реализация метода сортировки исходного массива** и наполнения требуемого массива элементами с нужным количеством символов


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
