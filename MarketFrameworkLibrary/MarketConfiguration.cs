using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MarketFrameworkLibrary {
    public class MarketConfiguration {
        [DataMember(Name = "TeamCount")]
        internal int teamCount;
        public int TeamCount {
            get => teamCount;
        }

        [DataMember(Name = "TeamBudget")]
        internal int teamBudget;
        public int TeamBudget {
            get => teamBudget;
        }

        [DataMember(Name = "MonetarySymbol")]
        internal string monetarySymbol;
        public string MonetarySymbol {
            get => monetarySymbol;
        }

        public MarketConfiguration() : this(Properties.Settings.Default.DefaultTeamCount, Properties.Settings.Default.DefaultTeamBudget, Properties.Settings.Default.DefaultMonetarySymbol) {

        }

        public MarketConfiguration(int teamCount, int teamBudget, string monetarySymbol) {
            this.teamCount = teamCount;
            this.teamBudget = teamBudget;
            this.monetarySymbol = monetarySymbol;
        }

    }
}
