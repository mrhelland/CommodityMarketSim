using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;


namespace MarketFrameworkLibrary
{
    [DataContract]
    public class Transaction
    {
        [DataMember(Name = "Timestamp")]
        private DateTime timestamp;
        [DataMember(Name = "Team")]
        private Team team;
        [DataMember(Name = "Commodity")]
        private Commodity commodity;
        [DataMember(Name = "Quantity")]
        private int quantity;
        [DataMember(Name = "UnitPrice")]
        private float unitprice;
        [DataMember(Name = "Success")]
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

        internal Transaction() {
            success = false;
        }

        public Transaction(DateTime t, Team a, Commodity c, int qty, float price) : this() {
            timestamp = t;
            team = a;
            commodity = c;
            quantity = qty;
            unitprice = price;
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

        public string GetHTML(int rownumber) {
            string output = Properties.Settings.Default.HTMLTransactionTemplate;
            if(rownumber % 2 == 0) {
                output = output.Replace("%ROWSTYLE%", "even");
            } else {
                output = output.Replace("%ROWSTYLE%", "odd");
            }
            output = output.Replace("%TIME%", this.timestamp.ToShortTimeString());
            output = output.Replace("%COMMODITY%", this.commodity.Name);
            output = output.Replace("%QUANTITY%", this.quantity.ToString() + " unit(s)");
            output = output.Replace("%PRICE%", Market.Instance.MonetarySymbol + this.unitprice.ToString());
            if(this.success) {
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
