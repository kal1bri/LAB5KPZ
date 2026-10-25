using System;

namespace PrototypeBuilder
{
    public abstract class OutfitBuilder
    {
        public abstract void reset();
        public abstract void buildOuterwear();
        public abstract void buildTop();
        public abstract void buildBottom();
        public abstract void buildFootwear();
        public abstract void buildAccessories();
        public abstract Outfit getResult();
    }
}