
using DuckTales;
using DuckTales.Abilities.Fly;
using DuckTales.TypesOfDucks;

internal class Program
{
    private static void Main(string[] args)
    {

        Duck toyDuck = new ToyDuck();
        toyDuck.DuckFly();
        toyDuck.DuckQuack();

        toyDuck.Fly = new RocketFly();
        toyDuck.DuckFly();

    }
}