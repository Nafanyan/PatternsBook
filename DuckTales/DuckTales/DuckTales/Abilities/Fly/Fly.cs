
using DuckTales.IAbilities;

namespace DuckTales.Abilities.Fly
{
    internal class Fly : IFly
    {
        void IFly.FlyToDo()
        {
            Console.WriteLine("I am flying");
        }
    }
}
