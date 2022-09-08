public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input Name : ");
        string name = Console.ReadLine();

        Console.Write("Input Number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Owner Name: ");
        string owner = Console.ReadLine();

        Console.Write("Registered Value: ");
        int value = int.Parse(Console.ReadLine());


        Shop shop = new Shop(name, number, owner, value);
        shop.PrintShopInformation();
    }

}