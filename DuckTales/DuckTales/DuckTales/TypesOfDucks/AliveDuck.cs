
using DuckTales.Abilities.Fly;
using DuckTales.Abilities.Quacks;

namespace DuckTales.TypesOfDucks
{
    internal class AliveDuck : Duck
    {
        public AliveDuck() 
        {
            Fly = new Fly();
            Quack = new QuackDucks();
        }
    }
}
