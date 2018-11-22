using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMAOSoft.Inc.Misc
{
    public class KVFunctions
    {
        public bool VerifyKVSignature(byte[] KVBits)
        {
            if (KVBits.Length != 0x4000)
                return false;

            return false;
        }
    }
}
