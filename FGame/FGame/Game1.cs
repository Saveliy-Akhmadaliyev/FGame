using FGame.Controller;
using FGame.Model;
using FGame.Model.Blocks;
using FGame.Model.Pages;
using FGame.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private IPage[] pages = new IPage[3];
        private IPage myPage;
        private IBlock[] blocks;
        private Block[,] gameBoard = new Block[48, 85];
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferHeight = 768;
            _graphics.PreferredBackBufferWidth = 1366;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            //blocks = new IBlock[8]
            //{
            //        new KnowBlock(Content.Load<Texture2D>("knowZone")),
            //        new UnKnowBlock(Content.Load<Texture2D>("unKnowZone")),
            //},;

            myPage = new MainPage(Page.Main,
                new Button(
                    Content.Load<Texture2D>("playButton"),
                    new Vector2(_graphics.PreferredBackBufferWidth / 2 - 200,
                    _graphics.PreferredBackBufferHeight / 2 - 50),
                    400, 100, Page.Game
                    ),
                new Button(
                    Content.Load<Texture2D>("infoButton"),
                    new Vector2(_graphics.PreferredBackBufferWidth / 2 - 200,
                    _graphics.PreferredBackBufferHeight / 2 + 100),
                    400, 100, Page.Info
                    )
                );

            pages[(int)Page.Main - 1] = myPage;
            pages[(int)Page.Game - 1] = new GamePage(Page.Game, 
                new IBlock[] 
                {
                    new KnowBlock(Content.Load<Texture2D>("knowZone")),
                    new UnKnowBlock(Content.Load<Texture2D>("unKnowZone"))
                },
                new Button(
                    Content.Load<Texture2D>("surrenderButton"),
                    new Vector2(_graphics.PreferredBackBufferWidth - 150, 50),
                    100, 25,Page.Main
                    )
                );
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MyMouse.GetMyMousePosition();

            myPage = PageLogic.ChoosePage(myPage, pages);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            Drawer.DrawButton(_spriteBatch, myPage);
            Drawer.DrawBlock(_spriteBatch, myPage);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
