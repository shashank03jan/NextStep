using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Event_Delegate
    {
        public static void CallMe()
        {
            MethodCall();
        }

        static void MethodCall()
        {
            var class2Obj = new Class2();
            //look at the commented line. we can directly point a method ( with same paramaeter as delegate defined in publisher class)
            //class2Obj.EmployeeInserted+=new Class2.EmployeeInsertionEventHandler(class2Obj_EmployeeInserted);
            class2Obj.EmployeeInserted += class2Obj_EmployeeInserted;
            class2Obj.RaiseEvent();


        }
        //see this code. i have given this a static. because i am calling this inside a static method. so that means subsciber method can also be like this.
        static void class2Obj_EmployeeInserted(object source, EventArgs args)
        {
            Console.WriteLine("i am subsriber or even handler");
        }
        class Class2
        {
            //first we need to define a delegate with signature of the method it is going to refer.
            public delegate void EmployeeInsertionEventHandler(object source, EventArgs args);

            //then describe an event. to understand below line, we can think of event as some keyword before  some already described delegate (EmployeeInsertionEventHandler)
            //and then creating a variable of this delegate. Now this variable means, it should pointing to some method but which method.? dont know. i will explain you.
            //the subsriber class will add a method to this delegate i.e. the subsriber class will subscribe to this event (or event degate) and then add (or point) a method.
            // just look at the subsriber class now. you will understand it.
            //now this event (or even delegate ) variable 'EmployeeInserted' is not null now. it is pointing to some method now.
            //now we have a delegate (or event delegate) which is pointing to some method, now we can call this method by simply calling invoke().
            //finally in simple word, we can assume that if we add prefix 'event' before some delegate, it becomes an event (or event delegate) and thus publisher and then
            // any other class can then subcribe to it by pointing a method.
            public event EmployeeInsertionEventHandler EmployeeInserted;

            //look at below line. c# comipler already comes up with predefined delegate 'EventHandler' so we dont need to define a delegate saparatly.
            public event EventHandler EmployeeDeleted;

            public void RaiseEvent()
            {
                Console.WriteLine("i am publisher and now raising an event");
                OnEmployeeInserted();

                //look here, first we need to check if delegate (or event delegate) is pointing to some method or not. if so, just invoke that method.
                //look at closly that, we can call using invoke() as well as just passing parameters in delegate itself with open-close braces.
                //if (EmployeeInserted != null)
                //{
                //    Console.WriteLine("Raising Event");
                //    EmployeeInserted.Invoke(this, EventArgs.Empty);
                //    //EmployeeInserted(this, EventArgs.Empty);
                //    Console.WriteLine("I am raised, handled and returned");
                //}
            }

            //we  follow a naming convention to declare this method. it should be started with 'On' and then delegate (or event delegate ) variable name. with protected and visrtual
            // we define it as protected virtual so that any derive class can override it according to the requirement. but it is need not to be neccessary.
            //also we can directly use this code in some other method according to the logic and raise this event.
            //so it is perfectly fine to not declare it as method and virtual,protected. but usually we do it.
            protected virtual void OnEmployeeInserted()
            {
                //look here, first we need to check if delegate (or event delegate) is pointing to some method or not. if so, just invoke that method.
                //look at closly that, we can call using invoke() as well as just passing parameters in delegate itself with open-close braces.
                if (EmployeeInserted != null)
                {
                    Console.WriteLine("Raising Event");
                    EmployeeInserted.Invoke(this, EventArgs.Empty);
                    //EmployeeInserted(this, EventArgs.Empty);
                    Console.WriteLine("I am raised, handled and returned");
                }
            }
        }

    }

}
