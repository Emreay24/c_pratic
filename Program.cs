using System.Data.Common;
using System.Net.Mail;

namespace degiskenler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name ="emre";
            string surname ="ay";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string date2 = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine(date);
            Console.WriteLine(date2);


        }
    }
}