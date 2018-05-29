using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public static class CharacterReplacer
    {
        public static string replaceAccentuatedLetters(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = replaceChar(chars[i]);
            }
            return new string(chars);
        }

        private static char replaceChar(char x)
        {
            switch(x)
            {
                case 'ö':
                    return 'o';
                case 'ü':
                    return 'u';
                case 'ó':
                    return 'o';
                case 'é':
                    return 'e';
                case 'á':
                    return 'a';
                case 'ű':
                    return 'u';
                case 'ő':
                    return 'o';
                case 'ú':
                    return 'u';
                case 'í':
                    return 'i';
                default:
                    return x;

            }
        }
    }
}
