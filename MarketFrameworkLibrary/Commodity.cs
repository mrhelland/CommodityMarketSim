using System;

namespace MarketFrameworkLibrary
{
    public class Commodity
    {

        public static Commodity[] CommodityList = {
            new Commodity(25, "Rubber Bands", 200, Commodity.Commodities.rubberband),
            new Commodity(100, "Notecards", 200, Commodity.Commodities.notecard),
            new Commodity(25, "Small Paper Clips", 200, Commodity.Commodities.sm_clip),
            new Commodity(25, "Large Paper Clips", 300, Commodity.Commodities.lg_clip),
            new Commodity(500, "Copy Paper", 300, Commodity.Commodities.paper),
            new Commodity(100, "Popsicle Sticks", 300, Commodity.Commodities.sticks),
            new Commodity(50, "Masking Tape", 1000, Commodity.Commodities.tape),
            new Commodity(50, "String", 1000, Commodity.Commodities.@string),
            new Commodity(5, "Colored Pencils", 300, Commodity.Commodities.pencilset),
            new Commodity(20, "Round Stic Pen", 300, Commodity.Commodities.pen),
            new Commodity(20, "No.2 Pencil", 300, Commodity.Commodities.pencil),
            new Commodity(10, "12\" Ruler", 500, Commodity.Commodities.ruler),
            new Commodity(10, "Scissors", 500, Commodity.Commodities.scissors)
        };

        public enum Commodities {
            rubberband,
            notecard,
            sm_clip,
            lg_clip,
            paper,
            sticks,
            tape,
            @string,
            pencilset,
            pen,
            pencil,
            ruler,
            scissors
        }

        public event EventHandler ValueChanged;

        private int available;
        private string name;
        private float price;
        private Commodity.Commodities type;


        public int Available {
            get => available;
        }
        public string Name {
            get => name;
        }
        public float Price {
            get => price;
        }
        public Commodity.Commodities CommmodityType {
            get => type;
        }
        public int ImageIndex {
            get => (int)type;
        }

        public Commodity(int available, string name, float price, Commodity.Commodities type) {
            this.available = available;
            this.name = name;
            this.price = price;
            this.type = type;
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
                return new Commodity(quantity, this.name, this.price, (Commodity.Commodities)this.type);
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
