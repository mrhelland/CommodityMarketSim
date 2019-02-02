using System;
using System.Collections.Generic;
using System.Text;

namespace MarketSimLibrary
{
    public class Agent
    {

        public event EventHandler ValueChanged;

        private string sorttname;
        private string fullname;
        private float funds;
        List<Transaction> transactions;

        public string Sorttname {
            get => sorttname;
        }
        public string Fullname {
            get => fullname;
        }
        public float Funds {
            get => funds;
        }
        public List<Transaction> Transactions {
            get => transactions;
        }

        public Agent(string sorttname, string fullname, float funds) {
            this.sorttname = sorttname;
            this.fullname = fullname;
            this.funds = funds;
            transactions = new List<Transaction>();
            OnValueChanged();
        }

        public bool HasFunds(float amount) {
            if(amount <= funds) {
                return true;
            } else {
                return false;
            }
        }

        public void ProcessTransaction(Transaction verified) {
            if(verified.IsPossible()) {
                this.funds -= verified.Totalprice;
                transactions.Add(verified);
            }
        }

        protected virtual void OnValueChanged() {
            EventHandler handler = ValueChanged;
            if(handler != null) {
                handler(this, new EventArgs());
            }
        }
    }
}
