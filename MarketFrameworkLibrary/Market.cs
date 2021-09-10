using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class Market
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
            new Commodity(10, "Scissors", 500, Commodity.Commodities.scissors),
            new Commodity(10000, "Nothing", 0, Commodity.Commodities.none)
        };

        public static Team[] TeamList = {
            new Team(1, "Team 1", 25000),
            new Team(2, "Team 2", 25000),
            new Team(3, "Team 3", 25000),
            new Team(4, "Team 4", 25000),
            new Team(5, "Team 5", 25000),
            new Team(6, "Team 6", 25000)
        };

        private List<PurchaseRound> rounds;
        public List<PurchaseRound> Rounds {
            get => rounds;
            set => rounds = value;
        }

        public Market() {
            rounds = new List<PurchaseRound>();
        }

    }
}
