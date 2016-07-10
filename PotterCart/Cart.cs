using System.Collections.Generic;

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
            return Volumes.Count * 100;
        }
    }
}