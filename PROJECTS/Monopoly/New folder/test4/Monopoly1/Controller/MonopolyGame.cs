using Microsoft.AspNetCore.Components.Web;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monopoly.View.Renderers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Color = Microsoft.Xna.Framework.Color;

namespace Monopoly.Controller
{
    public class MonopolyGame : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;
        public MonoGameRenderer Renderer;

        //Used when move the player - used MonoGameRenderer for MovePlayer Method
        public double Elapsed;

        public MonopolyGame()
        {
            //Intialize the GraphicsDeviceManger
            graphics = new GraphicsDeviceManager(this);
            //The Content Folder with pictures
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            //Set the resolution
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 700;

        }

        protected override void Initialize()
        {
            //Initialize the renderer and can use the MonoGameRenderer Method for all the buttons/backgrounds
            Renderer = new MonoGameRenderer();
            //States determine if the player turns, player needs to move, player landed on something
            //PlayersTurnState -> PlayersRollState -> PlayerMoveState -> PlayerLandedOnSomethingState
            //Iterate throught the states
            StateMachine.Initialize();
            StateMachine.CurrentState = StateMachine.States["InitialState"];
            StateMachine.CurrentState.Execute();
            StateMachine.ChangeState();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
        }

        //Update the StateMachine
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(KeySizes.Escape))
                Exit();
            Elapsed = (double)gameTime.ElapsedGameTime.TotalSeconds;
            StateMachine.CurrentState.Execute();
            base.Update(gameTime);
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            StateMachine.CurrentState.Draw(Renderer);
            SpriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
