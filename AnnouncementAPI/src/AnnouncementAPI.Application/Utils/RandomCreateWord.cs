using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Utils
{
    public static class RandomCreateWord
    {
        public static string RandomWord()
        {
            string kelime = "";
            var rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                kelime += ((char)rnd.Next('A', 'Z')).ToString();
            }

            return kelime;
        }
    }
}
