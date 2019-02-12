using System;

namespace MemoryLocations
{
    public class StackReferenceParam
    {
        public StackReferenceParam()
        {

        }

        public void DoStuff()
        {
            int foo = 4;
            int bar = foo;
            ChangeBar(bar);
            Console.WriteLine(foo);
        }

        public void ChangeBar(int bar)
        {
            bar = 9;
        }
    }    
}