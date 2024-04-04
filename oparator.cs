using System.Data.Common;
using System.Net.Mail;

namespace operatorler{
    internal class Program{
        private static void Main(string[] args)
    {
        int a = 10;
        int b = 30;
        int sonuc;
        
        sonuc = a+b;
        Console.WriteLine(sonuc);
        sonuc = b-a;
        Console.WriteLine(sonuc);
        sonuc = a*b;
        Console.WriteLine(sonuc);
        sonuc =b/a;
        Console.WriteLine(sonuc);
        }
    }  
}
