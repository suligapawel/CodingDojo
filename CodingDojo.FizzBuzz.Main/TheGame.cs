using System;

namespace CodingDojo.FizzBuzz.Main
{
    public class TheGame
    {
        private int _counter;

        public string Count()
        {
            _counter++;
            return _counter.ToString();
        }
    }
}
