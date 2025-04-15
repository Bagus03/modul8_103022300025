using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace modul8_103022300025
{
    public class BankTransferConfig
    {
        public const string ConfigPath = " bank_transfer_config.json";

        public string lang { get; set; }

        public Transfer transfer { get; set; }

        public Confirmation confirmation { get; set; }

        public class Transfer 
        {
            public int treshold { get; set; }

            public int low_fee { get; set; }

            public int high_fee { get; set; }
        }

        public class Confirmation
        {
            public string en { get; set; }

            public string id { get; set; }
        }


        public string[] metods { get; set; }

        public BankTransferConfig(string lang, Transfer transfer, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.confirmation = confirmation;
        }

        public void UbahBahasa()
        {
            lang =lang.ToLower() == "en" ? "id" : "en";
        }
    }
}
