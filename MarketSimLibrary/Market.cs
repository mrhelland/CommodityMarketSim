using System;
using System.Collections.Generic;
using System.Text;

namespace MarketSimLibrary
{
    public class Market
    {
        private SortedList<string, Agent> agents;
        private SortedList<string, Commodity> commodities;
        private PurchaseRound round;

        public SortedList<string, Agent> Agents {
            get => agents;
        }
        public SortedList<string, Commodity> Commodities {
            get => commodities;
        }

        public Market() {
            agents = new SortedList<string, Agent>();
            commodities = new SortedList<string, Commodity>();
        }

        public void StartRound() {
            round = new PurchaseRound();
        }

        public void EndRound() {

        }

    }
}
