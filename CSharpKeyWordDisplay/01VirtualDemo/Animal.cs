using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKeyWordDisplay.VirtualDemo
{
    public abstract class Animal
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public abstract void Bark();
    }
}
