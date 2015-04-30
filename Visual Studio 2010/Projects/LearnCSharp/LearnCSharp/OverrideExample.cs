using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class OverrideExample
    {
        public static void CallMe()
        {
            //nothing to call or display as of now
        }
        class MyConceptBase
        {
            //public virtual int value; // can't virtual because not allowed on fields
            public virtual int number { get; set; }

            public int EmpNumber { get; set; }
        }

        class MyConceptDerived : MyConceptBase
        {
            //overriding property from base. can't override fields because not allowed to defined them as virtual in base
            public override int number
            {
                get
                {

                    return base.number;
                }
                set
                {
                    base.number = value;
                }
            }
            int l;
            public new string EmpNumber { get; set; }// this is called shadowing , so difference bewtween shadowing and overriding is 
            //overiding does not override type like int but shadow does
        }
    }

    
}
