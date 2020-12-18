using System;
using System.Collections.Generic;
using System.Text;

namespace TestReflect
{
    public class Player
    {
        string name;
        int x = 0;
        int y = 0;
        int life = 0;

        public Player(string name)
        {
            this.name = name;
        }

        public int X { set; get; }
        public int Y { set; get; }
        public int Life { set; get; }
        public string Name { get => name; set => name = value; }
    }
}
