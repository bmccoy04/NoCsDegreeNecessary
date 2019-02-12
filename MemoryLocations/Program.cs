using System;

namespace MemoryLocations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memory location example!");
            var run = true;
            while(run){
                Console.Write("Enter an option: ");
                var option = Console.ReadLine();
                
                Console.WriteLine(" ");

                if(option == "0" || option == string.Empty || option.ToLower() == "exit")
                    run = false;
                else
                    RunOptions(option);
                Console.WriteLine(" ");
            }
        }


        public static void RunOptions(string option)
        {
            switch (option)
            {
                case "1":
                    Console.WriteLine("Stack Reference method:");
                    var srm = new StackReferenceMethod();
                    srm.DoStuff();
                    break;
                case "2":
                    Console.WriteLine("Stack Reference w/ parameters:");
                    var srp = new StackReferenceParam();
                    srp.DoStuff();
                    break;
                case "3":
                    Console.WriteLine("Heap Reference method:");
                    var hrm = new HeapReferenceMethod();
                    hrm.DoStuff();
                    break;
                case "4":
                    Console.WriteLine("Heap Reference w/ parameters:");
                    var hrp = new HeapReferenceParam();
                    hrp.DoStuff();
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
        }
    }
}
