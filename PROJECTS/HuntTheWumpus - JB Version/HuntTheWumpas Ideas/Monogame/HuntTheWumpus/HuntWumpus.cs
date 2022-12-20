using HuntTheWumpus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace HuntTheWumpas
{
    public class HuntWumpus : Game
    {
        //==============================================<VARIABLES>==============================================\\
        //DEFAULT
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Mouse position
        Vector2 position;

        //Render for 1080p res
        RenderTarget2D renderTarget;
        public float scale = 0.44444f;

        //Intro Gamestate
        Texture2D introBackground;
        Texture2D playBtn1;
        Texture2D playBtn2;
        Texture2D helpBtn1;
        Texture2D helpBtn2;
        Texture2D quitBtn1;
        Texture2D quitBtn2;
        Texture2D wumpus;
        Texture2D wumpusFlipped;
        Texture2D backBtn1;

        //Entrance Gamestate
        Texture2D upBtn1;
        Texture2D upBtn2;

        //Corridor Gamestate
        Texture2D corridor1;
        Texture2D upBtn3;
        Texture2D upBtn4;
        Texture2D leftBtn1;
        Texture2D leftBtn2;
        Texture2D rightBtn1;
        Texture2D rightBtn2;


        //M4 Rifle
        Texture2D buttonRifle_norm;
        Texture2D buttonRifle_red;
        Texture2D buttonRifle_blue;
        Texture2D buttonRifle_yellow;
        Texture2D buttonRifle_green;
        Texture2D ironSight_none;
        Texture2D ironSight_hit;
        Texture2D ironSight_miss;
        Texture2D ironSight_target;

        Texture2D bat1;
        //Arrows
        //Texture2D fireBtn1;
        //Texture2D fireBtn2;
        //Texture2D fireBtn3;

        //Intro GameState
        public float wumpusPositionValue;
        public float wumpusFlippedPositionValue;
        public float wumpusSpeed;
        public float playBtn1PositionX;
        public float playBtn2PositionX;
        public float helpBtn1PositionX;
        public float helpBtn2PositionX;
        public float quitBtn1PositionX;
        public float quitBtn2PositionX;
        public bool resolutionSwitch;
        public bool introOverCondtion;

        float timer = 1;
        const float TIMER = 1;

        bool playingSongSwitch;
        bool buttonCondition;

        //Corridor Gamestate
        int bulletsRemaining;
        int currentPlayerPosition;
        bool fireCondition;

        //Sprite Sizes
        public float screenSizeX;
        public float screenSizeY;

        //Entrance GameState
        Texture2D caveEntrance;

        //Sprite Fonts
        public SpriteFont fpsFont;
        public SpriteFont rulesFont;
        public SpriteFont corridorFont;

        //Sounds &  Songs
        Song introSong;
        Song playSong;
        SoundEffect chirp;
        SoundEffect falling;
        SoundEffect fireM4;
        SoundEffect hitM4;
        SoundEffect missM4;

        //==============================================<GAME ENUMS>==============================================\\
        //Game States
        enum GameState
        {
            IntroMenu,
            HelpScreen,
            Entrance,
            CaveCorridor,
            BatRoom,
            WumpusRoom,
            PitRoom,
            BreezeRoom,
            SmellRoom,
            FlappingRoom,
            Mainboard,
        }
        GameState CurrentGameState = GameState.Mainboard;

        //==============================================<METHODS>==============================================\\
        public HuntWumpus()//Game1
        {
            //DEFAULT
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //Call this to show the cursor in the game
            IsMouseVisible = true;

            //Frame Rate Adjustment
            //Turn up the speed - FPS - "Desyncing"
            this.IsFixedTimeStep = true;//False for faster
            this._graphics.SynchronizeWithVerticalRetrace = true;//False for faster
            //This allows you to choose the framerate make sure the _graphics.SynchronizeWithVerticalRetrace is true
            this.TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 33);//set isfixedtime to true for this - 33 is the framerate you want
        }

        ////OPTION 2 - When the game is paused from toggling a diff app the Title changes name
        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "Activated App";
            base.OnActivated(sender, args);
        }
        protected override void OnDeactivated(object sender, EventArgs args)
        {
            Window.Title = "Unactivated App";
            base.OnActivated(sender, args);
        }



        #region METHOD & VARIABLE Archive Code
        //Red Square
        //Texture2D texture;

        //==============================================<Window Title Active/Unactive>==============================================\\
        ////OPTION 1 - When the game is paused from toggling a diff app the Title changes name
        //this.Activated += (sender, args) => { this.Window.Title = "Active.Application"; };
        //this.Deactivated += (sender, args) => { this.Window.Title = "Unactive.Application"; };
        #endregion

        //==============================================<INITIALIZE>==============================================\\
        protected override void Initialize()
        {
            //Max Resolution to 1280 Outside
            //Change the resolution of the screen
            _graphics.PreferredBackBufferWidth = 1280;//Width
            _graphics.PreferredBackBufferHeight = 720;//height
            //_graphics.IsFullScreen = true;//will freeze 
            _graphics.ApplyChanges();//Must apply changes

            base.Initialize();

            #region INITIALIZE Archive Code
            //Position Red Square
            //RED SQUARE - set position and size
            position = new Vector2(0, 0);
            Texture2D texture = new Texture2D(this.GraphicsDevice, 100, 100);
            Color[] colorData = new Color[100 * 100];
            for (int i = 0; i < 10000; i++)
            {
                colorData[i] = Color.Red;
                texture.SetData<Color>(colorData);
            }
            #endregion
        }

        //==============================================<LOAD>==============================================\\
        //Load Content is loaded as soon as boot up of game
        protected override void LoadContent()
        {
            currentPlayerPosition = 1;

            Random randomNumber = new Random();
            int randomCaveNumber = randomNumber.Next(2, 20);

            //Arrows Players Starts with
            bulletsRemaining = 5;

            //Set the screen size for use in the Draw Sprites
            screenSizeX = 1920;
            screenSizeY = 1080;

            //DEFAULT
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Load INTRO GAMESTATE- Images/Sprites
            introBackground = Content.Load<Texture2D>("Images/Intro/background");
            playBtn1 = Content.Load<Texture2D>("Images/Intro/PlayBtn/playbtn3");
            playBtn2 = Content.Load<Texture2D>("Images/Intro/PlayBtn/playbtn2");
            helpBtn1 = Content.Load<Texture2D>("Images/Intro/HelpBtn/HelpBtn1");
            helpBtn2 = Content.Load<Texture2D>("Images/Intro/HelpBtn/HelpBtn3");
            quitBtn1 = Content.Load<Texture2D>("Images/Intro/QuitBtn/QuitButton1");
            quitBtn2 = Content.Load<Texture2D>("Images/Intro/QuitBtn/QuitButton3");
            wumpus = Content.Load<Texture2D>("Images/Intro/Wumpus/wumpus");
            wumpusFlipped = Content.Load<Texture2D>("Images/Intro/Wumpus/wumpusFlipped");
            backBtn1 = Content.Load<Texture2D>("Images/Direction/Back/backBtn1");

            //Mainboard
            bat1 = Content.Load<Texture2D>("Images/Bats/bat (1)");



            //Load PLAYING GAMESTATE - Images/Sprites
            upBtn1 = Content.Load<Texture2D>("Images/Direction/Up/up2");//Entrance Only
            upBtn2 = Content.Load<Texture2D>("Images/Direction/Up/up1");//Entrance Only
            upBtn3 = Content.Load<Texture2D>("Images/Direction/Up/up2");
            upBtn4 = Content.Load<Texture2D>("Images/Direction/Up/up1");

            leftBtn1 = Content.Load<Texture2D>("Images/Direction/Left/left1");
            leftBtn2 = Content.Load<Texture2D>("Images/Direction/Left/left2");
            rightBtn1 = Content.Load<Texture2D>("Images/Direction/Right/right1");
            rightBtn2 = Content.Load<Texture2D>("Images/Direction/Right/right2");

            //Arrows
            //fireBtn1 = Content.Load<Texture2D>("Images/FireBtn/fireBtn2");
            //fireBtn2 = Content.Load<Texture2D>("Images/FireBtn/fireBtn3");
            //fireBtn3 = Content.Load<Texture2D>("Images/FireBtn/fireBtn4");

            //M4
            buttonRifle_norm = Content.Load<Texture2D>("Images/FireBtn/m4Rifle");
            buttonRifle_red = Content.Load<Texture2D>("Images/FireBtn/m4RifleRed");
            buttonRifle_blue = Content.Load<Texture2D>("Images/FireBtn/m4RifleBlue");
            buttonRifle_green = Content.Load<Texture2D>("Images/FireBtn/m4RifleGreen");
            buttonRifle_yellow = Content.Load<Texture2D>("Images/FireBtn/m4RifleYellow");
            ironSight_none = Content.Load<Texture2D>("Images/FireBtn/ironSight_none");
            ironSight_hit = Content.Load<Texture2D>("Images/FireBtn/ironSight_hit");
            ironSight_miss = Content.Load<Texture2D>("Images/FireBtn/ironSight_miss");
            ironSight_target = Content.Load<Texture2D>("Images/FireBtn/ironSight_target");


            //Load CORRRIDOR GAMESTATE - Images/Sprites
            corridor1 = Content.Load<Texture2D>("Images/Cave/caveTunnel");


            //Load PLAY Images/Sprites
            caveEntrance = Content.Load<Texture2D>("Images/Cave/caveEntranceBW2");

            //Target 1080p resolution
            renderTarget = new RenderTarget2D(GraphicsDevice, 1920, 1080);

            //Load Fonts
            fpsFont = Content.Load<SpriteFont>(@"Font\FPS");
            rulesFont = Content.Load<SpriteFont>(@"Font\rulesFont");
            corridorFont = Content.Load<SpriteFont>(@"Font\corridorFont");

            //Load Songs>
            introSong = Content.Load<Song>("Sound/introSong");
            playSong = Content.Load<Song>("Sound/playSong");
            MediaPlayer.Play(introSong);
            MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChanged;

            //Load SOund Effects
            chirp = Content.Load<SoundEffect>("Sound/chirping");
            falling = Content.Load<SoundEffect>("Sound/falling Sound");
            fireM4 = Content.Load<SoundEffect>("Sound/fireM4Sound");
            hitM4 = Content.Load<SoundEffect>("Sound/hitSound");
            missM4 = Content.Load<SoundEffect>("Sound/missSound");

            //Variable Assignments
            wumpusPositionValue = -1800;
            wumpusFlippedPositionValue = 1980;
            wumpusSpeed = 300;
            playBtn1PositionX = 270;
            playBtn2PositionX = 270;
            helpBtn1PositionX = 670;
            helpBtn2PositionX = 670;
            quitBtn1PositionX = 1170;
            quitBtn2PositionX = 1170;

            //Button
            buttonCondition = true;
            playingSongSwitch = true;

            //GameState Condition
            introOverCondtion = true;
            fireCondition = true;

            //Get mouse state for hover picture changes
            var mouseState = Mouse.GetState();
            //Get the mouse position in screen coordinates relative to the top left corner
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            resolutionSwitch = true;

        }

        private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
        {
            MediaPlayer.Volume -= 0.0f;
            MediaPlayer.Play(introSong);
        }


        //==============================================<UNLOAD>==============================================\\
        //Not a defualt, this cleans the memory
        protected override void UnloadContent()
        {
            ////Clean up the memory from the texture of the red square
            //texture.Dispose();
            //base.UnloadContent();
        }

        //==============================================<UPDATE>==============================================\\
        protected override void Update(GameTime gameTime)
        {
            //IsActive pauses the game if the window isn't active
            if (IsActive)
            {
                //Setup for Mouse Inputs
                MouseState state = Mouse.GetState();
                MouseState mouseState;
                //Get mouse state for hover picture changes
                mouseState = Mouse.GetState();
                //Get the mouse position in screen coordinates relative to the top left corner
                var mousePosition = new Point(mouseState.X, mouseState.Y);

                //Mouse Coordinates Inputs - Displays in the Output Console
                position.X = state.X;
                position.Y = state.Y;
                System.Diagnostics.Debug.WriteLine(state.X.ToString() + "," + state.Y.ToString());

                //Change Screen Size with Spacebar
                if (resolutionSwitch == true && Keyboard.GetState().IsKeyDown(Keys.Space))
                {
                    UpdateScreen(1920, 1080);
                    resolutionSwitch = false;
                }
                else if (resolutionSwitch == false && Keyboard.GetState().IsKeyDown(Keys.Space))
                {
                    UpdateScreen(1280, 720);
                    resolutionSwitch = true;
                }

                //GameState 
                switch (CurrentGameState)
                {
                    case GameState.IntroMenu:
                        break;
                    case GameState.HelpScreen:
                        GraphicsDevice.Clear(Color.CornflowerBlue);
                        if (mouseState.LeftButton == ButtonState.Pressed)
                        {
                            CurrentGameState = GameState.IntroMenu;
                        }
                        break;
                    case GameState.Entrance:
                        Rectangle upBtn1Area = new Rectangle(Convert.ToInt32(screenSizeX) - 740, Convert.ToInt32(screenSizeY) - 810, 150, 300);
                        if (resolutionSwitch == false)
                        {
                            upBtn1Area = new Rectangle(Convert.ToInt32(screenSizeX) - 190, Convert.ToInt32(screenSizeY) - 677, 120, 257);
                        }
                        //Clear the Screen
                        GraphicsDevice.Clear(Color.White);
                        introOverCondtion = false;
                        //Stop & Start new sound
                        if (playingSongSwitch == true)
                        {
                            MediaPlayer.Stop();
                            MediaPlayer.Volume -= 0.1f;
                            MediaPlayer.Play(playSong);
                            playingSongSwitch = false;
                        }
                        if (upBtn1Area.Contains(mousePosition))
                        {
                            upBtn1 = upBtn2;
                        }
                        if (!upBtn1Area.Contains(mousePosition))
                        {
                            upBtn1 = Content.Load<Texture2D>("Images/Direction/Up/up2");
                            upBtn2 = Content.Load<Texture2D>("Images/Direction/Up/up1");
                        }
                        if (mouseState.LeftButton == ButtonState.Pressed && upBtn1Area.Contains(mousePosition))
                        {
                            CurrentGameState = GameState.CaveCorridor;
                        }
                        break;
                    case GameState.CaveCorridor:
                        GraphicsDevice.Clear(Color.White);
                        if (playingSongSwitch == true)
                        {
                            MediaPlayer.Stop();
                            MediaPlayer.Volume -= 0.1f;
                            MediaPlayer.Play(playSong);
                            playingSongSwitch = false;
                        }

                        //Directional Buttons Change Color
                        Rectangle upBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 1010, Convert.ToInt32(screenSizeY) - 680, 84, 125);
                        Rectangle leftBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 1200, Convert.ToInt32(screenSizeY) - 570, 180, 90);
                        Rectangle rightBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 920, Convert.ToInt32(screenSizeY) - 580, 180, 88);
                        Rectangle m4BtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 1080, Convert.ToInt32(screenSizeY) - 478, 190, 76);
                        if (resolutionSwitch == false)
                        {
                            upBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 574, Convert.ToInt32(screenSizeY) - 504, 132, 220);
                            leftBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 834, Convert.ToInt32(screenSizeY) - 315, 280, 120);
                            rightBtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 417, Convert.ToInt32(screenSizeY) - 327, 266, 133);
                            m4BtnArea = new Rectangle(Convert.ToInt32(screenSizeX) - 659, Convert.ToInt32(screenSizeY) - 172, 450, 80);
                        }
                        //Change Button Colors/Images 
                        if (!leftBtnArea.Contains(mousePosition) || !upBtnArea.Contains(mousePosition) || !rightBtnArea.Contains(mousePosition) || !m4BtnArea.Contains(mousePosition))
                        {
                            //Direction Arrows
                            upBtn3 = Content.Load<Texture2D>("Images/Direction/Up/up2");
                            upBtn4 = Content.Load<Texture2D>("Images/Direction/Up/up1");
                            leftBtn1 = Content.Load<Texture2D>("Images/Direction/Left/left1");
                            leftBtn2 = Content.Load<Texture2D>("Images/Direction/Left/left2");
                            rightBtn1 = Content.Load<Texture2D>("Images/Direction/Right/right1");
                            rightBtn2 = Content.Load<Texture2D>("Images/Direction/Right/right2");

                            //M4
                            buttonRifle_norm = Content.Load<Texture2D>("Images/FireBtn/m4Rifle");
                            buttonRifle_red = Content.Load<Texture2D>("Images/FireBtn/m4RifleRed");
                            buttonRifle_blue = Content.Load<Texture2D>("Images/FireBtn/m4RifleBlue");
                            buttonRifle_green = Content.Load<Texture2D>("Images/FireBtn/m4RifleGreen");
                            buttonRifle_yellow = Content.Load<Texture2D>("Images/FireBtn/m4RifleYellow");

                        }
                        if (leftBtnArea.Contains(mousePosition) || upBtnArea.Contains(mousePosition) || rightBtnArea.Contains(mousePosition) || m4BtnArea.Contains(mousePosition))
                        {
                            if (leftBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                            {
                                leftBtn1 = leftBtn2;
                            }
                            if (upBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                            {
                                upBtn3 = upBtn4;
                            }
                            if (rightBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                            {
                                rightBtn1 = rightBtn2;
                            }
                            if (m4BtnArea.Contains(mousePosition)) 
                            {
                            buttonRifle_norm = buttonRifle_red;
                            }
                        }
                        if (fireCondition == true)
                        {
                            if ((m4BtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed))
                            {
                                fireM4.Play();
                                fireCondition = false;
                                _spriteBatch.Draw(ironSight_none, new Rectangle(50, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                            }

                        }




                        //Cavern Directions


                        break;
                    case GameState.BatRoom:
                        break;
                    case GameState.WumpusRoom:
                        break;
                    case GameState.PitRoom:
                        break;
                    case GameState.BreezeRoom:
                        break;
                    case GameState.SmellRoom:
                        break;
                    case GameState.FlappingRoom:
                        break;



                    default:
                        break;
                }

                //==============================================<INTRO GAMESTATE>==============================================\\
                if (introOverCondtion == true)
                {
                    //Change the image when mouse is inside a certain area
                    Rectangle playBtnArea = new Rectangle(200, 338, 200, 120);
                    Rectangle helpBtnArea = new Rectangle(520, 338, 200, 120);
                    Rectangle quitBtnArea = new Rectangle(850, 338, 200, 120);
                    if (resolutionSwitch == false)
                    {
                        playBtnArea = new Rectangle(300, 510, 300, 175);
                        helpBtnArea = new Rectangle(780, 510, 300, 175);
                        quitBtnArea = new Rectangle(1280, 510, 300, 175);
                    }

                    //Change Button Colors/Images
                    if ((!playBtnArea.Contains(mousePosition)) || (!helpBtnArea.Contains(mousePosition) || (!quitBtnArea.Contains(mousePosition))))
                    {
                        IntroButtonColorChanges();
                        playBtn1 = Content.Load<Texture2D>("Images/Intro/PlayBtn/playbtn3");
                        playBtn2 = Content.Load<Texture2D>("Images/Intro/PlayBtn/playbtn2");
                        helpBtn1 = Content.Load<Texture2D>("Images/Intro/HelpBtn/HelpBtn1");
                        helpBtn2 = Content.Load<Texture2D>("Images/Intro/HelpBtn/HelpBtn3");
                        quitBtn1 = Content.Load<Texture2D>("Images/Intro/QuitBtn/QuitButton1");
                        quitBtn2 = Content.Load<Texture2D>("Images/Intro/QuitBtn/QuitButton3");
                    }
                    if ((playBtnArea.Contains(mousePosition)) || (helpBtnArea.Contains(mousePosition) || (quitBtnArea.Contains(mousePosition))))
                    {
                        if (playBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                        {
                            playBtn1 = playBtn2;
                        }
                        if (helpBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                        {
                            helpBtn2 = helpBtn1;
                        }
                        if (quitBtnArea.Contains(mousePosition) || mouseState.LeftButton == ButtonState.Pressed)
                        {
                            quitBtn2 = quitBtn1;
                        }
                        IntroButtonColorChanges();
                    }
                    if (helpBtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed)
                    {
                        GraphicsDevice.Clear(Color.CornflowerBlue);
                    }

                    void IntroButtonColorChanges()
                    {
                        //INTRO SCREEN - Button Changes
                        void Button1ColorChange()
                        {
                            playBtn2PositionX = 270;
                            playBtn1PositionX = 4000;
                            helpBtn1PositionX = 670;
                            helpBtn2PositionX = 4000;
                            quitBtn1PositionX = 1170;
                            quitBtn2PositionX = 4000;
                        }
                        void Button2ColorChange()
                        {
                            playBtn2PositionX = 4000;
                            playBtn1PositionX = 270;
                            helpBtn1PositionX = 4000;
                            helpBtn2PositionX = 670;
                            quitBtn1PositionX = 4000;
                            quitBtn2PositionX = 1170;
                        }
                        //Timer for buttons to switch images
                        float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
                        timer -= elapsed;
                        if (timer < 0)
                        {
                            if (buttonCondition == false)
                            {
                                Button1ColorChange();
                                buttonCondition = true;
                            }
                            else
                            {
                                Button2ColorChange();
                                buttonCondition = false;
                            }
                            timer = TIMER;
                        }
                    }

                    //INTRO SCREEN - Update Wupmus Movement
                    void WumpusMovement()
                    {
                        wumpusPositionValue += wumpusSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        if (wumpusPositionValue >= wumpusFlippedPositionValue)
                        {
                            wumpusPositionValue += 0f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                            wumpusPositionValue = 2400;
                            wumpusFlippedPositionValue -= wumpusSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                            if (wumpusFlippedPositionValue <= -500)
                            {
                                wumpusPositionValue = -500;
                                wumpusFlippedPositionValue -= 0f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                                wumpusFlippedPositionValue = 1980;
                            }

                        }
                        if (wumpusSpeed >= 300 && wumpusSpeed <= 500)
                        {
                            wumpusSpeed = wumpusSpeed + 1;
                        }
                        else
                        {
                            wumpusSpeed = 300;
                        }
                    }
                    WumpusMovement();

                    //Play Button Activiation
                    if (mouseState.LeftButton == ButtonState.Pressed && (playBtnArea.Contains(mousePosition)))
                    {
                        CurrentGameState = GameState.Entrance;
                    }

                    //Help Button Activiation
                    if (mouseState.LeftButton == ButtonState.Pressed && (helpBtnArea.Contains(mousePosition)))
                    {
                        CurrentGameState = GameState.HelpScreen;
                    }

                    //Quit Button Activiation
                    if (mouseState.LeftButton == ButtonState.Pressed && (quitBtnArea.Contains(mousePosition)))
                    {
                        Exit();
                    }
                }
                //Default Update
                base.Update(gameTime);
            }
            #region UPDATE Archive Code
            ////Default Escape out of program
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();

            //==============================================<Keyboard Inputs>==============================================\\
            //KeyboardState state = Keyboard.GetState();
            //if (state.IsKeyDown(Keys.Escape))
            //{
            //    Exit();
            //}
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //foreach (var key in state.GetPressedKeys())
            //{
            //    sb.Append("Keys: ").Append(key).Append(" pressed ");
            //}
            //if (sb.Length > 0)
            //{
            //    System.Diagnostics.Debug.WriteLine(sb.ToString());
            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("No keys pressed");
            //}
            //if (state.IsKeyDown(Keys.Right))
            //{
            //    position.X += 10;
            //}
            //if (state.IsKeyDown(Keys.Left))
            //{
            //    position.X -= 10;
            //}
            //if (state.IsKeyDown(Keys.Up))
            //{
            //    position.Y -= 10;
            //}
            //if (state.IsKeyDown(Keys.Down))
            //{
            //    position.Y += 10;
            //}

            ////RED SQUARE - Set the position and if it rolls off the screen roll back to the position
            //position.X += 60f * (float)gameTime.ElapsedGameTime.TotalSeconds;//Split speed of this into 60th chunck - 60f is frame seconds you want, cast into float cause game sec is double
            //if (position.X > this.GraphicsDevice.Viewport.Width)
            //{
            //    position.X = 0;
            //}
            #endregion
        }

        //Change Screen Size
        void UpdateScreen(int width, int height)
        {
            _graphics.PreferredBackBufferWidth = width;
            _graphics.PreferredBackBufferHeight = height;
            _graphics.ApplyChanges();
        }


        //==============================================<DRAW>==============================================\\
        //Draw should be graphics only
        protected override void Draw(GameTime gameTime)
        {
            scale = 1F / (1080F / _graphics.GraphicsDevice.Viewport.Height);

            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.CornflowerBlue);



            //Intro Button Positions
            Vector2 playBtn1Vector = new Vector2(playBtn1PositionX, 490);
            Vector2 playBtn2Vector = new Vector2(playBtn2PositionX, 490);
            Vector2 helpBtn1Vector = new Vector2(helpBtn1PositionX, 430);
            Vector2 helpBtn2Vector = new Vector2(helpBtn2PositionX, 430);
            Vector2 quitBtn1Vector = new Vector2(quitBtn1PositionX, 430);
            Vector2 quitBtn2Vector = new Vector2(quitBtn2PositionX, 430);


            //Game Times and FPS
            var fps = 1 / gameTime.ElapsedGameTime.TotalSeconds;
            var totalRunTime = InactiveSleepTime.TotalSeconds - gameTime.TotalGameTime.TotalSeconds;
            var totalElapsedTime = gameTime.ElapsedGameTime.TotalSeconds;

            //Start GameState
            _spriteBatch.Begin();
            switch (CurrentGameState)
            {
                case GameState.Mainboard:
                    //_spriteBatch.Draw(bat1, new Vector2(0, 250), null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    int size = 6;

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            var x = i * 250;
                            var y = j * 250;
                            _spriteBatch.Draw(bat1, new Vector2(x, y), null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);

                            //if (newMap[j, i].Player == true)
                            //{
                            //    Console.Write($"[{newMap[j, i].Column},{newMap[j, i].Row}]  ");
                            //}
                            //else
                            //    Console.Write($" {newMap[j, i].Column},{newMap[j, i].Row}   ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    //_spriteBatch.Draw(bat1, playBtn2Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    break;
                case GameState.IntroMenu:

                    //batch - grouping of Draw calls, sprite - creates a camera effect for 2d images
                    _spriteBatch.Draw(introBackground, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);

                    //Frames Per Second and Total ACTIVE Run Time
                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    {
                        _spriteBatch.DrawString(fpsFont, $"FPS: {fps}" + $"Total Run Time: {totalRunTime} " + $"Elasped: {totalElapsedTime}", new Vector2(1, screenSizeY - 20), Color.White);
                    }
                    _spriteBatch.Draw(playBtn2, playBtn2Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(playBtn1, playBtn1Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(helpBtn1, helpBtn1Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(helpBtn2, helpBtn2Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(quitBtn1, quitBtn1Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(quitBtn2, quitBtn2Vector, null, Color.White, 0f, Vector2.Zero, .5f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(wumpus, new Rectangle(Convert.ToInt32(wumpusPositionValue), 740, 500, 300), Color.White);
                    _spriteBatch.Draw(wumpusFlipped, new Rectangle(Convert.ToInt32(wumpusFlippedPositionValue), 740, 500, 300), Color.White);

                    break;
                case GameState.HelpScreen:
                    _spriteBatch.Draw(backBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 500, Convert.ToInt32(screenSizeY) - 350, 400, 200), Color.White);
                    _spriteBatch.DrawString(rulesFont, @"About Hunt the Wumpus
    The original version of Hunt the Wumpus was created by Gregory Yob in 1972.
    The original version was quite a bit different than this version: it was text 
    based, and was based on the vertices of a collapsed dodecahedron
    (rather than a grid).Each room(vertex)connected to 3 others(rather than four).
    You can read more about it in the author's Hunt the Wumpus.

                            Rules(for this version)
                            There are 3 hazards:
                        A bottomless pit(you will feel a breeze nearby).
    A colony of bats that will pick you up and drop you in a random space,
    including potentially deadly spaces(you will hear flapping nearby).
    A fearsome, hungry, and unbathed wumpus(you will smell it nearby).
    The wumpus is heavy; bats cannot lift him.
    The wumpus is covered in suckers; he won't fall down the bottomless pit.
    Firing an arrow that misses the wumpus may cause it to move.
    You have 5 wumpus - piercing arrows.
    You may find an arrow dropped by a previous hunter

This version of the game was created by James Silcott, enjoy~!", new Vector2(1, 50), Color.White);
                    break;
                case GameState.Entrance:
                    _spriteBatch.Draw(caveEntrance, new Rectangle(0, 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY))), Color.White);
                    _spriteBatch.Draw(upBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 160, Convert.ToInt32(screenSizeY) - 700, 150, 300), Color.White);

                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    {
                        _spriteBatch.DrawString(fpsFont, $"FPS: {fps}" + $"Total Run Time: {totalRunTime} " + $"Elasped: {totalElapsedTime}", new Vector2(screenSizeX - 800, 1), Color.Black);

                    }
                    _spriteBatch.DrawString(rulesFont, @"
                Your adventure begins at an cavern entrance to Hunt the Wumpus.
                    You have your trusty bow and 5 Wumpus piercing arrows.", new Vector2(1, -20), Color.Black);
                    _spriteBatch.DrawString(rulesFont, @"
                Use them sparingly or find yourself face to face with the beast
                  Select the directional arrow to enter and happy hunting!", new Vector2(1, screenSizeY - 165), Color.Black);
                    break;
                case GameState.CaveCorridor:
                    GraphicsDevice.Clear(Color.White);
                    _spriteBatch.Draw(corridor1, new Rectangle(50, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                    _spriteBatch.Draw(upBtn3, new Rectangle(Convert.ToInt32(screenSizeX) - 575, Convert.ToInt32(screenSizeY) - 525, 150, 250), Color.White);
                    _spriteBatch.Draw(leftBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 850, Convert.ToInt32(screenSizeY) - 325, 300, 150), Color.White);
                    _spriteBatch.Draw(rightBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 425, Convert.ToInt32(screenSizeY) - 325, 300, 150), Color.White);
                    //Arrow
                    //_spriteBatch.Draw(fireBtn2, new Rectangle(Convert.ToInt32(screenSizeX) - 625, Convert.ToInt32(screenSizeY) - 625, 300, 300), Color.White);
                    _spriteBatch.Draw(buttonRifle_norm, new Rectangle(Convert.ToInt32(screenSizeX) - 680, Convert.ToInt32(screenSizeY) - 225, 400, 200), Color.White);
                    _spriteBatch.DrawString(corridorFont, @"
   You have reached a corridor, 
   You detect nothing...

   Choose a path: 
   Left, Right, or Straight Ahead
   Or shoot your M4 Rifle
   Bullets Remaining: " + $"{bulletsRemaining}", new Vector2(1, screenSizeY - 550), Color.Black);
                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    {
                        _spriteBatch.DrawString(fpsFont, $"FPS: {fps}, " + $"Elasped: {totalElapsedTime}, and " + $"Total Run Time: {totalRunTime}", new Vector2(10, screenSizeY - 50), Color.Black);

                    }
                    var caves = new Dictionary<int, CavernDirections>()
                    {
                        [1] = new CavernDirections { CavernNumberStraightAhead = 8, CavernNumberToTheLeft = 5, CavernNumberToTheRight = 2 },
                        [2] = new CavernDirections { CavernNumberStraightAhead = 10, CavernNumberToTheLeft = 1, CavernNumberToTheRight = 3 },
                        [3] = new CavernDirections { CavernNumberStraightAhead = 12, CavernNumberToTheLeft = 2, CavernNumberToTheRight = 4 },
                        [4] = new CavernDirections { CavernNumberStraightAhead = 14, CavernNumberToTheLeft = 3, CavernNumberToTheRight = 5 },
                        [5] = new CavernDirections { CavernNumberStraightAhead = 6, CavernNumberToTheLeft = 4, CavernNumberToTheRight = 1 },
                        [6] = new CavernDirections { CavernNumberStraightAhead = 5, CavernNumberToTheLeft = 7, CavernNumberToTheRight = 15 },
                        [7] = new CavernDirections { CavernNumberStraightAhead = 17, CavernNumberToTheLeft = 6, CavernNumberToTheRight = 8 },
                        [8] = new CavernDirections { CavernNumberStraightAhead = 1, CavernNumberToTheLeft = 9, CavernNumberToTheRight = 7 },
                        [9] = new CavernDirections { CavernNumberStraightAhead = 18, CavernNumberToTheLeft = 8, CavernNumberToTheRight = 10 },
                        [10] = new CavernDirections { CavernNumberStraightAhead = 2, CavernNumberToTheLeft = 11, CavernNumberToTheRight = 9 },
                        [11] = new CavernDirections { CavernNumberStraightAhead = 19, CavernNumberToTheLeft = 10, CavernNumberToTheRight = 12 },
                        [12] = new CavernDirections { CavernNumberStraightAhead = 3, CavernNumberToTheLeft = 13, CavernNumberToTheRight = 11 },
                        [13] = new CavernDirections { CavernNumberStraightAhead = 20, CavernNumberToTheLeft = 12, CavernNumberToTheRight = 14 },
                        [14] = new CavernDirections { CavernNumberStraightAhead = 4, CavernNumberToTheLeft = 15, CavernNumberToTheRight = 13 },
                        [15] = new CavernDirections { CavernNumberStraightAhead = 16, CavernNumberToTheLeft = 6, CavernNumberToTheRight = 14 },
                        [16] = new CavernDirections { CavernNumberStraightAhead = 15, CavernNumberToTheLeft = 17, CavernNumberToTheRight = 20 },
                        [17] = new CavernDirections { CavernNumberStraightAhead = 7, CavernNumberToTheLeft = 18, CavernNumberToTheRight = 16 },
                        [18] = new CavernDirections { CavernNumberStraightAhead = 9, CavernNumberToTheLeft = 19, CavernNumberToTheRight = 17 },
                        [19] = new CavernDirections { CavernNumberStraightAhead = 11, CavernNumberToTheLeft = 20, CavernNumberToTheRight = 18 },
                        [20] = new CavernDirections { CavernNumberStraightAhead = 13, CavernNumberToTheLeft = 16, CavernNumberToTheRight = 19 },
                    };
                    void CurrentPositionDetails()
                    {

                        foreach (var index in Enumerable.Range(currentPlayerPosition, currentPlayerPosition))
                        {
                            _spriteBatch.DrawString(corridorFont, $"Cave to the left is: {caves[index].CavernNumberToTheLeft }, Cave straight ahead is: {caves[index].CavernNumberStraightAhead}, & Cave to the right is: {caves[index].CavernNumberToTheRight}", new Vector2(20, 2), Color.Black);
                        }
                    }
                    if (Keyboard.GetState().IsKeyDown(Keys.A))
                    {
                        CurrentPositionDetails();
                    }
                    //Draw the UIronsights off the screen to call later
                    _spriteBatch.Draw(ironSight_none, new Rectangle(4000, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                    _spriteBatch.Draw(ironSight_hit, new Rectangle(4000, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                    _spriteBatch.Draw(ironSight_miss, new Rectangle(4000, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                    _spriteBatch.Draw(ironSight_target, new Rectangle(4000, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);



                    break;
                case GameState.BatRoom:
                    break;
                case GameState.WumpusRoom:
                    break;
                case GameState.PitRoom:
                    break;
                case GameState.BreezeRoom:
                    break;
                case GameState.SmellRoom:
                    break;
                case GameState.FlappingRoom:
                    break;
                default:
                    break;

            }
            _spriteBatch.End();

            //Use for Screen Resolution
            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            //Vector.Zero is default pos in top left corner, Color White render as is-no color change, SpriteEffects flips images
            _spriteBatch.Draw(renderTarget, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
            _spriteBatch.End();

            base.Draw(gameTime);

            #region DRAW Archive Code
            ////Draw Red Square
            //_spriteBatch.Begin();
            //_spriteBatch.Draw(texture, position, Color.Red);
            //_spriteBatch.End();  
            #endregion
        }
    }
}









