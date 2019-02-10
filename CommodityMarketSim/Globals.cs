using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    public class Globals {



        public enum UIIndicatorLevels {
            NotAvailable,
            Warning,
            Available
        }

        public static Color GetFormBackcolor(bool available) {
            if(available) {
                return Color.PaleGreen;
            } else {
                return Color.Pink;
            }
        }

        public static Color GetFieldBackcolor(UIIndicatorLevels level) {
            switch(level) {
                case UIIndicatorLevels.NotAvailable:
                    return Color.Gray;
                case UIIndicatorLevels.Warning:
                    return Color.Khaki;
                default:
                    return Color.White;
            }
        }

    }
}
