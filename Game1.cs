using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        private Texture2D _texture;
        private Vector2 _position;

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            _texture = Content.Load<Texture2D>("spaceship");
            _position = new Vector2(375, 250);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.W))
            {
                //up
                _position.Y -= 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                //down
                _position.Y += 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //Left
                _position.X -= 7;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //right
                _position.X += 7;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                //Fire();
            }


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(_texture, _position, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void Fire()
        {
            // Projectile
        }
    }
}