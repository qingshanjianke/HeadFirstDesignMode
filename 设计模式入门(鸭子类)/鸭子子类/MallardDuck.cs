using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式入门_鸭子类_.Fly实现类;
using 设计模式入门_鸭子类_.Quack实现类;

namespace 设计模式入门_鸭子类_.鸭子子类
{
    //绿头鸭
    internal class GreenDuck: Duck
    {
        public GreenDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new LoudQuack();
        }

        public override void Dispaly()
        {
            Console.WriteLine("我是一只绿头鸭子");
        }
    }
}
