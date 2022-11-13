
void Process(string[] array)
{

    Console.WriteLine("Input:");
    foreach (string val in array)
    {
        Console.WriteLine(val);
    }

    Console.WriteLine("Processing...");
    array = array.Where(val => val.Length <= 3).ToArray();
    Console.WriteLine("Result:");

    foreach (string val in array)
    {
        Console.WriteLine(val);
    }
}


string[] array = new string[] { "Hello", "2", "world", ":-)", "qwewqeqweq" };

Process(array);

array = new string[] { "1234", "1567", "-2", "computer science" };

Process(array);