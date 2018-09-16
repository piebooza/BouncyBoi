using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BouncyBoii
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D image;
        Color tint;
        Vector2 position;
        int Ground = 1920;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1920;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1080;   // set this value to the desired height of your window
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }
        
        protected override void Initialize()
        {
            image = Content.Load<Texture2D>("oof");
            position = new Vector2(0, 1018);
            tint = Color.White;
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void UnloadContent()
        {
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState ks = Keyboard.GetState();
            if(ks.IsKeyDown(Keys.D))
            {
                position.X++;
            }
            if (ks.IsKeyDown(Keys.A))
            {
                position.X--;
            }
            if (ks.IsKeyDown(Keys.Space))
            {
                
            }
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            spriteBatch.Draw(image, position, null, tint, 0, new Vector2(0, 0), .10f, SpriteEffects.None,0);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
