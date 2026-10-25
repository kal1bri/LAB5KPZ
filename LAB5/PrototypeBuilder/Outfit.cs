using System;

namespace PrototypeBuilder
{
    public class Outfit : IPrototype
    {
        private string outerwear;
        private string top;
        private string bottom;
        private string footwear;
        private string accessories;

        public Outfit()
        {
        }

        public Outfit(Outfit other)
        {
            if (other != null)
            {
                this.outerwear = other.outerwear;
                this.top = other.top;
                this.bottom = other.bottom;
                this.footwear = other.footwear;
                this.accessories = other.accessories;
            }
        }

        public void setOuterwear(string value)
        {
            this.outerwear = value;
        }

        public void setTop(string value)
        {
            this.top = value;
        }

        public void setBottom(string value)
        {
            this.bottom = value;
        }

        public void setFootwear(string value)
        {
            this.footwear = value;
        }

        public void setAccessories(string value)
        {
            this.accessories = value;
        }

        public string showDetails()
        {
            return "Верхній одяг: " + (string.IsNullOrEmpty(this.outerwear) ? "не обрано" : this.outerwear) + "\n" +
                   "Верх: " + (string.IsNullOrEmpty(this.top) ? "не обрано" : this.top) + "\n" +
                   "Низ: " + (string.IsNullOrEmpty(this.bottom) ? "не обрано" : this.bottom) + "\n" +
                   "Взуття: " + (string.IsNullOrEmpty(this.footwear) ? "не обрано" : this.footwear) + "\n" +
                   "Аксесуари: " + (string.IsNullOrEmpty(this.accessories) ? "не обрано" : this.accessories);
        }

        public Outfit clone()
        {
            return new Outfit(this);
        }
    }
}