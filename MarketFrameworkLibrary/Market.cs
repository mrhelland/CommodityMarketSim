using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class Market
    {
        private SortedList<int, Team> teams;
        private SortedList<int, Commodity> commodities;
        private PurchaseRound round;

        public SortedList<int, Team> Agents {
            get => teams;
        }
        public SortedList<int, Commodity> Commodities {
            get => commodities;
        }

        public Market() {
            teams = new SortedList<int, Team>();
            commodities = new SortedList<int, Commodity>();
        }

        public void BuildMarket() {
            for(int i = 0; i < Team.TeamList.Length; i++) {
                teams.Add(i, Team.TeamList[i]);
            }
            for(int i = 0; i < Commodity.CommodityList.Length; i++) {
                commodities.Add(i, Commodity.CommodityList[i]);
            }
            for(int i = 1; i <= 4; i++) {
                teams.Add(i, new Team(i, "Team " + i.ToString(), 30000));

            }
        }

        public void StartRound() {
            round = new PurchaseRound();
        }

        public void EndRound() {

        }

    }
}
