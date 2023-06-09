namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = "";
            while ((commands = Console.ReadLine()) != "end")
            {
                List<string> command = commands.Split().ToList();
                int number = int.Parse(command[1]);
                int index = 0;
                if (command.Count > 2 )
                {
                    index = int.Parse(command[2]);
                }
                switch (command[0])
                {
                    case "Add": listOfIntegers.Add(number); break;
                    case "Remove": listOfIntegers.Remove(number); break;
                    case "RemoveAt": listOfIntegers.RemoveAt(number); break;
                    case "Insert": listOfIntegers.Insert(index, number); break;
                }
                
            }
            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}