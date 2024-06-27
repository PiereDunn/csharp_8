


using System.Xml.Linq;

class Program_3
{
    static HashSet<int> hashset = new HashSet<int>();

    static void Main(string[] args)
    {
        bool flag = false;
        do
        {
            Console.Write("Введите число\n");

            string number = Console.ReadLine();

            if (number != string.Empty && int.TryParse(number, out int num))
            {
                if (!hashset.Contains(Convert.ToInt32(number)))
                {
                    hashset.Add(Convert.ToInt32(number));
                    Console.Write("Число добавлено!\n");
                }
                else
                {
                    Console.Write("Число уже находится в коллекции\n");
                }
            }
            else if(number == string.Empty)
            {
                flag = true;
            }
        }while (!flag);
    }
}