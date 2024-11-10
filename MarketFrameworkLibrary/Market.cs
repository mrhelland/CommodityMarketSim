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
        [DataMember(Name = "Configuration")]
        internal MarketConfiguration configuration;
        public MarketConfiguration Configuration {
            get => configuration;
            set => this.configuration = value;
        }

        [DataMember(Name="TeamList")]
        internal Team[] teamList;
        public Team[] TeamList {
            get => teamList;
            set => teamList = value;
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

        public Market() : this(Properties.Settings.Default.DefaultTeamCount, Properties.Settings.Default.DefaultTeamBudget, Properties.Settings.Default.DefaultMonetarySymbol, new List<Commodity>()) {
        }

        public Market(int teamCount, int teamBudget, String monetarySymbol) : this(teamCount, teamBudget, monetarySymbol, new List<Commodity>()) {
        }

        public Market(int teamCount, int teamBudget, String monetarySymbol, List<Commodity> commodities) {
            this.commodities = commodities;
            this.rounds = new List<PurchaseRound>();
            this.configuration = new MarketConfiguration(teamCount, teamBudget, monetarySymbol);
            this.commodities = new List<Commodity>(Commodity.DefaultCommodityList);

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
