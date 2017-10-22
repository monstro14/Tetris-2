using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;

namespace Game6
{
    class GameWorld
    {
        enum GameState
        { Menu, Playing, GameOver}
        //enum Collision
        //{ set, fall, rotateR, rotateL, side}

        Vector2 Offset = new Vector2(0, 60), position = new Vector2(3, 0), previewpos = new Vector2(13, 1);
        public int Steptime = 500;
        int ElapsedTime = 0;
        int MouseElapsedTime = 0;

        Random r;
        public InputHelper input;

        GameState gameState;
        //Collision collision;

        TetrisGrid grid;

        blockbase nextblock, currentblock;

        block1 blok1;
        block2 blok2;
        block3 blok3;
        block4 blok4;
        block5 blok5;
        block6 blok6;
        block7 blok7;

        public GameWorld()
        {
            r = new Random();

            gameState = GameState.Playing;

            grid = new TetrisGrid();
            input = new InputHelper();
            grid.reset();

            blok1 = new block1();
            blok2 = new block2();
            blok3 = new block3();
            blok4 = new block4();
            blok5 = new block5();
            blok6 = new block6();
            blok7 = new block7();
            
        }

        public void HandleInput(GameTime gameTime, InputHelper inputHelper)
        {
            input.Update(gameTime);
            if (inputHelper.currentKeyboardState.IsKeyDown(Keys.A) && inputHelper.previousKeyboardState.IsKeyUp(Keys.A))
            { /* roteer linksom */

            }
               
            if (inputHelper.currentKeyboardState.IsKeyDown(Keys.D) && inputHelper.previousKeyboardState.IsKeyUp(Keys.D))
            {/* roteer rechtsom */ }

            if (inputHelper.currentKeyboardState.IsKeyDown(Keys.Left) && inputHelper.previousKeyboardState.IsKeyUp(Keys.Left))
            {
                position.X--;
            }

            if (inputHelper.currentKeyboardState.IsKeyDown(Keys.Right) && inputHelper.previousKeyboardState.IsKeyUp(Keys.Right))
            {
                position.X++;
            }
        }

        public void Update(GameTime gameTime)
        {
            if (gameState == GameState.Playing)
            {
                if (nextblock == null)
                    next();
                if (currentblock == null)
                {
                    position.X = r.Next(10);
                    currentblock = nextblock;
                    next();
                }

                ElapsedTime += gameTime.ElapsedGameTime.Milliseconds;
                if (ElapsedTime > Steptime)
                {
                    position.Y++;
                    ElapsedTime = 0;
                }
            }

            if (gameState == GameState.GameOver)
            {
                reset();
            }
        }

        public void Draw(GameTime gameTime, Texture2D a, Texture2D b, SpriteBatch spriteBatch)
        {
            if (gameState == GameState.Playing)
            {
                spriteBatch.Begin();
                grid.Draw(gameTime, a, b, spriteBatch, Offset);
                currentblock.Draw(gameTime, a, spriteBatch, Offset, position);
                nextblock.Draw(gameTime, a, spriteBatch, Offset, previewpos);
                spriteBatch.End();
            }
        }

        public void reset()
        {
            grid.reset();
            next();
            currentblock = nextblock;
            next();
        }

        //public void collisioncheck()
        //{
        //    int length = currentblock.blok.GetLength(0);
        //    for(int i = 0; i < length; i++)
        //        for (int t = 0; t < length; t++)
        //        {
        //            if (currentblock.blok[t, i] > 0 && position.X + t > 12)
        //                position.X = 10 - t;
        //            if (currentblock.blok[t, i] > 0 && position.X + t < 0)
        //                position.X = 0 + t;
        //        }
        //}

        public void next()
        {
            int x = r.Next(7);

            switch (x)
            {
                case 0:
                    nextblock = new block1();
                    nextblock.blok = blok1.blok;
                    break;
                case 1:
                    nextblock = new block2();
                    nextblock.blok = blok2.blok;
                    break;
                case 2:
                    nextblock = new block3();
                    nextblock.blok = blok3.blok;
                    break;
                case 3:
                    nextblock = new block4();
                    nextblock.blok = blok4.blok;
                    break;
                case 4:
                    nextblock = new block5();
                    nextblock.blok = blok5.blok;
                    break;
                case 5:
                    nextblock = new block6();
                    nextblock.blok = blok6.blok;
                    break;
                case 6:
                    nextblock = new block7();
                    nextblock.blok = blok7.blok;
                    break;
                default:
                    nextblock = new block1();
                    nextblock.blok = blok1.blok;
                    break;
            }
        }
    }
}
