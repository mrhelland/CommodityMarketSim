using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class PurchaseRound
    {
        private static int LastRoundNumber = 0;
        private int number;
        private List<Transaction> transactions;
        public int Number {
            get => number;
        }
        public List<Transaction> Transactions {
            get => transactions;
        }

        public PurchaseRound() {
            this.number = LastRoundNumber + 1;
            LastRoundNumber = this.number;
            transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction attempt) {
            if(!attempt.IsPossible()) {
                throw new InvalidOperationException("This transaction is not possible.");
            } else {
                transactions.Add(attempt);
            }
        }

        public void Complete() {
            foreach(Transaction t in transactions) {
                t.Agent.ProcessTransaction(t);
                t.Commodity.ProcessTransaction(t);
            }
        }
    }
}
