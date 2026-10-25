using System;

namespace PrototypeBuilder
{
    public class SportsOutfitBuilder : OutfitBuilder
    {
        private Outfit outfit;

        public override void reset()
        {
            this.outfit = new Outfit();
        }

        public override void buildOuterwear()
        {
            this.outfit.setOuterwear("Спортивна вітровка");
        }

        public override void buildTop()
        {
            this.outfit.setTop("Майка");
        }

        public override void buildBottom()
        {
            this.outfit.setBottom("Спортивні штани");
        }

        public override void buildFootwear()
        {
            this.outfit.setFootwear("Бігові кросівки");
        }

        public override void buildAccessories()
        {
            this.outfit.setAccessories("Фітнес-браслет");
        }

        public override Outfit getResult()
        {
            return this.outfit;
        }
    }
}