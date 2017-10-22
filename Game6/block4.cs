using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game6
{
    class block4 : blockbase
    {
        public block4()
        {
            blok = new int[3, 3]
            {
                { 0, 4, 0},
                { 0, 4, 0},
                { 0, 4, 4}
            };
        }
    }
}
