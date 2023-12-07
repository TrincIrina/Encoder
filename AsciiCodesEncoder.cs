using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class AsciiCodesEncoder : Encoder
    {
        public override string Encode(string value)
        {
            byte[] n = Encoding.ASCII.GetBytes(value);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n.Length; i++)
            {
                sb.Append(Convert.ToString(n[i]));
            }
            return sb.ToString();
        }

    }
}
