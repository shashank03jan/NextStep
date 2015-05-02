using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Sealed_Override
    {
        //you can only use sealed keyword with override. so using it virtual or simply using sealed with siple base class method is not allowed. see commented methods

        class BaseClasee
        {
            
            public virtual void Method1()
            {
            }
            //public sealed virtual void Method2()
            //{
            //}
            //public sealed void Method3()
            //{
            //}

        }

        class DerivedClass : BaseClasee
        {
            public override void Method1()
            {
                base.Method1();
            }
        }
    }
    
}
