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
            c1.MyMethod();                     // Without using polymorphism (Method Overriding) - MyMethod* from MyBaseClass will revoke!

            Console.ReadKey();

        }
    }
   class MyBaseClass
    {
        public void MyMethod()
        {
            Console.WriteLine("I am BASE method");
        }
    }
    class MyDerivedClass: MyBaseClass
    {
       public void MyMethod()
        {
            Console.WriteLine("I am CHILD method");
        }
    }
}
