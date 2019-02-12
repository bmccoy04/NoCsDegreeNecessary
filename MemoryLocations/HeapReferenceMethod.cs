using System;

namespace MemoryLocations
{
    public class HeapReferenceMethod
    {
        public HeapReferenceMethod()
        {

        }

        public void DoStuff()
        {
            MyComplexObject foo = new MyComplexObject() { MyComplexProperty = 4 };
            MyComplexObject bar = foo;
            bar.MyComplexProperty = 9;
            Console.WriteLine(foo.MyComplexProperty);
        }
    }    
}