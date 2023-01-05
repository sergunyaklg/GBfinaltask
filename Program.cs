// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Main()
{
    Console.WriteLine("Введите элементы массива через запятую:");
    string[] originalArray = Console.ReadLine().Split(',');
    
    string[] newArray = GetShortStrings(originalArray);

    Console.WriteLine("Новый массив:");
    foreach (string s in newArray)
    {
        Console.WriteLine(s);
    }
}

string[] GetShortStrings(string[] originalArray)
{
    List<string> newArray = new List<string>();

    foreach (string s in originalArray)
    {
        if (s.Length <= 3)
        {
            newArray.Add(s);
        }
    }

    return newArray.ToArray();
}

Main();