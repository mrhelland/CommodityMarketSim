using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace MarketFrameworkLibrary
{
    [DataContract]
    public class Market
    {
        private static Market instance; 
        public static Market Instance {
            get => instance;
        }

        [DataMember(Name="TeamList")]
        internal Team[] teamList;
        public Team[] TeamList {
            get => teamList;
            set => teamList = value;
        }

        [DataMember(Name="TeamCount")]
        internal int teamCount;
        public int TeamCount {
            get => teamCount;
        }

        [DataMember(Name="TeamBudget")]
        internal int teamBudget;
        public int TeamBudget {
            get => teamBudget;
        }

        [DataMember(Name="MonetarySymbol")]
        internal string monetarySymbol;
        public string MonetarySymbol {
            get => monetarySymbol;
        }

        [DataMember(Name ="Commodities")]
        internal List<Commodity> commodities;
        public List<Commodity> Commodities {
            get => this.commodities;
        }

        [DataMember(Name = "Rounds")]
        internal List<PurchaseRound> rounds;
        public List<PurchaseRound> Rounds {
            get => rounds;
            set => rounds = value;
        }

        public Market() {
            rounds = new List<PurchaseRound>();
            this.commodities = new List<Commodity>(Commodity.DefaultCommodityList);
            Market.instance = this;        
        }

        public Market(int teamCount, int teamBudget, String monetarySymbol) : this() {
            this.teamCount = teamCount;
            this.teamBudget = teamBudget;
            this.monetarySymbol = monetarySymbol;
        }

        public Market(int teamCount, int teamBudget, String monetarySymbol, List<Commodity> commodities) : this(teamCount, teamBudget, monetarySymbol) {
            this.commodities = commodities;
        }

        public Exception Save(string filename) {
            try {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Market));
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                using(XmlWriter xw = XmlWriter.Create(filename, settings)) {
                    serializer.WriteObject(xw, this);
                }
            } catch (Exception ex) {
                return ex;
            }
            return null;
        }

        public static Market Load(string filename) {
            try {
                DataContractSerializer deserializer = new DataContractSerializer(typeof(Market));
                FileStream fs = new FileStream(filename, FileMode.Open);
                XmlDictionaryReaderQuotas quotas = new XmlDictionaryReaderQuotas();
                quotas.MaxDepth = 100;
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                Market m = (Market)deserializer.ReadObject(reader);
                reader.Close();
                fs.Close();
                return m;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return null;
            }

        }

    }
}
