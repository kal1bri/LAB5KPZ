using System;

namespace PrototypeBuilder
{
    public class CasualOutfitBuilder : OutfitBuilder
    {
        private Outfit outfit;

        public override void reset()
        {
            this.outfit = new Outfit();
        }

        public override void buildOuterwear()
        {
            this.outfit.setOuterwear("Джинсова куртка");
        }

        public override void buildTop()
        {
            this.outfit.setTop("Бавовняна футболка");
        }

        public override void buildBottom()
        {
            this.outfit.setBottom("Джинси");
        }

        public override void buildFootwear()
        {
            this.outfit.setFootwear("Кеди");
        }

        public override void buildAccessories()
        {
            this.outfit.setAccessories("Міський рюкзак");
        }

        public override Outfit getResult()
        {
            return this.outfit;
        }
    }
}