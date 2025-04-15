using System.Collections.Generic;
using System.Numerics;
using static modul8_103022300025.BankTransferConfig;

namespace modul8_103022300025
{
    class Program
    {
        static void Main(string[] args)
        {
           UIConfig config = new UIConfig();

            if (config.config.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
            }
            else
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di - transfer:");

            }
        }
    }        
}