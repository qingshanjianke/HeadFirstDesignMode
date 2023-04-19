using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式入门_鸭子类_.Fly实现类;

namespace 设计模式入门_鸭子类_
{
    internal class Duck
    {
        public IFlyBehavior? FlyBehavior { get; set; }
        public IQuackBehavior? QuackBehavior { get; set; }

        public void Swim()
        {
            Console.WriteLine("我贼会游泳");
        }

        public virtual void Dispaly()
        {
            Console.WriteLine("我有羽毛");
        }

        public void PerformFly()
        {
            FlyBehavior?.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior?.Quack();
        }

        //动态设定行为（还有Fly实现类Quack实现类底下还有很多功能没使用呢）
        public void SetPerformFly(IFlyBehavior behavior)
        {
            FlyBehavior = behavior;
        }


    }
}
