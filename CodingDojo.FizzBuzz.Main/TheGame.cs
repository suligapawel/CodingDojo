using System;

namespace CodingDojo.FizzBuzz.Main
{
    public class TheGame
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        private int _counter;

        public string Count()
        {
            _counter++;

            ValidCounter();

            if (IsFizzBuzz())
                return FIZZ + BUZZ;

            if (IsFizz())
                return FIZZ;

            if (IsBuzz())
                return BUZZ;

            return _counter.ToString();
        }

        private void ValidCounter()
        {
            if (_counter > 100)
                throw new ArgumentOutOfRangeException();
        }

        private bool IsFizzBuzz() => IsFizz() && IsBuzz();
        private bool IsBuzz() => _counter % 5 == 0;
        private bool IsFizz() => _counter % 3 == 0;
    }
}
