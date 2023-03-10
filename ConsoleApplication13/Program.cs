using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> words = new List<string>();
            for (int i = 0; i < n;i++ )
            {
                words.Add(Console.ReadLine());
            }
            words.Sort();
            int l = Convert.ToInt32(Console.ReadLine());
            string[,] start = new string[l,2];
            for (int i = 0; i < l; i++)
            {
                string[] a = Console.ReadLine().Split();
                start[i, 0] = a[0];
                start[i, 1] = a[1];
            }
            
            int w = Convert.ToInt32(Console.ReadLine());
            string[,] end = new string[w, 2];
            for (int i = 0; i < w; i++)
            {
                string[] a = Console.ReadLine().Split();
                end[i, 0] = a[0];
                end[i, 1] = a[1];
            }
            
            //--------------------------------------------------------------------------
            int counter = 0;
            for (int i = 0; i<n;i++)
            {
                int k = -1;
                int t = -1;
                for (int j = 0;j<l;j++)
                {
                    char[] y = words[i].ToArray();
                    if (y[0] == Convert.ToChar(start[j,0]) && Convert.ToInt32(start[j,1])!=0)
                    {
                        k = j;
                        break;
                    }
                }
                for (int o = 0; o<w; o++)
                {
                    char[] y = words[i].ToArray();
                    if (y[y.Length-1] == Convert.ToChar(end[o, 0]) && Convert.ToInt32(end[o,1])!=0)
                    {
                        t = o;
                        break;
                    }
                }
                if (k!=-1 && t!=-1)
                {
                    counter++;
                    start[k, 1] = Convert.ToString(Convert.ToInt32(start[k, 1]) - 1);
                    end[t, 1] = Convert.ToString(Convert.ToInt32(end[t, 1]) - 1);
                }
            }
            Console.WriteLine(counter);
        }
    }
}
