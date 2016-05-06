using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class GammaOverlayCipher
    {
        private int _b;

        public GammaOverlayCipher(int b)
        {
            _b = b;
        }

        public IEnumerable<int> Overlay(IEnumerable<int> text, 
                                        IEnumerable<int> gamma, 
                                                    bool subtract)
        {
            return text.Zip(gamma, (t, g) => 
                                            ((subtract) ? (t - g) : (t + g)) % _b
                            );
        }

        public IEnumerable<int> Encrypt(string text, IEnumerable<int> gamma)
        {
            if (_b > 256)
                throw new ArgumentOutOfRangeException("b", "B must be <= 256");

            IEnumerable<int> txt = from b in Encoding.ASCII.GetBytes(text) select (int)b;

            return Overlay(txt, gamma, false);
        }

        public string Decrypt(IEnumerable<int> cipherText, IEnumerable<int> gamma)
        {
            if (_b > 256)
                throw new ArgumentOutOfRangeException("b", "B must be <= 256");

            return Encoding.ASCII.GetString
                (
                    (from c in Overlay(cipherText, gamma, true) select (byte)c).ToArray()
                );
        }
    }
}