using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FxPro
{
    public static class StringReplaseExtension
    {
        public static string Replace2(this string current, string oldValue, string newValue)
        {
            StringBuilder str = new StringBuilder();

            int howMuch = -1;
            bool skip = false;
            foreach (char simbol in current)
            {
                foreach (char findSimbol in oldValue)
                {
                    if (skip)
                    {
                        skip = false;
                        continue;
                    }

                    if (simbol == findSimbol)
                    {
                        if (howMuch == -1)
                        {
                            skip = oldValue.Length > 1;
                            howMuch = 1;
                            break;
                        }
                        else
                        {
                            skip = true;
                            howMuch++;
                        }


                        if (howMuch == oldValue.Length)
                        {
                            str.Append(newValue);
                            howMuch = -1;
                            skip = false;
                            break;
                        }

                    }
                    else
                    {
                        skip = false;
                        howMuch = -1;
                        str.Append(simbol);
                        break;
                    }
                }
            }
            return str.ToString();
        }
    }
}