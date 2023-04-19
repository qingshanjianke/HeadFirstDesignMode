using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式入门_鸭子类_.Quack实现类;

namespace 设计模式入门_鸭子类_
{
    //小练习
    internal class DuckCall
    {
        public IQuackBehavior? QuackBehavior { get; set; }

        public DuckCall()
        {
            QuackBehavior = new MuteQuack();
        }

        public DuckCall(IQuackBehavior behavior)
        {
            QuackBehavior = behavior;
        }

        public void PerformQuack()
        {
            QuackBehavior?.Quack();
        }
    }
}
