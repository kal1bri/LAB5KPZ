using System;

namespace PrototypeBuilder
{
    public class BusinessOutfitBuilder : OutfitBuilder
    {
        private Outfit outfit;

        public override void reset()
        {
            this.outfit = new Outfit();
        }

        public override void buildOuterwear()
        {
            this.outfit.setOuterwear("Діловий піджак");
        }

        public override void buildTop()
        {
            this.outfit.setTop("Біла сорочка");
        }

        public override void buildBottom()
        {
            this.outfit.setBottom("Класичні штани");
        }

        public override void buildFootwear()
        {
            this.outfit.setFootwear("Шкіряні туфлі");
        }

        public override void buildAccessories()
        {
            this.outfit.setAccessories("Краватка");
        }

        public override Outfit getResult()
        {
            return this.outfit;
        }
    }
}