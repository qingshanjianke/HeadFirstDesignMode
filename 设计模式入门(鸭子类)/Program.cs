using System.Collections;
using 设计模式入门_鸭子类_.Fly实现类;
using 设计模式入门_鸭子类_.Quack实现类;
using 设计模式入门_鸭子类_.鸭子子类;

namespace 设计模式入门_鸭子类_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new GreenDuck();
            duck.Dispaly();
            duck.Swim();
            duck.PerformFly();
            duck.PerformQuack();

            duck.SetPerformFly(new RocketFly());
            duck.PerformFly();

            DuckCall duckCall = new(new LoudQuack());
            duckCall.PerformQuack();
        }
    }
}