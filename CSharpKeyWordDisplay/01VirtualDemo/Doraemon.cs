using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKeyWordDisplay.VirtualDemo
{
    public class Doraemon : Cat
    {
        public void Bake()
        {
            base.Bark();
            Console.WriteLine("我是机器猫，我爱吃铜锣烧！");
        }
    }
}
