using System;

namespace FizzBuzzRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var divider = new Divider();
            var fizzBuzzPrinter = new FizzBuzzPrinter();
            var fizzBuzzResolver = new FizzBuzzResolver(fizzBuzzPrinter, divider);

            fizzBuzzResolver.Resolve();
        }
    }

    public class FizzBuzzResolver {
        private IFizzBuzzPrinter _fizzBuzzPrinter;
        private IDivisible _divider;
        private int _num1;
        private int _num2;
        private int _minNum;
        private int _maxNum;

        public FizzBuzzResolver(IFizzBuzzPrinter fizzBuzzPrinter, IDivisible divider) 
        {
            _fizzBuzzPrinter = fizzBuzzPrinter;
            _divider = divider;
            setNumbers();
        }

        public void setNumbers(int num1 = 3, int num2 = 5, int minNum = 1, int maxNum = 100)
        {
            _num1 = num1;
            _num2 = num2;
            _minNum = minNum;
            _maxNum = maxNum;
        }

        public void Resolve()
        {
            for(int i = _minNum; i <= _maxNum; i++)
            {
                bool divisibleByNumOne = _divider.DivisibleBy(i, _num1);
                bool divisibleByNumTwo = _divider.DivisibleBy(i, _num2);
                bool divisibleByBoth = divisibleByNumOne && divisibleByNumTwo;

                if(divisibleByBoth) {
                    _fizzBuzzPrinter.PrintFizzBuzz();
                } else if(divisibleByNumOne) {
                    _fizzBuzzPrinter.PrintFizz();
                } else if(divisibleByNumTwo) {
                    _fizzBuzzPrinter.PrintBuzz();
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public interface IFizzBuzzPrinter
    {
        void PrintBuzz();
        void PrintFizz();
        void PrintFizzBuzz();
    }

    public class FizzBuzzPrinter : IFizzBuzzPrinter 
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = Fizz + Buzz;
        public FizzBuzzPrinter() {

        }

        public void PrintFizz() {
            Console.WriteLine(Fizz);
        }

        public void PrintBuzz() {
            Console.WriteLine(Buzz);
        }

        public void PrintFizzBuzz() {
            Console.WriteLine(FizzBuzz);
        }
    }

    public interface IDivisible
    {
        bool DivisibleBy(int number, int divider);
    }

    public class Divider : IDivisible{
        public bool DivisibleBy(int number, int divider)
        {
            if(divider <= 0)
                throw new CantBeZeroException("The divider cant be zero!");

            return number % divider == 0;
        }
    }

    [System.Serializable]
    public class CantBeZeroException : System.Exception
    {
        public CantBeZeroException() { }
        public CantBeZeroException(string message) : base(message) { }
    }
}
