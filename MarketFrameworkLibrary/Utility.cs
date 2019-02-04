using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketFrameworkLibrary {
    public class Utility {
        private static Random random = new Random();
        public static int RandomNumber(int min, int max) {
            return random.Next(min, max);
        }

        public static float RandomNumber(float min, float max) {
            return (float)random.NextDouble() * (max-min) + min;
        }
    }
}
