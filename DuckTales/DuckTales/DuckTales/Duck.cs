
using DuckTales.IAbilities;

namespace DuckTales
{
    abstract internal class Duck
    {
        private IFly _fly;
        private IQuack _quack;

        public IFly Fly
        {
            set
            {
                _fly = value;
            }
        }

        public IQuack Quack
        {
            set
            {
                _quack = value;
            }
        }

        public void DuckFly() => _fly.FlyToDo();

        public void DuckQuack() => _quack.QuackToDo();
    }
}
