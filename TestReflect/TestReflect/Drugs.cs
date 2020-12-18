using System;
using System.Collections.Generic;
using System.Text;

namespace TestReflect
{
    class Drugs
    {
        public virtual void AddLife(ref Player player)
        {
            player.Life += 10;
        }

        public virtual void Move(Player player)
        {
            player.X += 64;
            player.Y -= 32;
        }
    }
}
