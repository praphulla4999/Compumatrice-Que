using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formatted_string_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1,s2;
          
            String[] sub = new String[100];
            String[] sub2 = new String[100];
            
            int len;
            Console.Write("Enter String = ");
            s1 = Console.ReadLine();
            
            s2 = new string(s1.Where(c => Char.IsDigit(c)).ToArray());

            len = Convert.ToInt32(s2.Length);
           
            String[] new_sub = new String[len / 3];
            if (len % 3 == 0)
            {
                int a, b;
                a = 0;
                b = 3;
                for (int j = 0; j < len / 3; j++)
                {
                    sub[j] = s2.Substring(a, b);
                    a = a + 3;
                }

                for (int i = 0; i < len / 3; i++)
                {
                    new_sub[i] = sub[i];
                }

                Console.Write("New String in Required Format:- ");
                int k = 0;
                do
                {
                    if (k == (len / 3)-1)
                    {
                        Console.Write(new_sub[k]);
                        k++;
                    }
                    else 
                    {
                        Console.Write(new_sub[k] + "-");
                        k++;
                    }

                } while (k < len/3);
            }

            else 
            {
                if (len % 3 == 1)
                {
                    int a, b;
                    a = len - 2;
                    b = 2;
                    for (int j = 0; j < 2; j++)
                    {
                        sub2[j] = s2.Substring(a, b);
                        a = a - 2;
                    }
                    a = 0;
                    b = 3;
                    String[] new_sub1 = new String[(len / 3)+1];
                    for (int j = 2; j < (len / 3)+1; j++)
                    {
                        sub2[j] = s2.Substring(a, b);
                        a = a + 3;
                    }

                    for (int i = 0; i <(len/3)+1; i++)
                    {
                        new_sub1[i] = sub2[i];
                    }

                    Console.Write("New String in Required Format:- ");
                    int k = 2;
                    do
                    {
                        Console.Write(new_sub1[k]+"-");
                        k++;
                    } while (k<(len / 3) + 1);

                    Console.Write(new_sub1[1] + "-");
                    Console.Write(new_sub1[0]);

                }

               if (len % 3 == 2)
                {
                    int a, b;
                    a = len - 2;
                    b = 2;
                    for (int j = 0; j < 1; j++)
                    {
                        sub2[j] = s2.Substring(a, b);
                        a = a - 2;
                    }

                    a = 0;
                    b = 3;
                    String[] new_sub1 = new String[(len / 3)+1];
                    for (int j = 1; j < (len / 3)+1; j++)
                    {
                        sub2[j] = s2.Substring(a, b);
                        a = a + 3;
                    }

                    for (int i = 0; i < (len / 3)+1; i++)
                    {
                        new_sub1[i] = sub2[i];
                    }

                    Console.Write("New String in Required Format:- ");
                    int k = 1;
                    do
                    {
                        Console.Write(new_sub1[k] + "-");
                        k++;
                    } while (k < (len / 3)+1);

                    Console.Write(new_sub1[0]);

                }
            }

            Console.ReadKey();

        }
    }
}
