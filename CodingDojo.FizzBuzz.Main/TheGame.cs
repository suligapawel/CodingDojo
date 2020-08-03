using System;

namespace CodingDojo.FizzBuzz.Main
{
    public class TheGame
    {
        private int _counter;

        public string Count()
        {
            _counter++;

            if (_counter % 3 == 0)
                return "Fizz";

            return _counter.ToString();
        }
    }
}
