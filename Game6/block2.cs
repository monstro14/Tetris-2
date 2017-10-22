using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game6
{
    class block2 : blockbase
    {
        public block2()
        {
            blok = new int[3, 3]
            {
                { 2, 2, 0},
                { 0, 2, 2},
                { 0, 0, 0}
            };
        }
    }
}
