using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DynamicPolymorphism_Overriding  // Late binding
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass c1 = new MyDerivedClass();
            c1.MyMethod();                     // With using polymorphism (Method Overriding) - MyMethod* from derived class will revoke! (Overriding)

            Console.WriteLine("\n");

            c1.MyMethod2();


            Console.ReadKey();

        }
    }
   abstract class MyBaseClass
    {
        public virtual void MyMethod()      // Using -Virtual-Keyword for method of Base Class (A)
        {
            Console.WriteLine("I am BASE method");
        }


        public abstract void MyMethod2();     // Using -Abstract- keyword ; means doesn't need to implement method in base class ! (B)

    }
    class MyDerivedClass: MyBaseClass
    {
       public override void MyMethod()    // Using -Override-Keyword for method of Derived Class (A)
        {
            Console.WriteLine("I am CHILD method");
        }

        public override void MyMethod2()    // Using -Override- keyword for Derived class's Method + Implement BaseClass Method (Compulsoy)  (B)
        {
            Console.WriteLine("I am Implemented abstract method of Base Class in Derived Class");
        }
    }
}
