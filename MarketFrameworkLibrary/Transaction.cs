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
            if(IsPossible()) {
                this.team.ProcessTransaction(this);
                this.commodity.ProcessTransaction(this);
                this.success = true;
            } else {
                this.success = false;
            }
        }

        public string GetHTML(int rownumber, bool isSummaryOnly = false) {
            string output = Properties.Settings.Default.HTMLTransactionTemplate;
            if(rownumber % 2 == 0) {
                output = output.Replace("%ROWSTYLE%", "even");
            } else {
                output = output.Replace("%ROWSTYLE%", "odd");
            }
            output = output.Replace("%TIME%", this.timestamp.ToShortTimeString());
            output = output.Replace("%COMMODITY%", this.commodity.Name);
            output = output.Replace("%QUANTITY%", this.quantity.ToString() + " unit(s)");
            if(isSummaryOnly) {
                output = output.Replace("%PRICE%", "---");
            } else {
                output = output.Replace("%PRICE%", Properties.Settings.Default.MonetarySymbol + this.unitprice.ToString());
            }
            if(this.success || isSummaryOnly) {
                output = output.Replace("%SUCCESS%", "OK");
            } else {
                output = output.Replace("%SUCCESS%", "<b>FAILED</b>");
            }
            return output;
        }

        public static string GetJSON(Transaction t) {
            return JsonConvert.SerializeObject(t);
        }

        public static Transaction GetTransaction(string json) {
            return JsonConvert.DeserializeObject<Transaction>(json);
        }

    }
}
