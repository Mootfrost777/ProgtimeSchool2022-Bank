using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using MauiApp1.Model;

namespace MauiApp1.ViewModel
{
    public class TransactionViewModel
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public TransactionViewModel()
        {
            Transactions = new ObservableCollection<Transaction>()
            {
                new("Транспорт", 79.00f),
                new("Еда", 2000),
                new("Кино", 300),
                new("Транспорт", 79.00f),
                new("Транспорт", 79.00f),
                new("Транспорт", 7632.00f),
                new("Транспорт", 79.00f),
                new("Транспорт", 79.00f)
            };
        }
    }
}
