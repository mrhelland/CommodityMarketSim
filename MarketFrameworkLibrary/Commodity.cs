using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Linq;

namespace MarketFrameworkLibrary
{
    [DataContract]
    public class Commodity : IComparable<Commodity>, IEqualityComparer<Commodity>, IEquatable<Commodity> {
        public event EventHandler ValueChanged;

        private static DirectoryInfo imageDirectory;
        public static DirectoryInfo ImageDirectory {
            get {
                return imageDirectory;
            }
        }

        private static SortedList<string, Image> images;
        public static SortedList<string, Image> Images {
            get=>images;
        }

        public static Commodity[] DefaultCommodityList = {
            new Commodity(20, "Rubber Bands", 2000),
            new Commodity(100, "Notecards", 3000),
            new Commodity(25, "Small Paper Clips", 2000),
            new Commodity(25, "Large Paper Clips", 3000),
            new Commodity(200, "Copy Paper", 5000),
            new Commodity(100, "Popsicle Sticks", 3000),
            new Commodity(40, "Masking Tape", 15000),
            new Commodity(40, "String", 15000),
            new Commodity(4, "Colored Pencils", 5000),
            new Commodity(6, "Round Stic Pen", 3000),
            new Commodity(6, "No.2 Pencil", 3000),
            new Commodity(4, "12\" Ruler", 5000),
            new Commodity(4, "Scissors", 5000),
            new Commodity(10000, "Nothing", 0)
        };


        [DataMember(Name = "Name")]
        private string name;
        [DataMember(Name = "Price")]
        private float price;
        [DataMember(Name = "Available")]
        private int available;        

        private int pendingunits;
        public int PendingUnits {
            get => pendingunits;
        }

        public string Name {
            get => name;
        }
        public float Price {
            get => price;
        }
        public int Available {
            get => available;
        }

        private string imageName;
        public void setImageName(string imageName) {
            this.imageName = imageName;
        }
        public string getImageName() {
            return this.imageName;
        }

        public Image Image {
            get {
                if(images == null) {
                    throw new InvalidOperationException("The image list has not been created yet. ");
                }

                if(images.ContainsKey(imageName)) {
                    return images[imageName];
                } else {
                    return images["placeholder"];   
                }
            }
        }

        public Commodity() : this(0, "Widget", 0, "placeholder")  {
        }

        private Commodity(int available, string name, float price) : this(available, name, price, name.Replace(" ", "").StripInvalidFileChars().ToLower()) {
        }


        public Commodity(int available, string name, float price, string imagename) {
            this.available = available;
            this.name = name;
            this.price = price;
            this.imageName = imagename;
            OnValueChanged();
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

        public static void BuildImageList(DirectoryInfo directory) {
            Commodity.imageDirectory = directory;
            images = new SortedList<string, Image>();
            FileInfo[] fileList = directory.GetFiles("*.png");
            foreach(FileInfo f in fileList) {
                if(f.Extension.Equals(".png")) {
                    string name = Path.GetFileNameWithoutExtension(f.Name);
                    Image image = new Bitmap(f.FullName);
                    images.Add(name, image);
                }
            }
        }



    }
}
