
using System;
class pr
{
    static int all(int[] f)
    {
        int bi = 0;
        foreach (int i in f) bi += i;
        return bi;
    }
    static int zash(int[] f)
    {
        int bi = 0;
        foreach (int i in f) if (i < 30) bi++;
        return bi;
    }
    static int sred(int[] f)
    {
        int bi = 0;
        foreach (int i in f) bi += i;
        return bi / f.Length;
    }
    static int most_zash(int[] f)
    {
        int bi = f[0];
        foreach (int i in f) if (i < bi) bi = i;
        return bi;
    }
    static void Main()
    {
        int[] f = new int[] { 120, 40, 30, 20, 50, 20, 10, 30, 100, 70, 80, 70 };
        Console.WriteLine(all(f));
        Console.WriteLine(sred(f));
        Console.WriteLine(zash(f));
        Console.WriteLine(most_zash(f));
    }
}