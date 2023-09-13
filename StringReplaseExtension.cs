using System;
using System.Reflection;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FxPro
{
    public static class StringReplaseExtension
    {
        public static string Replace2(this string current, string oldValue, string newValue)
        {
            StringBuilder str = new StringBuilder();
            int i = 0;

            while (i < current.Length)
            {
                bool mutch = true;

                for (int j = 0; j < oldValue.Length; j++)
                {
                    if (i + j >= current.Length || current[i + j] != oldValue[j])
                    {
                        mutch = false;
                        break;
                    }
                }

                if (mutch)
                {
                    str.Append(newValue);
                    i += oldValue.Length;
                }
                else
                {
                    str.Append(current[i]);
                    i++;
                }
            }
            return str.ToString();
        }
    }
}