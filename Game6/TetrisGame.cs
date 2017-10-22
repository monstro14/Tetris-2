using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace Game6
{
    public class TetrisGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameWorld gameWorld;
        InputHelper input;
        Texture2D blokje, blokje2;

        public TetrisGame()
        {
            graphics = new GraphicsDeviceManager(this);
            gameWorld = new GameWorld();
            input = new InputHelper();
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 700;
            graphics.PreferredBackBufferHeight = 700;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            blokje = Content.Load<Texture2D>("blokje");
            blokje2 = Content.Load<Texture2D>("achtergrondblokje");

            MediaPlayer.Play(Content.Load<Song>("SOUNDTRACK"));
            SoundEffect clearRow = Content.Load<SoundEffect>("CLEAR");
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        //public void HandleInput(GameTime gameTime)
        //{
        //    input.Update(gameTime);
        //    gameWorld.HandleInput(input);
        //}

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            gameWorld.Update(gameTime);
            input.Update(gameTime);                
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            gameWorld.Draw(gameTime, blokje, blokje2, spriteBatch);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
