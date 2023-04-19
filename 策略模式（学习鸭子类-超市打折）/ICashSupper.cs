using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_学习鸭子类_超市打折_
{
    internal interface ICashSupper
    {
        double AcceptCash(double money);
    }
}
