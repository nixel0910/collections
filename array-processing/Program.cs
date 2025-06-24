string[] array = Console.ReadLine().Split();
int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string[] command = Console.ReadLine().Split();
    if (command[0] == "Reverse")
    {
        Array.Reverse(array);
    }
    else if (command[0] == "Distinct")
    {
        array = array.Distinct().ToArray();
        
    }
    else if (command[0] == "Replace")
    {
        int index = int.Parse(command[1]);
        array[index] = command[2];
    }
}

Console.WriteLine(string.Join(" ", array));
