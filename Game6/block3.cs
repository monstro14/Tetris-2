using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game6
{
    class block3 : blockbase
    {
        public block3()
        {
            blok = new int[3, 3]
            {
                { 0, 3, 3},
                { 3, 3, 0},
                { 0, 0, 0}
            };
        }
    }
}
