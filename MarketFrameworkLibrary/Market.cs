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
            new Commodity(20, "Rubber Bands", 3000, Commodity.Commodities.rubberband),
            new Commodity(60, "Notecards", 2000, Commodity.Commodities.notecard),
            new Commodity(20, "Small Paper Clips", 2000, Commodity.Commodities.sm_clip),
            new Commodity(20, "Large Paper Clips", 3000, Commodity.Commodities.lg_clip),
            new Commodity(60, "Copy Paper", 5000, Commodity.Commodities.paper),
            new Commodity(60, "Popsicle Sticks", 3000, Commodity.Commodities.sticks),
            new Commodity(30, "Masking Tape", 12000, Commodity.Commodities.tape),
            new Commodity(30, "String", 10000, Commodity.Commodities.@string),
            new Commodity(6, "Colored Pencils", 5000, Commodity.Commodities.pencilset),
            new Commodity(6, "Round Stic Pen", 3000, Commodity.Commodities.pen),
            new Commodity(6, "No.2 Pencil", 3000, Commodity.Commodities.pencil),
            new Commodity(6, "12\" Ruler", 10000, Commodity.Commodities.ruler),
            new Commodity(6, "Scissors", 10000, Commodity.Commodities.scissors),
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
