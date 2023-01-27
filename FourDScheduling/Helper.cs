using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDScheduling
{
    public class Helper
    {

        public static string shortenString(string orginalString, int maxLength)
        {
            StringBuilder sb = new StringBuilder(orginalString);
            int stringLength = orginalString.Length;

            if (stringLength > maxLength)
            {
                int removeLength = stringLength - maxLength;
                int removeStart = maxLength / 4;
                sb.Remove(removeStart, removeLength);
                sb.Insert(removeStart, "...");
            }

            return sb.ToString();
        }


    }
}
