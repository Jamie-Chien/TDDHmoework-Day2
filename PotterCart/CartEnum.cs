using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterCart
{
    public class CartEnum
    {
        private Dictionary<int, double> discountRange = null;

        public CartEnum()
        {
            discountRange = new Dictionary<int, double>()
            {
                {1, 1 },
                {2,0.95 },
                {3,0.9 },
                {4, 0.8 },
                {5,0.75 }
            };

            Volumes = new List<Volume>();
        }

        public List<Volume> Volumes { get; private set; }

        public void Add(Volume volume)
        {
            Volumes.Add(volume);
        }

        public int GetPrice()
        {
            return CalcualtePrice(Volumes, 0);
        }

        private int CalcualtePrice(List<Volume> volumes, int price)
        {
            if (volumes.Count > 0)
            {
                var purchasedVolume = volumes.Distinct().ToList();
                removeElementFromList(ref volumes, purchasedVolume);

                int purchasedVolumeCount = purchasedVolume.Count();
                double discount = discountRange[purchasedVolumeCount];

                int priceOfGroup = (int)Math.Round(purchasedVolumeCount * 100 * discount);
                return priceOfGroup + CalcualtePrice(volumes, price);
            }
            return price;
        }

        private void removeElementFromList(ref List<Volume> volumes, List<Volume> removeList)
        {
            foreach (var item in removeList)
            {
                volumes.Remove(item);
            }
        }
    }
}