using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    //cant have private class
    //private class accessmodifiers
    //{
    //}
    //by default its 'internal' access modifier if nothing provided
    class xyz
    {
        //note here you can provide private class because it is nested
        private class abc
        { }
    }
}


//Classes and structs that are not nested within other classes or structs can be either public or internal. A type declared as public is accessible by any other type.A type declared as internal is only accessible by types within the same assembly.Classes and structs are declared as internal by default unless the keyword public is added to the class definition.

//Class or struct definitions can add the internal keyword to make their access level explicit. Access modifiers do not affect the class or struct itself — it always has access to itself and all of its own members.

//Struct members, including nested classes and structs, can be declared as public, internal, or private. Class members, including nested classes and structs, can be public, protected internal, protected, internal, or private. The access level for class members and struct members, including nested classes and structs, is private by default. Private nested types are not accessible from outside the containing type.

//Derived classes cannot have greater accessibility than their base types.In other words, you cannot have a public class B that derives from an internal class A. If this were allowed, it would have the effect of making A public, because all protected or internal members of A are accessible from the derived class.