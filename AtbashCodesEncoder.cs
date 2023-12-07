using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class AtbashCodesEncoder : Encoder
    {
        private char[] alth = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                            'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ы','Э','Ю','Я',
                            'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я' };
        private char[] althReverse;
        public AtbashCodesEncoder()
        {
            althReverse = new char[alth.Length];
            for (int i = 0, j = alth.Length - 1; i < alth.Length; i++)
            {
                althReverse[i] = alth[j];
                j--;
            }            
        }
        public override string Encode(string value)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < value.Length; i++)
            {
                for(int j = 0; j <alth.Length;j++)
                {
                    if (value[i] == alth[j])
                    {
                        sb.Append(althReverse[j]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
