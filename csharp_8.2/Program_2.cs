
class Program_2
{
    static Dictionary<string,string> directory = new Dictionary<string,string>();

    static void Main(string[] args)
    {
        char key;

        do
        {
            Console.Write(
              " 1 - ввести телефон и имя." +
              " 2 - найти абонента по номеру. \n");
            key = Console.ReadKey(true).KeyChar;



            if (char.ToLower(key) == '1')       // 1 Ввод номера и имени
            {

                bool flag = false;

                do
                {
                    Console.Write("Введите номер. \n");
                    string number = Console.ReadLine();

                    Console.Write("Введите имя абонента. \n");
                    string name = Console.ReadLine();

                    //Проверка значений переменных
                    if (number != string.Empty && name != string.Empty && Int64.TryParse(number, out Int64 num))
                    {
                        Input(number, name);
                    }
                    else if(number == string.Empty && name == string.Empty)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.Write("Данные введены некорректно. \n");
                    }
                } while (!flag);
                
            }
            else if (char.ToLower(key) == '2')  // 2 Вывод данных по номеру телефона
            {
                Console.Write("Введите номер. \n");

                string number = Console.ReadLine();

                //Проверка значений переменных
                if (Int64.TryParse(number, out Int64 num))
                {
                    Output(number);
                }
                else
                {
                    Console.Write("Номер введен неверно\n");
                }
            }

            Console.WriteLine("Продолжить работу д/н");
            key = Console.ReadKey(true).KeyChar;
        } while (char.ToLower(key) == 'д' || char.ToLower(key) == 'l');
       
    }

    /// <summary>
    /// Ввод номера и имени
    /// </summary>
    static void Input(string number, string name)
    {
        directory.Add(number, name);
        Console.Write("Абонент добавлен!\n");
    }

    /// <summary>
    /// Вывод данных по номеру телефона
    /// </summary>
    static void Output(string number)
    {
        if(directory.ContainsKey(number))
        {
            Console.Write($"{directory[number]}\n");
        }
        else
        {
            Console.Write("Абонента с таким номером не существует\n");
        }
    }
}