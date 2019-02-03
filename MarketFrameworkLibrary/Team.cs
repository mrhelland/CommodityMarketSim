using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class Team
    {

        public static Team[] TeamList = {
            new Team(1, "Team 1", 30000),
            new Team(2, "Team 2", 30000),
            new Team(3, "Team 3", 30000),
            new Team(4, "Team 4", 30000)
        };

        public event EventHandler ValueChanged;

        private string name;
        private float funds;
        private int number;
        List<Transaction> transactions;

        public string Name {
            get => name;
        }
        public float Funds {
            get => funds;
        }
        public List<Transaction> Transactions {
            get => transactions;
        }
        public int Number {
            get => number;
        }

        public int ImageIndex {
            get => number - 1;
        }

        public Team(int number, string name, float funds) {
            this.name = name;
            this.funds = funds;
            this.number = number;
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
