public class ReadHeadDuck : Duck, IFlyable, IQuackable, ISwim
{
    // Métodos herdados de Duck
    public ReadHeadDuck(){
        Display();
        Console.WriteLine("ReadHead");

    }
    public void Swim(){
        Console.WriteLine("Nadando...");
    }


    public void Fly()
    {
        Console.WriteLine("Voando...");
    }

    public void Quack()
    {
        Console.WriteLine("Quaaaa!!!!");
    }
}