using System;

namespace PrototypeBuilder
{
    public class OutfitDirector
    {
        private OutfitBuilder builder;

        public void setBuilder(OutfitBuilder builder)
        {
            this.builder = builder;
        }

        public void constructCasualOutfit()
        {
            this.builder.reset();
            this.builder.buildOuterwear();
            this.builder.buildTop();
            this.builder.buildBottom();
            this.builder.buildFootwear();
            this.builder.buildAccessories();
        }

        public void constructBusinessOutfit()
        {
            this.builder.reset();
            this.builder.buildOuterwear();
            this.builder.buildTop();
            this.builder.buildBottom();
            this.builder.buildFootwear();
            this.builder.buildAccessories();
        }

        public void constructSportsOutfit()
        {
            this.builder.reset();
            this.builder.buildOuterwear();
            this.builder.buildTop();
            this.builder.buildBottom();
            this.builder.buildFootwear();
            this.builder.buildAccessories();
        }
    }
}