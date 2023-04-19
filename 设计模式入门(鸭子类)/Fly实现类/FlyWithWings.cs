using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式入门_鸭子类_.Fly实现类
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("两只翅膀飞的高");
    }
}
