// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array1 = new string [] {"Russia", "Denmark", "Kazan", "Hello", "2", "world", ":-*"};

string [] GetTreeSymbolArray (string [] newArray)
{
    int count = 0;
    
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        count++;
    }
    string [] threeSymbolArray = new string [count];
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        {
            threeSymbolArray[j] = newArray[i];
            j++;
        }
    }
    return threeSymbolArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


PrintArray(GetTreeSymbolArray(array1));
