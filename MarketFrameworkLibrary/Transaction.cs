using System;
using System.Collections.Generic;
using System.Text;

namespace MarketSimLibrary
{
    public class Transaction
    {
        private DateTime timestamp;
        private Team agent;
        private Commodity commodity;
        private int quantity;
        private float unitprice;
        private bool success;

        public DateTime Timestamp {
            get => timestamp;
        }
        public Team Agent {
            get => agent;
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
            agent = a;
            commodity = c;
            quantity = qty;
            unitprice = price;
            success = false;
        }

        public bool IsPossible() {
            if(agent.HasFunds(Totalprice) && commodity.HasStock(quantity)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
