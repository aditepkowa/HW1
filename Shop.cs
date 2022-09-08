public class Shop{
    private string name;
    private int number;
    private string owner;
    private int value;

    public Shop(string name, int number, string owner, int value){
        this.name = name;
        this.number = number;
        this.owner = owner;
        this.value = value;
    }

    public void PrintShopInformation(){
        Console.WriteLine("—--------- Shop Information —-----");
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Number: {0}", number);
        Console.WriteLine("Owner Name: {0}", owner);
        Console.WriteLine("Registered Value: {0}", value);
        Console.WriteLine("—-----------------------------------------------------");
    }
}