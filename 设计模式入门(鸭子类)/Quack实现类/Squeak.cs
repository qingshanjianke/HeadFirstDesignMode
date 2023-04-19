using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式入门_鸭子类_.Quack实现类
{
    //叽叽叽
    internal class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("叽叽叽？");
        }
    }
}
