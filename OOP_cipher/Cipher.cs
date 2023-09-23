using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cipher
{
    public abstract class Cipher
    {
       

        public abstract string Encode();

        public abstract void Decode(string str);

    }
}
