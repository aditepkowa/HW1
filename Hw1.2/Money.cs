public class Money
{
    private double money;

    public Money(double money)
    {
        this.money = money;
    }

    public void Calaulate()
    {
        int n = (int)(money / 1000);
        Console.WriteLine("1000: {0}", n);
        money = money - (n * 1000);

        n = (int)(money / 500);
        Console.WriteLine("500: {0}", n);
        money = money - (n * 500);

        n = (int)(money / 100);
        Console.WriteLine("100: {0}", n);
        money = money - (n * 100);

        n = (int)(money / 50);
        Console.WriteLine("50: {0}", n);
        money = money - (n * 50);

        n = (int)(money / 20);
        Console.WriteLine("20: {0}", n);
        money = money - (n * 20);

        n = (int)(money / 10);
        Console.WriteLine("10: {0}", n);
        money = money - (n * 10);

        n = (int)(money / 5);
        Console.WriteLine("5: {0}", n);
        money = money - (n * 5);

        n = (int)(money / 2);
        Console.WriteLine("2: {0}", n);
        money = money - (n * 2);

        n = (int)(money / 1);
        Console.WriteLine("1: {0}", n);
        money = money - (n * 1);

        n = (int)(money / .5);
        Console.WriteLine(".5: {0}", n);
        money = money - (n * .5);

        n = (int)(money / .25);
        Console.WriteLine(".25: {0}", n);
        money = money - (n * .25);
    }

}