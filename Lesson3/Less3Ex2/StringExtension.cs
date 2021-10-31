using System;
using System.Linq;
using System.Text;

namespace Less3Ex2
{
    public static class StringExtension
    {
        public static string ReverseByStringBuilder(this string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length; i-- != 0;)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public static string ReverseByCharArray(this string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            return new String(arr);
        }

        public static string ReverseByLINQ(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}