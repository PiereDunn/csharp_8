using System.Xml.Serialization;
using csharp_8._4;

class Program_4
{
    static void Main(string[] args)
    {
        Console.Write("\nВведите имя абонента: \n");
        string name = Console.ReadLine();

        Console.Write("\nВведите улицу: \n");
        string street = Console.ReadLine();

        Console.Write("\nВведите номер дома: \n");
        string house = Console.ReadLine();

        Console.Write("\nВведите номер квартиры: \n");
        string apartment = Console.ReadLine();

        Console.Write("\nВведите мобильный телефон: \n");
        string mobilephone = Console.ReadLine();

        Console.Write("\nВведите домашний телефон: \n");
        string housephone = Console.ReadLine();

        Abonent.Adress adress = new Abonent.Adress(name, street, house, apartment);
        Abonent.Phones phones = new Abonent.Phones(mobilephone, housephone);
        Abonent abonent = new Abonent(adress, phones);

        SerializeAbonent(abonent, "emp.xml");

        Console.ReadKey();
    }


    /// <summary>
    /// Создание xml файла
    /// </summary>
    /// <param name="ConcreteAbonent"></param>
    /// <param name="Path"></param>
    static void SerializeAbonent(Abonent ConcreteAbonent, string Path)
    {
        XmlSerializer xmlserializer = new XmlSerializer(typeof(Abonent));

        using (Stream fstream = new FileStream(Path, FileMode.Create, FileAccess.Write))
        {
            xmlserializer.Serialize(fstream, ConcreteAbonent);
        }
    }
}