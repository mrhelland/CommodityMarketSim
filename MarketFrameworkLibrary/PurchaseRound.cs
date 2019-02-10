using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class PurchaseRound
    {
        private int number;
        public int Number {
            get => number;
        }

        private List<Transaction> transactions;
        public List<Transaction> Transactions {
            get => transactions;
            set => transactions = value;
        }

        public PurchaseRound(int number) {
            this.number = number;
            transactions = new List<Transaction>();
        }

        public void ProcessTransactions() {
            List<Transaction> processed = new List<Transaction>();
            foreach(Transaction t in transactions) {
                t.ProcessTransaction();
                processed.Add(t);
            }
            AdjustMarket(processed);
        }

        private void AdjustMarket(List<Transaction> processed) {
            foreach(Commodity c in Market.CommodityList) {
                c.AdjustPrice(Utility.RandomNumber(0.94f, 0.98f));
            }
            foreach(Transaction t in processed) {
                t.Commodity.AdjustPrice(Utility.RandomNumber(0.04f, 0.16f) + 1.0f);
            }
        }
    }
}
