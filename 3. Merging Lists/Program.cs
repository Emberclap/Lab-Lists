namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
          
            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int lenght = 0;
            if (list.Count > list2.Count)
            {
                lenght = list.Count;
            }
            else
            {
                lenght = list2.Count;
            }
            for (int i = 0; i < lenght; i++)
            {
                if (i < list.Count)
                {
                result.Add(list[i]);
                }
                if (i < list2.Count)
                {
                result.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}