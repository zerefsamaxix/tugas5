using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet \n");

            Console.WriteLine("Nomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            switch (nomorPrinter)
            {
                case 1:
                    printer = new Epson();
                    printer.Show();
                    printer.Print();
                    break;
                case 2:
                    printer = new Canon();
                    printer.Show();
                    printer.Print();
                    break;
                case 3:
                    printer = new LaserJet();
                    printer.Show();
                    printer.Print();
                    break;
                default:
                    Console.WriteLine("Nomor yang anda masukan tidak ada, Coba lagi");
                    break;
            }


            Console.ReadKey();
        }
    }
}