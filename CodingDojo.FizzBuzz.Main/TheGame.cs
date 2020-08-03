﻿namespace CodingDojo.FizzBuzz.Main
{
    public class TheGame
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        private int _counter;

        public string Count()
        {
            _counter++;

            if (IsFizzBuzz())
                return FIZZ + BUZZ;

            if (IsFizz())
                return FIZZ;

            if (IsBuzz())
                return BUZZ;

            return _counter.ToString();
        }

        private bool IsFizzBuzz() => IsFizz() && IsBuzz();
        private bool IsBuzz() => _counter % 5 == 0;
        private bool IsFizz() => _counter % 3 == 0;
    }
}
