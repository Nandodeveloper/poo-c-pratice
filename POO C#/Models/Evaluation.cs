namespace POO_C_.Models;

internal class Evaluation
{
    public Evaluation(int rate)
    {
        Rate = rate;
    }
    public int Rate { get; }

    public static Evaluation Parse(string text)
    {
        int rate = int.Parse(text);
        return new Evaluation(rate);
    }
}
