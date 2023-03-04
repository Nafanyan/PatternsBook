
using DuckTales.IAbilities;

namespace DuckTales.Abilities.Quacks
{
    internal class QuackDucks : IQuack
    {
        void IQuack.QuackToDo()
        {
            Console.WriteLine("Quack quack quack I am alive!");
        }
    }
}
