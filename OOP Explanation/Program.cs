using System;

namespace OOP_Explanation
{
    /* Inheritance is when one class inherits properties from another class, usually a Base Class.
     * This allows the new class to act according to the Base Class withouth the need to reiterate
     * the same things over and over.*/
    public class BaseClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }
    public class ChildClass : BaseClass
    {

    }

    /* Encapsulation is using getters and setters within a class or object.*/

    public class EncapsulationClass
    {
        public int MyProperty { get; set; }
    }


    interface ISmiley
    {

    }
    /* Abstraction, while often used with encapsulation, varies as abstraction is hiding implementation using abstract classes and interfaces.
        * A common view is from interfaces.*/
    abstract class Happy : ISmiley
    {

    }

    class Program
    {
        /* Polymorhpism is the ability to use the same interface for differing underlying forms.
         * In this example, the "DoSomething" method would all be the same method, just with differing parameters.
        */

        public static void DoSomething() { }
        public static void DoSomething(int a) { }
        public static void DoSomething(string b) { }

        static void Main(string[] args)
        {
            DoSomething(5);
            DoSomething("hey");
            DoSomething();
        }
    }
}
