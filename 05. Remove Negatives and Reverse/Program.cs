namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> listOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] < 0)
                {
                    listOfIntegers.Remove(listOfIntegers[i]);
                    i--;
                }
            }
            listOfIntegers.Reverse();
            if (listOfIntegers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listOfIntegers));
            }
            else
            {
                Console.WriteLine("empty");
            }        
        }
    }
}