using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Sealed_Override
    {
        //you can only use sealed keyword with override. so using it with virtual or simply using sealed with simple base class method is not allowed. see commented methods

        class BaseClasee
        {
            
            public virtual void Method1()
            {
            }
            public virtual void Method2()
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

            public sealed override void Method2()
            {
            }
        }
        class DerivedClass2 : DerivedClass
        {
            public override void Method1()
            {
                base.Method1();
            }

            //can not override again b/c it is sealed in just upper base class "DerivedClass2". uncomment and see
            //public  override void Method2()
            //{
            //}
        }
    }
    
}
