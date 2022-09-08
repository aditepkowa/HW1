public class Money
{
    private double money;

    public Money(double money)
    {
        this.money = money;
    }

    public void Calaulate()
    {

        double[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25 };
        foreach (double note in notes)
        {
            int n = (int)(money / note);
            Console.WriteLine("{0}: {1}", note, n);
            money = money - (n * note);
        }
    }

}