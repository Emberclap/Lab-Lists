using System.Runtime.CompilerServices;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            bool listIsChanged = false;
            string commands = "";
            while ((commands = Console.ReadLine()) != "end")
            {
                List<string> command = commands.Split().ToList();
                if (command[0] == "Filter")
                {
                    Filter(listOfIntegers, command);
                    continue;
                }
                int index = 0;
                int number = 0;
                if (command.Count > 1 )
                {
                    number = int.Parse(command[1]);
                }
                switch (command[0])
                {
                    case "Add": listOfIntegers.Add(number); listIsChanged = true; break;
                    case "Remove": listOfIntegers.Remove(number); listIsChanged = true; break;
                    case "RemoveAt": listOfIntegers.RemoveAt(number); listIsChanged = true; break;
                    case "Insert": index = int.Parse(command[2]); listOfIntegers.Insert(index, number); listIsChanged = true; break;
                    case "Contains": Contains(listOfIntegers, command); break;
                    case "PrintEven": PrintEven(listOfIntegers);  break;
                    case "PrintOdd": PrintOdd(listOfIntegers); break;
                    case "GetSum": Console.WriteLine(listOfIntegers.Sum()); break;
                }
            }
            if (listIsChanged)
            {
            Console.WriteLine(string.Join(" ", listOfIntegers));
            }
            
        }
        static void Filter(List<int>listOfIntegers, List<string> command)
        {
            int number = int.Parse(command[2]);
            
            if (command[1] == ">=")
            {
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    if (listOfIntegers[i] >= number)
                    {
                        Console.Write(listOfIntegers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[1] == "<=")
            {
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    if (listOfIntegers[i] <= number)
                    {
                        Console.Write(listOfIntegers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            
            if (command[1] == ">")
            {
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    if (listOfIntegers[i] > number)
                    {
                        Console.Write(listOfIntegers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[1] == "<")
            {
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    if (listOfIntegers[i] < number)
                    {
                        Console.Write(listOfIntegers[i] + " ");
                    }
                }
                Console.WriteLine();
            } 
        }
        static void Contains(List<int> listOfIntegers, List<string> command)
        {
            int number = int.Parse(command[1]);
            if (listOfIntegers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> listOfIntegers)
        {
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] % 2 == 0)
                {
                    Console.Write(listOfIntegers[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<int> listOfIntegers)
        {
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] % 2 == 1)
                {
                    Console.Write(listOfIntegers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}