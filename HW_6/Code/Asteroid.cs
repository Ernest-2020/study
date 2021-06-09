using System;
namespace Asteroids
{
    internal sealed class Asteroid : Enemy, ICloneable

    {
        public object Clone()
        {
            return new Asteroid();
        }
    }
}
