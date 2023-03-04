

using DuckTales.IAbilities;

namespace DuckTales.Abilities.Fly
{
    internal class NotFly : IFly
    {
        void IFly.FlyToDo()
        {
            Console.WriteLine("I am not can fly :(");
        }
    }
}
