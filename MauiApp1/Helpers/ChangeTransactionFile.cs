using MauiApp1.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MauiApp1.Helpers
{
    public class ChangeTransactionFile
    {
        static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static ObservableCollection<Transaction> LoadData(ObservableCollection<Transaction> transactions)
        {
            ObservableCollection<Transaction> data;
            string fileName = "Transactions.json";
            string path = Path.Combine(folder, fileName);
            
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                data = new ObservableCollection<Transaction>();
            }
            else
            {
                string json = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadToEnd();
                }

                data = JsonConvert.DeserializeObject<ObservableCollection<Transaction>>(json);
                if (data == null)
                {
                    foreach (Transaction transaction in data)
                    {
                        transactions.Add(transaction);
                    }
                }
            }
            return data;
        }
         
        public static void SaveData(ObservableCollection<Transaction> transactions)
        {
            string fileName = "Transactions.json";
            string path = Path.Combine(folder, fileName);
            string json = JsonConvert.SerializeObject(transactions);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(json);
            }
        }

    }
}
