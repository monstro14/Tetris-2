using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game6
{
    class block5 : blockbase
    {
        public block5()
        {
            blok = new int[3, 3]
            {
                { 0, 5, 0},
                { 0, 5, 0},
                { 5, 5, 0}
            };
        }
    }
}
