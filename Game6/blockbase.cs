using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game6
{
    class blockbase
    {
        public int[,] blok;

        public blockbase()
        {
        }

        public void Draw(GameTime gameTime, Texture2D blokje, SpriteBatch b, Vector2 offset, Vector2 position)
        {
            for (int i = blok.GetLength(0); i > 0; i--)
            {
                for (int j = blok.GetLength(0); j > 0; j--)
                {
                    Vector2 blokpos;
                    blokpos.X = (position.X + i - 1) * blokje.Width + offset.X;
                    blokpos.Y = (position.Y + j - 1) * blokje.Height + offset.Y;
                    if (blok[j - 1, i - 1] == 1)
                    {
                        b.Draw(blokje, blokpos, new Color(255, 0, 0));
                    }
                    else if (blok[j - 1, i - 1] == 2)
                    {
                        b.Draw(blokje, blokpos, new Color(0, 255, 0));
                    }
                    else if (blok[j - 1, i - 1] == 3)
                    {
                        b.Draw(blokje, blokpos, new Color(0, 0, 255));
                    }
                    else if (blok[j - 1, i - 1] == 4)
                    {
                        b.Draw(blokje, blokpos, new Color(255, 128, 0));
                    }
                    else if (blok[j - 1, i - 1] == 5)
                    {
                        b.Draw(blokje, blokpos, new Color(127, 0, 255));
                    }
                    else if (blok[j - 1, i - 1] == 6)
                    {
                        b.Draw(blokje, blokpos, new Color(255, 255, 0));
                    }
                    else if (blok[j - 1, i - 1] == 7)
                    {
                        b.Draw(blokje, blokpos, new Color(0, 255, 255));
                    }
                }
            }
        }
    }
}
