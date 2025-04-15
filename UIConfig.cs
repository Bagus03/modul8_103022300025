using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300025
{
    internal class UIConfig
    {
        public BankTransferConfig config;
        public const string filepath = @"bank_transfer_config.json";

        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
        private BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData); return config;
        }
        private void SetDefault() 
        {
            config.lang = "en";
            config.transfer.low_fee = 6500;
            config.transfer.treshold = 25000000;
            config.transfer.high_fee = 15000;
            config.metods = [
            "“RTO",
            "(real-time)”",
            "“SKN”",
            "“RTGS”",
            "“BI",
            "FAST”"];
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";

            }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);
        }
    }
}
