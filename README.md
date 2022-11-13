# README файл

Задание выполнено на языке C#
Код программы:
```C#
void Process(string[] array)
{

    Console.WriteLine("Input:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    Console.WriteLine("Processing...");
    array = array.Where(val => val.Length <= 3).ToArray();
    Console.WriteLine("Result:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


string[] array = new string[] { "Hello", "2", "world", ":-)", "qwewqeqweq" };

Process(array);

array = new string[] { "1234", "1567", "-2", "computer science" };

Process(array);
```