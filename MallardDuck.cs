public class MallardDuck : Duck, IFlyable, IQuackable, ISwim
{
    public MallardDuck(){
        Display();
        Console.WriteLine("Real");
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
        Console.WriteLine("Quack!");
    }
}