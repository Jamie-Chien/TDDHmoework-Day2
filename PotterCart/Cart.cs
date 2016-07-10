using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterCart
{
    public class Cart
    {
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

            if (purchasedVolumeCount >= 2)
            {
                price = (int)Math.Round(purchasedVolumeCount * 100 * 0.95);
            }
            else
            {
                price = purchasedVolumeCount * 100;
            }

            return price;
        }
    }
}