using System;

namespace MemoryLocations
{
    public class StackReferenceMethod
    {
        public StackReferenceMethod()
        {

        }

        public void DoStuff()
        {
            int foo = 4;
            int bar = foo;
            bar = 9;
            Console.WriteLine(foo);
        }
    }    
}