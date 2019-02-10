using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace MarketFrameworkLibrary
{
    public class Team : IComparable<Team>
    {
        public event EventHandler ValueChanged;

        private string name;
        private float funds;
        private int number;
        List<Transaction> processedtransactions;

        public string Name {
            get => name;
            set => name = value;
        }
        public float Funds {
            get => funds;
            set => funds = value;
        }
        public List<Transaction> Transactions {
            get => processedtransactions;
            set => processedtransactions = value;
        }
        public int Number {
            get => number;
            set => number = value;
        }

        public int ImageIndex {
            get => number - 1;
        }

        public Team(int number, string name, float funds) {
            this.name = name;
            this.funds = funds;
            this.number = number;
            processedtransactions = new List<Transaction>();
            OnValueChanged();
        }

        public bool HasFunds(float amount) {
            if(amount <= funds) {
                return true;
            } else {
                return false;
            }
        }

        internal void ProcessTransaction(Transaction verified) {
            this.funds -= verified.Totalprice;
            processedtransactions.Add(verified);
            OnValueChanged();
        }

        protected virtual void OnValueChanged() {
            EventHandler handler = ValueChanged;
            if(handler != null) {
                handler(this, new EventArgs());
            }
        }

        public SortedList<Commodity, int> GetCommodityTotals() {
            SortedList<Commodity, int> totals = new SortedList<Commodity, int>();

            return totals;
        }

        public string GetHTML() {
            string output = Properties.Settings.Default.HTMLPageTemplate;
            string transactionsummary = " ";
            int rowcount = 0;
            foreach(Transaction t in this.Transactions) {
                transactionsummary += t.GetHTML(rowcount);
                rowcount++;
            }
            string commoditysummary = Properties.Settings.Default.HTMLCommodityTemplate;
            SortedList<Commodity, int> totals = GetCommodityTotals();
            foreach(Commodity c in totals.Keys) {
                commoditysummary = commoditysummary.Replace("", "");
            }
            output = output.Replace("%TEAM%", this.name);
            output = output.Replace("%TRANSACTIONS%", transactionsummary);
            output = output.Replace("%COMMODITIES%", commoditysummary);
            output = output.Replace("%FUNDS%", this.funds.ToString());
            return output;
        }

        int IComparable<Team>.CompareTo(Team other) {
            return this.number.CompareTo(other.number);
        }
    }
}
