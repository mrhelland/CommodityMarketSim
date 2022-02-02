using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFrameworkLibrary
{
    public class Market
    {
        public static string MonetarySymbol {
            get {
                return Properties.Settings.Default.MonetarySymbol;
            } set {
                Properties.Settings.Default.MonetarySymbol = value;
                Properties.Settings.Default.Save();
            }
        }

        public static int TeamQuantity {
            get {
                return Properties.Settings.Default.TeamQuantity;
            } set {
                Properties.Settings.Default.TeamQuantity = value;
                Properties.Settings.Default.Save();
            }
        }

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

        public static Team[] TeamList; 

        private List<PurchaseRound> rounds;
        public List<PurchaseRound> Rounds {
            get => rounds;
            set => rounds = value;
        }

        public Market() {
            List<Team> teams = new List<Team>();
            for(int i = 1; i <= Properties.Settings.Default.TeamQuantity; i++) {
                teams.Add(new Team(i, "Team " + i.ToString(), Properties.Settings.Default.TeamBudget));
            }
            TeamList = teams.ToArray();
            rounds = new List<PurchaseRound>();
        }

    }
}
