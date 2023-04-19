using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式入门_鸭子类_.Fly实现类;
using 设计模式入门_鸭子类_.Quack实现类;

namespace 设计模式入门_鸭子类_.鸭子子类
{
    //诱饵鸭子
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Dispaly()
        {
            Console.WriteLine("我是一只诱饵鸭子");
        }

    }
}
