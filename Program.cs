using System;
namespace PatikaMethods;
class Solution
{
    static void Main(string[] args)
    {
        int a = 2, b = 3;
        System.Console.WriteLine($"Normal a+b ile: {a+b}");

        int sonuc = Topla(a,b);
        System.Console.WriteLine($"Topla method'u ile: {sonuc}");

        Methodlar ornek = new Methodlar();
        ornek.Yazdir(Convert.ToString(sonuc));

        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        ornek.Yazdir(Convert.ToString(sonuc2));
        ornek.Yazdir(Convert.ToString(a+b));
    }
    static int Topla(int var1, int var2)
    {
        return var1 + var2;
    }
}
class Methodlar
{
    public void Yazdir(string veri)
    {
        System.Console.WriteLine(veri);
    }
    public int ArttirVeTopla(ref int var1, ref int var2)
    {
        var1+=1;
        var2+=1;
        return var1 + var2;
    }
}