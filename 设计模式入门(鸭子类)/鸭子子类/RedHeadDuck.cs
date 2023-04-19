using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式入门_鸭子类_.鸭子子类
{
    //红头鸭子
    internal class RedDuck: Duck
    {
        public override void Dispaly()
        {
            Console.WriteLine("我是一只红头鸭子");
        }
    }
}
