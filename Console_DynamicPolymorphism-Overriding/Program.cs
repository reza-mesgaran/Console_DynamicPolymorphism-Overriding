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

            Console.ReadKey();

        }
    }
   class MyBaseClass
    {
        public virtual void MyMethod()      // Using -Virtual-Keyword for method of Base Class
        {
            Console.WriteLine("I am BASE method");
        }
    }
    class MyDerivedClass: MyBaseClass
    {
       public override void MyMethod()    // Using -Override-Keyword for method of Derived Class
        {
            Console.WriteLine("I am CHILD method");
        }
    }
}
