using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式入门_鸭子类_.Fly实现类
{
    internal class RocketFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我像火箭一样自由");
        }
    }
}
