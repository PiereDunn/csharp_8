class Program_1
{
    static List<int> list = new List<int>();
    static Random random = new Random();

    static void Main(string[] args)
    {
        MakeList();
        Console.ReadKey();

        RemoveElements();

        WriteSortedList();
        Console.ReadKey();
    }

    /// <summary>
    /// Задание элементов коллекции
    /// </summary>
    static void MakeList()
    {
        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
            list[i] = random.Next(0, 100);
            Console.Write($"{list[i]} ");
        }
    }

    /// <summary>
    /// Перебор элементов по критерию
    /// </summary>
    static void RemoveElements()
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >= 25 && list[i] <= 50)
            {
                list.RemoveAt(i);
                i--;
            }
        }
    }

    /// <summary>
    /// Вывод в консоль
    /// </summary>
    static void WriteSortedList()
    {
        Console.Write("\n\n");

        for (int i = 0; i < list.Count; i++)
        {
            Console.Write($"{list[i]} ");
        }
    }
}

