using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
namespace StopwatchExample;

class MyArrays
{
    static Random rnd = new Random();
    static List<int> listI = new List<int>();
    static List<string> listS = new List<string>();
    static ArrayList arrayList = new ArrayList();


    public static void SpeedTest<Tipe>(Tipe tipe, int check, int position, int num, ref string str, object num2)
    {
        int t = 0;
        string t2 = " ";
        Stopwatch stopwatch = new Stopwatch();
        if (Object.ReferenceEquals(tipe.GetType(), t.GetType()))
        {
            for (int i = 0; i < 10000000; i++)
            {
                arrayList.Add(rnd.Next(1, 20));
                listI.Add(rnd.Next(1,20));
            }

            if (check == 0)
            {
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++) 
                {
                    if (i == position)
                        listI.Insert(i, num);
                }
                stopwatch.Stop();
                Console.WriteLine("List. \n Элемент был заменён. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++) 
                {
                    if (i == position)
                        arrayList.Insert(i, num);
                }
                stopwatch.Stop();
                Console.WriteLine("ArrayList. \n Элемент был заменён. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch = new Stopwatch();
            }
            if (check == 1)
            {
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        num = listI[i];
                }
                stopwatch.Stop();
                Console.WriteLine("List. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        num2 = arrayList[i];
                }
                stopwatch.Stop();
                Console.WriteLine("ArrayList. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch = new Stopwatch();
            }
        }
        else if (Object.ReferenceEquals(tipe.GetType(), t2.GetType()))
        {
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add("ababa");
                listS.Add("sssss");
            }

            if (check == 0)
            {
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        listS.Insert(i, str);
                }
                stopwatch.Stop();
                Console.WriteLine("List. \n Элемент был заменён. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        arrayList.Insert(i, num);
                }
                stopwatch.Stop();
                Console.WriteLine("ArrayList. \n Элемент был заменён. \n Время работы: {0}", stopwatch.Elapsed);
            }
            if (check == 1)
            {
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        str = listS[i];
                }
                stopwatch.Stop();
                Console.WriteLine("List. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    if (i == position)
                        num2 = arrayList[i];
                }
                stopwatch.Stop();
                Console.WriteLine("ArrayList. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        string str = " ";
        object obj = null;
        MyArrays.SpeedTest<string>(" ", 1, 100000, 5, ref str, obj);
    }
}