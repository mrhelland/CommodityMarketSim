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

        public string GetReport() {

        }

        int IComparable<Team>.CompareTo(Team other) {
            return this.number.CompareTo(other.number);
        }
    }
}
