using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
//Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
        byte a= 5;
        sbyte b= 30;
        short c= 10;

        int d= a+b+c;
        //Console.WriteLine(d);

        long h= d;

        float i= h;

        string e ="emre";
        char f='k';
        object g= e+f+d;

//Explicit Conversion (Bilinçli ya da açık dönüşüm)
        int x= 4;
        byte y=(byte)x;

        int z=100;
        byte t= (byte)z;

        float w =10.30f;
        byte v= (byte)w;

        //Console.WriteLine(v);

//ToString methodu
        int k= 6;
        string l= k.ToString();

        string s1="10",s2="20";
        int sayi1,sayi2;
        int toplam;

        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);

        toplam=sayi1+sayi2;
        Console.WriteLine(toplam);

//parse
        ParseMethod();

    }
    public static void ParseMethod(){
        string metin1="10";
        string metin2="10.25";
        int sayi3;
        double sayi4;

        sayi3=Int32.Parse(metin1);
        sayi4=double.Parse(metin2);

    }
}