using DuckTales.Abilities.Fly;
using DuckTales.Abilities.Quacks;

namespace DuckTales.TypesOfDucks
{
    internal class ToyDuck : Duck
    {
        public ToyDuck()
        {
            Fly = new NotFly();
            Quack = new ToyQuack();
        }
    }
}
