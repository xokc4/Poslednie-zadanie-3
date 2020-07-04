using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace v19_z3
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<char, string>
            {
                {'А',"A"},
                {'Б',"B"},
                {'В',"V"},
                {'Г',"G"},
                {'Д',"D"},
                {'Е',"E"},
                {'Ё',"E"},
                {'Ж',"ZH"},
                {'З',"Z"},
                {'И',"I"},
                {'Й', "Y"},
                {'К',"K"},
                {'Л',"L"},
                {'М',"M"},
                {'Н',"N"},
                {'О',"O"},
                {'П',"P"},
                {'Р',"R" },
                {'С',"S" },
                {'Т',"T" },
                {'У',"U" },
                {'Ф',"F"},
                {'Х' ," KH"},
                {'Ц',"TS" },
                {'Ч',"CH" },
                {'Ш',"SH"},
                {'Щ', "SHCH" },
                {'Ъ',string.Empty },
                {'Ы',"Y" },
                {'Ь',string.Empty },
                {'Э',"E"},
                {'Ю',"YU" },
                {'Я', "YA" }
            };

            Console.WriteLine("Введите предложение: ");
            string s = Console.ReadLine();

            var sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {

                if (dict.ContainsKey(s[i]))
                {
                    sb.Append(dict[s[i]]);
                    continue;
                }


                if (dict.ContainsKey(s.ToUpper()[i]))
                {

                    sb.Append(dict[s.ToUpper()[i]].ToLower());
                    continue;
                }

                sb.Append(s[i]);
            }

            Console.WriteLine(sb.ToString());

            Console.WriteLine("Пока");
            Console.ReadLine();
        }
    }
}
