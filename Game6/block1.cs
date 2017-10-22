using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game6
{
    class block1 : blockbase
    {
        public block1()
        {
            blok = new int[3, 3]
            {
                { 1, 1, 1},
                { 0, 1, 0},
                { 0, 0, 0}
            };
        }
    }
}
