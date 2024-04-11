internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("lütfen bir sayı giriniz");
        int sayac=int.Parse(Console.ReadLine());
        for (int i = 1; i < sayac; i++)
        {
            if( i%2 == 1);
                Console.Write(i + ",");
            
        }
        int TekToplam=0;
        int CiftToplam=0;
        for (int i = 0; i <= 1000; i++)
        {
            if(i%2 == 1)
            TekToplam += i; 

            if(i%2 == 0)
            CiftToplam += i;
        }
        Console.WriteLine("tek toplam:  " +TekToplam);
        Console.WriteLine("çift toplam:  " + CiftToplam);

        
    }
}
