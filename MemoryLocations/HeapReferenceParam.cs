using System;

namespace MemoryLocations
{
    public class HeapReferenceParam
    {
        public HeapReferenceParam()
        {

        }

        public void DoStuff()
        {
            MyComplexObject foo = new MyComplexObject() { MyComplexProperty = 4 };
            MyComplexObject bar = foo;

            Console.WriteLine(foo.MyComplexProperty);
        }

        public void ChangeBar(MyComplexObject foo)
        {
            foo.MyComplexProperty = 9;
        }
    }    
}