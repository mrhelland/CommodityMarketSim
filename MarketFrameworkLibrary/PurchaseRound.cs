using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MarketFrameworkLibrary
{
    [DataContract]
    public class PurchaseRound
    {
        [DataMember(Name = "Number")]
        private int number;
        public int Number {
            get => number;
        }

        [DataMember(Name = "Transactions")]
        private List<Transaction> transactions;
        public List<Transaction> Transactions {
            get => transactions;
            set => transactions = value;
        }

        internal PurchaseRound() {
            transactions = new List<Transaction>();
        }

        public PurchaseRound(int number) : this() {
            this.number = number;
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
            foreach(Commodity c in Market.Instance.Commodities) {
                c.AdjustPrice(Utility.RandomNumber(0.94f, 0.98f));
            }
            foreach(Transaction t in processed) {
                t.Commodity.AdjustPrice(Utility.RandomNumber(0.04f, 0.16f) + 1.0f);
            }
        }
    }
}
