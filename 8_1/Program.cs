using System.Collections;
using System.Diagnostics;
namespace StopwatchExample;

class MyArrays
{
    static Random rnd = new Random();
    static List<int> listI = new List<int>();
    static List<string> listS = new List<string>();
    static ArrayList arrayList = new ArrayList();
    static Stopwatch stopwatch = new Stopwatch();

    public static void InsertArrayList<Tipe>(Tipe a)
    {
        object save = a;
        object secondSave;
        stopwatch.Start();
        for (int i = 0; i <= 10000000; i++)
        {
            if (i == 9990000)
            {
                save = arrayList[i];
                arrayList.Insert(i, a);
            }
            if (i > 9990000)
            {
                secondSave = arrayList[i];
                arrayList.Insert(i, save);
                save = secondSave;
            }
        }
        stopwatch.Stop();
        Console.WriteLine("ArrayList. \n Элемент был добавлен. \n Время работы: {0}", stopwatch.Elapsed);
        stopwatch = new Stopwatch();
    }
    public static void SearchArrayList<Tipe>(Tipe a, ref object num)
    {
        string t = " ";
        object point;
        if (Object.ReferenceEquals(a.GetType(), t.GetType()))
            point = "abab";
        else
            point = 21;
        stopwatch.Start();
        for (int i = 0; i < 10000000; i++)
        {
            if (arrayList[i] == point)
                num = arrayList[i];
        }
        stopwatch.Stop();
        Console.WriteLine("ArrayList. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
        stopwatch = new Stopwatch();
    }

    public static void InsertList<Tipe>(Tipe a, List<Tipe> list)
    {
        Tipe save = a;
        Tipe secondSave;
        stopwatch.Start();
        for (int i = 0; i <= 10000000; i++)
        {
            if (i == 9990000)
            {
                save = list[i];
                arrayList.Insert(i, a);
            }
            if (i > 9990000)
            {
                secondSave = list[i];
                list.Insert(i, save);
                save = secondSave;
            }
        }
        stopwatch.Stop();
        Console.WriteLine("List. \n Элемент был добавлен. \n Время работы: {0}", stopwatch.Elapsed);
        stopwatch = new Stopwatch();
    }

    public static void SearchListS(List<string> list, ref object num)
    {
        string t = " ";
        string point = "abab";        
        stopwatch.Start();
        for (int i = 0; i < 10000000; i++)
        {
            if (list[i] == point)
                num = list[i];
        }
        stopwatch.Stop();
        Console.WriteLine("List. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
        stopwatch = new Stopwatch();
    }

    public static void SearchListI(List<int> list, ref object num)
    {
        string t = " ";
        int point = 21;
        stopwatch.Start();
        for (int i = 0; i < 10000000; i++)
        {
            if (list[i] == point)
                num = list[i];
        }
        stopwatch.Stop();
        Console.WriteLine("List. \n Элемент был найден. \n Время работы: {0}", stopwatch.Elapsed);
        stopwatch = new Stopwatch();
    }

    public static void SpeedTest<Tipe>(Tipe tipe, int check)
    {
        int t = 0;
        string t2 = " ";
        object num = 0;
        string str = "gg";
        if (Object.ReferenceEquals(tipe.GetType(), t.GetType()))
        {
            for (int i = 0; i < 10000000; i++)
            {
                if (i == 100000)
                {
                    arrayList.Add(21);
                    listI.Add(21);
                }
                else
                {
                    arrayList.Add(rnd.Next(1, 20));
                    listI.Add(rnd.Next(1, 20));

                }
            }        

            if (check == 0)
            {
                MyArrays.InsertList<int>(5, listI);
                MyArrays.InsertArrayList<int>(22);
            }
            if (check == 1)
            {
                MyArrays.SearchListI(listI, ref num);
                MyArrays.SearchArrayList<int>(22, ref num);
            }
        }
        else if (Object.ReferenceEquals(tipe.GetType(), t2.GetType()))
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 100000)
                {
                    arrayList.Add("abab");
                    listS.Add("abab");
                }
                else
                {
                    arrayList.Add("fffff");
                    listS.Add("fffff");
                }
            }

            if (check == 0)
            {
                MyArrays.InsertList<string>("sssss", listS);
                MyArrays.InsertArrayList<string>("sssss");
            }
            if (check == 1)
            {
                MyArrays.SearchListS(listS, ref num);
                MyArrays.SearchArrayList<string>("sssss", ref num);
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        MyArrays.SpeedTest<int>(0, 1);
    }
}
