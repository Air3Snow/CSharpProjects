using System;
using System.Collections.Generic;
using System.Text;

namespace TestReflect
{
    class JinDrugs : Drugs
    {
        public override void AddLife(ref Player player)
        {
            player.Life += 100;
        }
        
        public override void Move(Player player)
        {
            player.X += 64;
            player.Y += 32;
        }
    }
}
