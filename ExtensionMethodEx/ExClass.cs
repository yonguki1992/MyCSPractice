using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEx01
{
    public static class ExClass
    {
        // 첫 파라미터로 어떤 클래스가 사용할지를 지정
        public static string ToChangeCase(this string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var ch in str)
            {
                if(ch >= 'A' && ch <= 'Z')
                {
                    sb.Append((char)('a' + (ch - 'A')));
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    sb.Append((char)('A' + (ch - 'a')));
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }

        //이 확장 메서드는 파라미터 ch 가 필요함
        public static bool Found(this string str, char ch)
        {
            return str.Contains(ch);
        }
    }
}
