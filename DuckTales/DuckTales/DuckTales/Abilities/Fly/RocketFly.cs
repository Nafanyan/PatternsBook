﻿
using DuckTales.IAbilities;

namespace DuckTales.Abilities.Fly
{
    internal class RocketFly : IFly
    {
        void IFly.FlyToDo()
        {
            Console.WriteLine("I am fly on Rocket");
        }
    }
}
