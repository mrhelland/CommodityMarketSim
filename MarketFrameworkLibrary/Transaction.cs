using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MarketFrameworkLibrary
{
    public class Transaction
    {
        private DateTime timestamp;
        private Team team;
        private Commodity commodity;
        private int quantity;
        private float unitprice;
        private bool success;

        public DateTime Timestamp {
            get => timestamp;
        }
        public Team Agent {
            get => team;
        }
        public Commodity Commodity {
            get => commodity;
        }
        public int Quantity {
            get => quantity;
        }
        public float Unitprice {
            get => unitprice;
        }
        public float Totalprice {
            get => unitprice * quantity;
        }
        public bool Success {
            get => success;
        }

        public Transaction(DateTime t, Team a, Commodity c, int qty, float price) {
            timestamp = t;
            team = a;
            commodity = c;
            quantity = qty;
            unitprice = price;
            success = false;
        }

        public bool IsPossible() {
            if(team.HasFunds(Totalprice) && commodity.HasStock(quantity)) {
                return true;
            } else {
                return false;
            }
        }

        public void ProcessTransaction() {
            this.team.ProcessTransaction(this);
            this.commodity.ProcessTransaction(this);
        }

        public static string GetJSON(Transaction t) {
            return JsonConvert.SerializeObject(t);
        }

        public static Transaction GetTransaction(string json) {
            return JsonConvert.DeserializeObject<Transaction>(json);
        }

    }
}
