using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMPGest2019

{
    class LibFuncs
    {
        public string QuotedStr(String S, string C)
        {
            return C + S + C;
        }

        public string QuotedString(string str)
        {
            return ("\"" + str + "\"");
        }

        public string EncloseString(string str1, string str2)
        {
            return (str2 + str1 + str2);
        }

    }
}
