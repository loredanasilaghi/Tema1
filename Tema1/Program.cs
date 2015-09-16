using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public class Program
    {
        public int Problem1(int m, int n, int a)
        {
            double x = Math.Round((double)m / a) + Math.Round((double)n / a);
            return Convert.ToInt32(x);
        }

        public string Problem2(int x)
        {
            int pos1 = -1;
            int pos2 = -1;
            int pos3 = -1;
            x--;

            List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            pos2 = x / 26 - 1;
            pos3 = x % 26;
            if (pos2 >= 26)
            {
                pos1 = pos2 / 26 -1;
            }
            string result;
            if (pos1 >= 0)
            {
                pos2 -= 26;
                result = letters[pos1] + letters[pos2] + letters[pos3];
            }
            else if (pos2 >= 0)
            {
                result = letters[pos2] + letters[pos3];
            }
            else
            {
                result = letters[pos3];
            }
            return result;
        }

        public string Problem5(int x)
        {
            if (x % 2 == 0)
            {
                return "DA";
            }
            else
            {
                return "NU";
            }
        }

        public int Problem8(int x, int y, int z, int q, int w)
        {
            return (z * q * w) / (x * y);
        }

        public List<int> Problem9(int n, int x)
        {
            int a = n / (x + 1);
            int r = (n * x) / (x + 1);
            List<int> list = new List<int>();
            list.Add(a);
            list.Add(r);
            return list;
        }




        static void Main(string[] args)
        {
        }
    }
}
