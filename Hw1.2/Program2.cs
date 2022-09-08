public class Program2
{
    static void Main(string[] args)
    {
        Console.Write("Please input money: ");
        double inmoney = ConvertStringToInt(Console.ReadLine());

        Money money = new Money(inmoney);
        money.Calaulate();
    }
    public static double ConvertStringToInt(string value){
        if (double.TryParse(value, out double number)){
            return number;
        }
        throw new Exception ("Please input Number.");
    }

}