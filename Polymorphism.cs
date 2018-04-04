using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpFundametals
{

    class Parent
    {

        public Parent()
        {
            Console.WriteLine("Parent class constructor called");
        }
        internal virtual void Write()
        {
            Console.WriteLine("parent class write method called");
        }
    }

    class child : Parent
    {
        public int MyProperty { get; set; }
        public child()
        {
            Console.WriteLine("child class constructor called");
        }

        internal sealed override void Write()
        {
            Console.WriteLine("child class write method called");
        }

    }

    class GrandChild : child
    {
        public GrandChild()
        {
            Console.WriteLine("child class constructor called");
        }

        internal new void Write()
        {
            Console.WriteLine("grand child class write method called");
        }


    }
}
