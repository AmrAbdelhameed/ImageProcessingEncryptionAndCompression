using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ImageQuantization
{
    class LFSR
    {
        bool[] bits;
        int pos;
        String seed;

        public LFSR(string seed, int pos)
        {
            this.pos = pos;
            this.seed = seed;
            bits = new bool[seed.Length];

            for (int i = 0; i < seed.Length; i++)
                bits[i] = seed[i] == '1' ? true : false;

        }

        public string Registry
        {
            get
            {
                char[] t = new char[bits.Length];
                for (int i = 0; i < bits.Length; i++)
                    t[i] = bits[i] ? '1' : '0';

                return new string(t);
            }
        }

        public void Shift()
        {
            for (int j = 0; j < seed.Length; ++j) { 
                bool bnew = (bits[bits.Length - 1] ^ bits[pos]);

                for (int i = bits.Length - 1; i > 0; --i)
                {
                    bits[i] = bits[i - 1];
                }
                bits[0] = bnew;
            }
        }
    }
}