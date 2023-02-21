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
                /* for (int j = 0; j < n;j++)
                 {
                     char[] y = words[j].ToCharArray();
                     if (y[0] != Convert.ToChar(start[i,0])){
                         words.RemoveAt(j);
                         n = n - 1;
                     }
                 }*/
            }
            /*(не работает)for (int write = 0; write < start.Length/2 - 1; write++)
            {
                for (int sort = 0; sort < start.Length/2 - 2; sort++)
                {
                    if (Convert.ToInt32(Convert.ToChar(start[sort, 0])) > Convert.ToInt32(Convert.ToChar(start[sort + 1,0])))
                    {
                        string temp1 = start[sort + 1, 0];
                        string temp2 = start[sort + 1, 1];
                        start[sort + 1, 0] = start[sort, 0];
                        start[sort, 0] = temp1;
                        start[sort + 1, 1] = start[sort, 1];
                        start[sort, 1] = temp2;
                    }
                }
            }*/

            int w = Convert.ToInt32(Console.ReadLine());
            string[,] end = new string[w, 2];
            for (int i = 0; i < w; i++)
            {
                string[] a = Console.ReadLine().Split();
                end[i, 0] = a[0];
                end[i, 1] = a[1];
                /*for (int j = 0; j < n; j++)
                {
                    char[] y = words[j].ToCharArray();
                    if (y[words.Count()] != Convert.ToChar(end[i, 0]))
                    {
                        words.RemoveAt(j);
                        n = n - 1;
                    }
                }*/
            }
            /*(не работает)for (int write = 0; write < end.Length/2-1; write++)
            {
                for (int sort = 0; sort < end.Length/2 - 2; sort++)
                {
                    if (Convert.ToInt32(Convert.ToChar(end[sort, 0])) > Convert.ToInt32(Convert.ToChar(end[sort + 1, 0])))
                    {
                        string temp1 = end[sort + 1, 0];
                        string temp2 = end[sort + 1, 1];
                        end[sort + 1, 0] = end[sort, 0];
                        end[sort, 0] = temp1;
                        end[sort + 1, 1] = end[sort, 1];
                        end[sort, 1] = temp2;
                    }
                }
            }*/
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
                    }
                }
                for (int o = 0; o<w; o++)
                {
                    char[] y = words[i].ToArray();
                    if (y[y.Length-1] == Convert.ToChar(end[o, 0]) && Convert.ToUInt32(end[0,1])!=0)
                    {
                        t = o;
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
