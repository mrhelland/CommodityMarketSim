using System;

namespace MarketFrameworkLibrary
{
    public class Commodity
    {

        public event EventHandler ValueChanged;

        private int available;
        private string name;
        private float price;

        public int Available {
            get => available;
        }
        public string Name {
            get => name;
        }
        public float Price {
            get => price;
        }

        public Commodity(int available, string name, float price) {
            this.available = available;
            this.name = name;
            this.price = price;
            OnValueChanged();
        }

        public bool HasStock(int quantity) {
            if(quantity <= available) {
                return true;
            } else {
                return false;
            }
        }

        public Commodity Transfer(int quantity) {
            if(HasStock(quantity)) {
                available -= quantity;
                OnValueChanged();
                return new Commodity(quantity, this.name, this.price);
            } else {
                return null;
            }
        }

        public void ProcessTransaction(Transaction verified) {
            if(verified.IsPossible()) {
                available -= verified.Quantity;
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
