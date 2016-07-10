using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterCart
{
    public class Cart
    {
        private double[] discountRange = new double[] { 1, 0.95, 0.9, 0.8 };

        public Cart()
        {
            Volumes = new List<Volume>();
        }

        public List<Volume> Volumes { get; private set; }

        public void Add(Volume volume)
        {
            Volumes.Add(volume);
        }

        public int GetPrice()
        {
            int price = 0;
            int purchasedVolumeCount = Volumes.GroupBy(x => x).Count();
            double discount = discountRange[purchasedVolumeCount - 1];
            price = (int)Math.Round(purchasedVolumeCount * 100 * discount);
            return price;
        }
    }
}