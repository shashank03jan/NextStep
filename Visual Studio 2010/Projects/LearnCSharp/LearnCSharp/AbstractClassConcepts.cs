using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp4
{
    //see how we can avoid implementation of an interface method in derive class using abstract
   abstract  class AbstractClassConcepts : IMyInterface 
    {
       public static void CallMe()
       {
       }

        public abstract void Method1(int i);


        public void Method2(int i)
        {
            throw new NotImplementedException();
        }
    }
     interface IMyInterface
        {
            void Method1(int i);
            void Method2(int i);
        }
    //even though we comment below derived class , no error.
     class MyClass : AbstractClassConcepts
     {
         public override void Method1(int i)
         {
             //throw new NotImplementedException();
         }
     }
    abstract class MyClass4 : MyClass3
     {
        public abstract  void methos();
        
     }
     class MyClass3 
     {
         public void methos()
         {
         }
     }

    
}

