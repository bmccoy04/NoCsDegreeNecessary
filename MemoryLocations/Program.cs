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
                    Console.WriteLine("Value Reference method");
                    break;
                case "2":
                    Console.WriteLine("Value Reference w/ parameters.");
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
        }
    }
}
