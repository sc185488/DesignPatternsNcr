using DesignPatterns.factoryExample2;

namespace DesignPatterns.SingleTon_DesignPattern
{

    public class client
    {
        public static void Main(string[] args)
        {
            //For Example 1

            //IState state = new FactoryClass().factoryMethod();
            //state.Get();

            //For Example 2
            new Client().Main();
        }
    }
}
