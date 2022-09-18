/* Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.Clear();

// Код программы.
string[] sourceArray = {"hello", "2", "world", ":-)"};
int sizeArray = CountElement(sourceArray);
string[] requiredArray = new string[sizeArray];
requiredArray = ConvertArray(sourceArray, sizeArray);
Console.Write(string.Join(", ", requiredArray));

// Метод подсчета.
int CountElement (string[] array)
{
    int size = 0, temp = 0;
    string box = " ";
    for (int i = 0; i < array.Length; i++)
    {
        box = array[i];
        temp = box.Length;
        if (temp < 4)
            size ++;
    }
    return size;
}

// Метод формирования нового массива с учетом условий задачи.
string[] ConvertArray (string[] array, int size)
{
    int j = 0, temp = 0;
    string box = " ";
    string[] requiredArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        box = array[i];
        temp = box.Length;
        if (temp < 4)
        {
            requiredArray[j] = array[i];
            j++;
        }
    }
    return requiredArray;
}