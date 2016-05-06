using System;

namespace lab3
{
    class Lcg
    {
        private int _a, _b, _c, _t;

        public int A
        {
            get { return _a; }
        }

        public int B
        {
            get { return _b; }
        }

        public int C
        {
            get { return _c; }
        }

        public int T
        {
            get { return _t; }
            set { _t = value; }
        }

        public Lcg(int a, int b, int c, int t)
        {
            if (c % 2 == 0)
                throw new ArgumentException("Number C must be odd", "c");

            if (a % 4 != 1)
                throw new ArgumentException("Number A must be such (A mod 4 == 1)", "a");

            _a = a;
            _b = b;
            _c = c;
            _t = t;
        }

        public int Generate()
        {
            _t = (_a * _t + _c) % _b;
            return _t;
        }

        public int[] Generate(int count)
        {
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
                result[i] = Generate();

            return result;
        }
    }
}
