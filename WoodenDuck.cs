public class WoodenDuck : Duck, ISwim{

    public WoodenDuck(){
        Display();
        Console.WriteLine("Wooden");
    }

    public void Swim(){
        Console.WriteLine("Nadando...");
    }
}