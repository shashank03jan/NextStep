using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class InheritenceExample
    {
        public static void CallMe()
        {
            //simple calling base class method
            Console.WriteLine(" creating base class instance and then calling methods. all base class methods are accessible");
            Class1Base objbase = new Class1Base();
            objbase.Method1Base();
            objbase.Method2Base();


            //simple calling derived class methods as well as base class methods using simple inheritence
            Console.WriteLine("creating derive class instance. See all base class methods as  well as derived class methods are accissible");
            Class1Derived objderived = new Class1Derived();
            objderived.Method1Base();
            objderived.Method2Base();
            objderived.Method3Derived();

            //
            Console.WriteLine("passing derived class instance to base class object and calling all possible methods. see only base class methods are acceessible");
            Class1Base objbase2 = new Class1Derived();
            objbase2.Method1Base();
            objbase2.Method2Base();


            //
            Console.WriteLine("passing base class object to derived class and calling all possible methods. see compile time error. if you cast then run time error.");
            //Class1Derived objderived2 = new Class1Base();
            //objderived2 =(Class1Derived) new Class1Base();
            //objderived2.Method3Derived();

            Console.WriteLine("-------------------------------------------------------------------------");

        }
        class Class1Base
        {
            public void Method1Base()
            {
                Console.WriteLine("Method1Base..");
            }
            public  void Method2Base()
            {
                Console.WriteLine("Method2Base..");
            }
        }
        class Class1Derived : Class1Base
        {
            public void Method3Derived()
            {
                Console.WriteLine("Method3Derived..");
            }
            //see it is hiding base class method and ask to use new keyword
            public void Method2Base()
            {
                Console.WriteLine("Method2Base..");
            }

        }

    }
   

}
