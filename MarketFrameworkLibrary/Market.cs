using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class Market
    {
        private SortedList<string, Team> agents;
        private SortedList<string, Commodity> commodities;
        private PurchaseRound round;

        public SortedList<string, Team> Agents {
            get => agents;
        }
        public SortedList<string, Commodity> Commodities {
            get => commodities;
        }

        public Market() {
            agents = new SortedList<string, Team>();
            commodities = new SortedList<string, Commodity>();
        }

        public void StartRound() {
            round = new PurchaseRound();
        }

        public void EndRound() {

        }

    }
}
