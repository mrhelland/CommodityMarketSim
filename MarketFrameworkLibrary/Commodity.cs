using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Drawing;

namespace MarketFrameworkLibrary
{
    [DataContract]
    public class Commodity : IComparable<Commodity>, IEqualityComparer<Commodity>, IEquatable<Commodity>
    {
        public event EventHandler ValueChanged;

        [DataMember(Name = "Available")]
        private int available;
        [DataMember(Name = "Name")]
        private string name;
        [DataMember(Name = "Price")]
        private float price;
        [DataMember(Name = "Icon")]
        private string iconName;

        private int pendingunits;
        public int Pendingunits {
            get => pendingunits;
        }


        public int Available {
            get => available;
        }
        public string Name {
            get => name;
        }
        public float Price {
            get => price;
        }

        public Image Icon {
            get => (Image)Properties.Resources.ResourceManager.GetObject(iconName);
        }

        internal Commodity() {
            this.pendingunits = 0;
            OnValueChanged();
        }

        public Commodity(int available, string name, float price, string iconName) : this() {
            this.available = available;
            this.name = name;
            this.price = price;
            this.iconName = iconName;
        }

        public bool HasStock(int quantity) {
            if(quantity <= available) {
                return true;
            } else {
                return false;
            }
        }

        public void Reserve(int quantity) {
            pendingunits += quantity;
            OnValueChanged();
        }

        internal void ProcessTransaction(Transaction t) {
            this.pendingunits = 0;
            this.available -= t.Quantity;
            OnValueChanged();
        }

        internal void AdjustPrice(float marketratio) {
            this.price = (float)Math.Round( this.price * marketratio, 0);
            OnValueChanged();
        }

        protected virtual void OnValueChanged() {
            EventHandler handler = ValueChanged;
            if(handler != null) {
                handler(this, new EventArgs());
            }
        }

        public static string GetJSON(Commodity c) {
            return JsonConvert.SerializeObject(c);
        }

        public static Commodity GetCommodity(string json) {
            return JsonConvert.DeserializeObject<Commodity>(json);
        }

        int IComparable<Commodity>.CompareTo(Commodity other) {
            return this.name.CompareTo(other.name);
        }

        bool IEqualityComparer<Commodity>.Equals(Commodity x, Commodity y) {
            if(x == null || y == null) {
                throw new NullReferenceException("The values are null. Did you really intend to compare their equality?");
            } else {
                return x.Equals(y);
            }

        }

        int IEqualityComparer<Commodity>.GetHashCode(Commodity obj) {
            return obj.name.GetHashCode();
        }

        bool IEquatable<Commodity>.Equals(Commodity other) {
            if(other == null) {
                return false;
            } else if(this.name.Equals(other.name)) {
                return true;
            } else {
                return false;
            }
        }

    }
}
