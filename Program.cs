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