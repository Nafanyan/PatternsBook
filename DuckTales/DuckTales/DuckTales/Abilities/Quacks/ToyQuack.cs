
using DuckTales.IAbilities;

namespace DuckTales.Abilities.Quacks
{
    internal class ToyQuack : IQuack
    {
        void IQuack.QuackToDo()
        {
            Console.WriteLine("Quack pi Quack pi");
        }
    }
}
