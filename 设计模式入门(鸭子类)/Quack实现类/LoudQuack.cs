using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式入门_鸭子类_.Quack实现类
{
    internal class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("我叫的可大声了，嘎嘎嘎");
        }
    }
}
