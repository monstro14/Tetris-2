using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game6
{
    class TetrisGrid
    {
        public int[,] grid;
        int score = 0;
        public int gridWidth = 12, gridHeight = 20;

        public TetrisGrid()
        {
            grid = new int[gridWidth, gridHeight];
        }

        public void reset()
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 12; j++)
                {
                    grid[j, i] = 0;
                }
        }

        public void checkrows()
        {
            for (int i = 19; i >= 0; i--)
            {
                int x = 0;
                for (int t = 0; t <= 11; t++)
                {
                    if (grid[t, i] > 0)
                        x += 1;

                    if (x == 12)
                    {
                        score += 100;
                        
                        for (int o = 19; o >= 1; o--)
                            for (int p = 0; p <= 11; p++)
                                grid[p, o] = grid[p, o - 1];

                        for (int p = 0; p <= 11; p++)
                            grid[p, 0] = 0;

                        i -= 1;
                    }
                }
            }
        }

        public void Draw(GameTime gameTime, Texture2D blokje, Texture2D blokje2, SpriteBatch b, Vector2 offset)
        {
            for (int i = gridHeight - 1; i >= 0; i--)
            {
                for (int t = 0; t <= 11; t++)
                {
                    int g = grid[t, i];
                    Vector2 pos;
                    pos.X = t * blokje.Width;
                    pos.Y = i * blokje.Width;
                    if (g > 0)
                    {
                        Color red = new Color(255, 0, 0);
                        b.Draw(blokje, pos + offset, red);
                    }
                    else
                        b.Draw(blokje2, pos + offset);
                }
            }
        }
    }
}
