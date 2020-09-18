using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKeyWordDisplay.VirtualDemo
{
    public class Garfield : Cat
    {
        public void Bake()
        {
            base.Bark();
            Console.WriteLine("我是加菲猫，我爱吃肉！");
        }
    }
}
