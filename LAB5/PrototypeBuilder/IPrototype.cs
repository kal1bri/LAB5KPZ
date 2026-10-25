using System;

namespace PrototypeBuilder
{
    public interface IPrototype
    {
        Outfit clone();
    }
}