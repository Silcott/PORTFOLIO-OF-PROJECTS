using HuntTheWumpus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading;

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
        Texture2D newImage;

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

        //Bats
        Texture2D bat1;
        Texture2D bat2;
        Texture2D bat3;
        Texture2D bat4;
        Texture2D bat5;
        Texture2D bat6;
        Texture2D bat7;
        Texture2D bat8;
        Texture2D bat9;
        Texture2D bat10;
        Texture2D bat11;
        Texture2D bat12;
        Texture2D bat13;
        Texture2D bat14;
        Texture2D bat15;
        Texture2D bat16;
        Texture2D bat17;
        Texture2D bat18;
        Texture2D bat19;
        Texture2D bat20;
        Texture2D bat21;
        Texture2D bat22;
        Texture2D bat23;
        Texture2D bat24;
        Texture2D bat25;
        Texture2D bat26;
        Texture2D bat27;
        Texture2D bat28;
        Texture2D bat29;
        Texture2D bat30;

        //Pit
        Texture2D pit1;
        Texture2D pit2;
        Texture2D pit3;
        Texture2D pit4;
        Texture2D pit5;
        Texture2D pit6;
        Texture2D pit7;
        Texture2D pit8;


        //Arrows
        //Texture2D fireBtn1;
        //Texture2D fireBtn2;
        //Texture2D fireBtn3;

        //Random Cave Generator
        int batCave1;
        int batCave2;
        int batCave3;
        int batCave4;
        int batCave5;
        int batCave6;
        int batCave7;
        int batCave8;
        int batCave9;
        int batCave10;
        int pitCave1;
        int pitCave2;
        int pitCave3;
        int pitCave4;
        int pitCave5;
        int pitCave6;
        int pitCave7;
        int pitCave8;
        int pitCave9;
        int pitCave10;
        int wumpusCave;
        int bulletCave; //find an extra bullet the ground


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
        bool m4TargetShowCondition;
        bool hitWumpus;
        bool missWumpus;
        bool singleShotCondition;
        bool resetIronSightCondition;
        bool playBats = true;
        bool playFalling = true;
        bool PitRoomConditionIsOver = true;

        //Timer
        int counterTimer = 1;
        int limit = 1;
        float countDuration = 0.01f; //every  2s.
        float currentTime = 0f;

        public float sprite1PositionValue;
        public float sprite2PositionValue;
        public float sprite3PositionValue;
        public float sprite4PositionValue;
        public float sprite5PositionValue;
        public float sprite6PositionValue;
        public float sprite7PositionValue;
        public float sprite8PositionValue;
        public float sprite9PositionValue;
        public float sprite10PositionValue;
        public float sprite11PositionValue;
        public float sprite12PositionValue;
        public float sprite13PositionValue;
        public float sprite14PositionValue;
        public float sprite15PositionValue;
        public float sprite16PositionValue;
        public float sprite17PositionValue;
        public float sprite18PositionValue;
        public float sprite19PositionValue;
        public float sprite20PositionValue;
        public float sprite21PositionValue;
        public float sprite22PositionValue;
        public float sprite23PositionValue;
        public float sprite24PositionValue;
        public float sprite25PositionValue;
        public float sprite26PositionValue;
        public float sprite27PositionValue;
        public float sprite28PositionValue;
        public float sprite29PositionValue;
        public float sprite30PositionValue;


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
            BulletRoom,
            RandomRoom
        }
        GameState CurrentGameState = GameState.IntroMenu;

        enum ArtStates
        {
            art1,
            art2,
            art3,
            art4,
            art5,
            art6,
            art7,
            art8,
            art9,
            art10,
            art11,
            art12,
            art13,
            art14,
            art15,
            art16,
            art17,
            art18,
            art19,
            art20,
            art21,
            art22,
            art23,
            art24,
            art25,
            art26,
            art27,
            art28,
            art29,
            art30
        }

        ArtStates _artState = ArtStates.art1;


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
            ////RED SQUARE - set position and size
            //position = new Vector2(0, 0);
            //texture = new Texture2D(this.GraphicsDevice, 100, 100);
            //Color[] colorData = new Color[100 * 100];
            //for (int i = 0; i < 10000; i++)
            //{
            //    colorData[i] = Color.Red;
            //    texture.SetData<Color>(colorData);
            //}
            #endregion
        }

        //==============================================<LOAD>==============================================\\
        //Load Content is loaded as soon as boot up of game
        protected override void LoadContent()
        {
            currentPlayerPosition = 1;



            //Method to reuse the random number
            void BatCaveNumbers()
            {
                Random rand = new Random();
                List<int> caveNumbers = new List<int>();
                int number;
                for (int i = 0; i < 10; i++)
                {
                    do
                    {
                        number = rand.Next(2, 20);
                    } while (caveNumbers.Contains(number));
                    caveNumbers.Add(number);
                }
                batCave1 = caveNumbers[0];
                batCave2 = caveNumbers[1];
                batCave3 = caveNumbers[2];
                batCave4 = caveNumbers[3];
                batCave5 = caveNumbers[4];
                batCave6 = caveNumbers[5];
                batCave7 = caveNumbers[6];
                batCave8 = caveNumbers[7];
                batCave9 = caveNumbers[8];
                batCave10 = caveNumbers[9];
            }
            BatCaveNumbers();

            void PitCaveNumbers()
            {
                Random rand = new Random();
                List<int> caveNumbers = new List<int>();
                int number;
                for (int i = 0; i < 12; i++)
                {
                    do
                    {
                        number = rand.Next(2, 20);
                    } while (caveNumbers.Contains(number));
                    caveNumbers.Add(number);
                }
                pitCave1 = caveNumbers[0];
                pitCave2 = caveNumbers[1];
                pitCave3 = caveNumbers[2];
                pitCave4 = caveNumbers[3];
                pitCave5 = caveNumbers[4];
                pitCave6 = caveNumbers[5];
                pitCave7 = caveNumbers[6];
                pitCave8 = caveNumbers[7];
                pitCave9 = caveNumbers[8];
                pitCave10 = caveNumbers[9];
                wumpusCave = caveNumbers[10];//Wumpus Location
                bulletCave = caveNumbers[11];//Bullet Location

            }
            PitCaveNumbers();


            

            //static int[] caveBatLocations() 
            //{
            //    Random rand = new Random();
            //    List<int> caveNumbers = new List<int>();
            //    int number;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        do
            //        {
            //            number = rand.Next(2, 20);
            //        } while (caveNumbers.Contains(number));
            //        caveNumbers.Add(number);
            //    }
            //    var batCave1 = caveNumbers[0];
            //    var batCave2 = caveNumbers[1];
            //    var batCave3 = caveNumbers[2];
            //    var batCave4 = caveNumbers[3];
            //    var batCave5 = caveNumbers[4];
            //    var batCave6 = caveNumbers[5];
            //    var batCave7 = caveNumbers[6];
            //    var batCave8 = caveNumbers[7];
            //    var batCave9 = caveNumbers[8];
            //    var batCave10 = caveNumbers[9];

            //    //Create List to detect bats
            //    List<int> BatList = new List<int>();
            //    BatList.Add(batCave1);
            //    BatList.Add(batCave2);
            //    BatList.Add(batCave3);
            //    BatList.Add(batCave4);
            //    BatList.Add(batCave5);
            //    BatList.Add(batCave6);
            //    BatList.Add(batCave7);
            //    BatList.Add(batCave8);
            //    BatList.Add(batCave9);
            //    BatList.Add(batCave10);

            //    foreach (int item in BatList)
            //    {
            //        int[] batArray = new int[item];
            //    }
            //    Array.Sort(batArray)
            //    return BatList;

            //}

            //Arrows Players Starts with
            bulletsRemaining = 1;

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


            //Load PLAYING GAMESTATE - Images/Sprites
            upBtn1 = Content.Load<Texture2D>("Images/Direction/Up/up2");//Entrance Only
            upBtn2 = Content.Load<Texture2D>("Images/Direction/Up/up1");//Entrance Only
            upBtn3 = Content.Load<Texture2D>("Images/Direction/Up/up2");
            upBtn4 = Content.Load<Texture2D>("Images/Direction/Up/up1");

            newImage = Content.Load<Texture2D>("Images/_7k1xF");
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

            //Bats
            ironSight_target = Content.Load<Texture2D>("Images/FireBtn/ironSight_target");
            bat1 = Content.Load<Texture2D>("Images/Bats/bat (1)");
            bat2 = Content.Load<Texture2D>("Images/Bats/bat (2)");
            bat3 = Content.Load<Texture2D>("Images/Bats/bat (3)");
            bat4 = Content.Load<Texture2D>("Images/Bats/bat (4)");
            bat5 = Content.Load<Texture2D>("Images/Bats/bat (5)");
            bat6 = Content.Load<Texture2D>("Images/Bats/bat (6)");
            bat7 = Content.Load<Texture2D>("Images/Bats/bat (7)");
            bat8 = Content.Load<Texture2D>("Images/Bats/bat (8)");
            bat9 = Content.Load<Texture2D>("Images/Bats/bat (9)");
            bat10 = Content.Load<Texture2D>("Images/Bats/bat (10)");
            bat11 = Content.Load<Texture2D>("Images/Bats/bat (11)");
            bat12 = Content.Load<Texture2D>("Images/Bats/bat (12)");
            bat13 = Content.Load<Texture2D>("Images/Bats/bat (13)");
            bat14 = Content.Load<Texture2D>("Images/Bats/bat (14)");
            bat15 = Content.Load<Texture2D>("Images/Bats/bat (15)");
            bat16 = Content.Load<Texture2D>("Images/Bats/bat (16)");
            bat17 = Content.Load<Texture2D>("Images/Bats/bat (17)");
            bat18 = Content.Load<Texture2D>("Images/Bats/bat (18)");
            bat19 = Content.Load<Texture2D>("Images/Bats/bat (19)");
            bat20 = Content.Load<Texture2D>("Images/Bats/bat (20)");
            bat21 = Content.Load<Texture2D>("Images/Bats/bat (21)");
            bat22 = Content.Load<Texture2D>("Images/Bats/bat (22)");
            bat23 = Content.Load<Texture2D>("Images/Bats/bat (23)");
            bat24 = Content.Load<Texture2D>("Images/Bats/bat (24)");
            bat25 = Content.Load<Texture2D>("Images/Bats/bat (25)");
            bat26 = Content.Load<Texture2D>("Images/Bats/bat (26)");
            bat27 = Content.Load<Texture2D>("Images/Bats/bat (27)");
            bat28 = Content.Load<Texture2D>("Images/Bats/bat (28)");
            bat29 = Content.Load<Texture2D>("Images/Bats/bat (29)");
            bat30 = Content.Load<Texture2D>("Images/Bats/bat (30)");

            //Pit
            pit1 = Content.Load<Texture2D>("Images/Pit/pit (1)");
            pit2 = Content.Load<Texture2D>("Images/Pit/pit (2)");
            pit3 = Content.Load<Texture2D>("Images/Pit/pit (3)");
            pit4 = Content.Load<Texture2D>("Images/Pit/pit (4)");
            pit5 = Content.Load<Texture2D>("Images/Pit/pit (5)");
            pit6 = Content.Load<Texture2D>("Images/Pit/pit (6)");
            pit7 = Content.Load<Texture2D>("Images/Pit/pit (7)");
            pit8 = Content.Load<Texture2D>("Images/Pit/pit (8)");



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
            m4TargetShowCondition = true;
            hitWumpus = false;
            missWumpus = true;
            singleShotCondition = true;
            resetIronSightCondition = true;

            //Get mouse state for hover picture changes
            var mouseState = Mouse.GetState();
            //Get the mouse position in screen coordinates relative to the top left corner
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            resolutionSwitch = true;

            sprite1PositionValue = 4000.0f;
            sprite2PositionValue = 4000.0f;
            sprite3PositionValue = 4000.0f;
            sprite4PositionValue = 4000.0f;
            sprite5PositionValue = 4000.0f;
            sprite6PositionValue = 4000.0f;
            sprite7PositionValue = 4000.0f;
            sprite8PositionValue = 4000.0f;
            sprite9PositionValue = 4000.0f;
            sprite10PositionValue = 4000.0f;
            sprite11PositionValue = 4000.0f;
            sprite12PositionValue = 4000.0f;
            sprite13PositionValue = 4000.0f;
            sprite14PositionValue = 4000.0f;
            sprite15PositionValue = 4000.0f;
            sprite16PositionValue = 4000.0f;
            sprite17PositionValue = 4000.0f;
            sprite18PositionValue = 4000.0f;
            sprite19PositionValue = 4000.0f;
            sprite20PositionValue = 4000.0f;
            sprite21PositionValue = 4000.0f;
            sprite22PositionValue = 4000.0f;
            sprite23PositionValue = 4000.0f;
            sprite24PositionValue = 4000.0f;
            sprite25PositionValue = 4000.0f;
            sprite26PositionValue = 4000.0f;
            sprite27PositionValue = 4000.0f;
            sprite28PositionValue = 4000.0f;
            sprite29PositionValue = 4000.0f;
            sprite30PositionValue = 4000.0f;

        }

        private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
        {
            MediaPlayer.Volume -= 0.5f;
            MediaPlayer.Play(introSong);
        }


        //==============================================<UNLOAD>==============================================\\
        //Not a defualt, this cleans the memory
        //protected override void UnloadContent()
        //{
        //    //Clean up the memory from the texture of the red square
        //    texture.Dispose();
        //    base.UnloadContent();
        //}

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
                Debug.WriteLine(state.X.ToString() + "," + state.Y.ToString());

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

                        PitRoomConditionIsOver = false;
                        //==============================================<INTRO GAMESTATE>==============================================\\
                        if (introOverCondtion == true)
                        {
                            playFalling = true;
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
                        break;
                    case GameState.HelpScreen:
                        GraphicsDevice.Clear(Color.CornflowerBlue);
                        if (mouseState.LeftButton == ButtonState.Pressed)
                        {
                            CurrentGameState = GameState.IntroMenu;
                        }
                        break;
                    case GameState.Entrance:
                        PitRoomConditionIsOver = false;
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
                            //MediaPlayer.Volume -= 0.1f;
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
                        PitRoomConditionIsOver = true;

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
                                fireCondition = false;
                            }

                        }

                        if (!m4BtnArea.Contains(mousePosition))
                        {
                            fireCondition = true;
                        }

                        if (fireCondition == false)
                        {
                            if ((m4BtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed))
                            {
                                if (singleShotCondition == true)
                                {
                                    fireM4.Play();
                                    bulletsRemaining = bulletsRemaining - 1;
                                    if (currentPlayerPosition == wumpusCave)
                                    {
                                        hitWumpus = true;
                                    }
                                    else
                                    {
                                        missWumpus = false;
                                    }
                                    singleShotCondition = false;

                                }
                            }
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


                        void PickedDirection()
                        {
                            if (leftBtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed)
                            {
                                currentPlayerPosition = caves[currentPlayerPosition].CavernNumberToTheLeft;
                                fireCondition = true;
                                singleShotCondition = true;
                                resetIronSightCondition = true;

                            }

                            if (rightBtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed)
                            {
                                currentPlayerPosition = caves[currentPlayerPosition].CavernNumberToTheRight;
                                fireCondition = true;
                                singleShotCondition = true;
                                resetIronSightCondition = true;

                            }
                            if (upBtnArea.Contains(mousePosition) && mouseState.LeftButton == ButtonState.Pressed)
                            {
                                currentPlayerPosition = caves[currentPlayerPosition].CavernNumberStraightAhead;
                                fireCondition = true;
                                singleShotCondition = true;
                                resetIronSightCondition = true;

                            }
                            if (
                                currentPlayerPosition == batCave1 ||
                                currentPlayerPosition == batCave2 ||
                                currentPlayerPosition == batCave3 ||
                                currentPlayerPosition == batCave4 ||
                                currentPlayerPosition == batCave5 ||
                                currentPlayerPosition == batCave6 ||
                                currentPlayerPosition == batCave7 ||
                                currentPlayerPosition == batCave8 ||
                                currentPlayerPosition == batCave9 ||
                                currentPlayerPosition == batCave10
                                )
                            {
                                //BATS ATTACK
                                CurrentGameState = GameState.BatRoom;

                            }
                            else if (
                                currentPlayerPosition == pitCave1 ||
                                currentPlayerPosition == pitCave2 ||
                                currentPlayerPosition == pitCave3 ||
                                currentPlayerPosition == pitCave4 ||
                                currentPlayerPosition == pitCave5 ||
                                currentPlayerPosition == pitCave6 ||
                                currentPlayerPosition == pitCave7 ||
                                currentPlayerPosition == pitCave8 ||
                                currentPlayerPosition == pitCave9 ||
                                currentPlayerPosition == pitCave10
                                )
                            {
                                //Fall in pit
                            PitRoomConditionIsOver = true;
                                CurrentGameState = GameState.PitRoom;

                            }
                            else if (currentPlayerPosition == wumpusCave)
                            {
                                //Wumpus Attacks
                                CurrentGameState = GameState.WumpusRoom;

                            }
                            else if (currentPlayerPosition == bulletCave)
                            {
                                //Add Ammo
                                CurrentGameState = GameState.CaveCorridor;

                            }
                            else
                            {
                                //reload gamestate corridor
                                CurrentGameState = GameState.CaveCorridor;

                            }
                        }
                        PickedDirection();
                        //Cavern Directions


                        break;
                    case GameState.BatRoom:
                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds; //Time passed since last Update() 

                        switch (_artState)
                        {
                            case ArtStates.art1:
                                this.TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 66);//set isfixedtime to true for this - 33 is the framerate you want
                                sprite30PositionValue = 4000;
                                sprite1PositionValue = 0;
                                _artState = ArtStates.art2;
                                break;
                            case ArtStates.art2:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite1PositionValue = 4000;
                                    sprite2PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art3;

                                }

                                break;
                            case ArtStates.art3:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite2PositionValue = 4000;
                                    sprite3PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art4;

                                }
                                break;
                            case ArtStates.art4:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite3PositionValue = 4000;
                                    sprite4PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art5;

                                }
                                break;
                            case ArtStates.art5:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite4PositionValue = 4000;
                                    sprite5PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art6;

                                }
                                break;
                            case ArtStates.art6:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite5PositionValue = 4000;
                                    sprite6PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art7;

                                }
                                break;
                            case ArtStates.art7:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite6PositionValue = 4000;
                                    sprite7PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art8;

                                }
                                break;
                            case ArtStates.art8:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite7PositionValue = 4000;
                                    sprite8PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art9;

                                }
                                break;
                            case ArtStates.art9:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite8PositionValue = 4000;
                                    sprite9PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art10;

                                }
                                break;
                            case ArtStates.art10:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite9PositionValue = 4000;
                                    sprite10PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art11;
                                }
                                break;
                            case ArtStates.art11:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite10PositionValue = 4000;
                                    sprite11PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art12;
                                }
                                break;
                            case ArtStates.art12:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite11PositionValue = 4000;
                                    sprite12PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art13;
                                }
                                break;
                            case ArtStates.art13:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite12PositionValue = 4000;
                                    sprite13PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art14;
                                }
                                break;
                            case ArtStates.art14:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite13PositionValue = 4000;
                                    sprite14PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art15;
                                }
                                break;
                            case ArtStates.art15:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite14PositionValue = 4000;
                                    sprite15PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art16;
                                }
                                break;
                            case ArtStates.art16:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite15PositionValue = 4000;
                                    sprite16PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art17;
                                }
                                break;
                            case ArtStates.art17:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite16PositionValue = 4000;
                                    sprite17PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art18;
                                }
                                break;
                            case ArtStates.art18:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite17PositionValue = 4000;
                                    sprite18PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art19;
                                }
                                break;
                            case ArtStates.art19:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite18PositionValue = 4000;
                                    sprite19PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art20;
                                }
                                break;
                            case ArtStates.art20:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite19PositionValue = 4000;
                                    sprite20PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art21;
                                }
                                break;
                            case ArtStates.art21:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite20PositionValue = 4000;
                                    sprite21PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art22;
                                }
                                break;
                            case ArtStates.art22:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite21PositionValue = 4000;
                                    sprite22PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art23;
                                }
                                break;
                            case ArtStates.art23:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite22PositionValue = 4000;
                                    sprite23PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art24;
                                }
                                break;
                            case ArtStates.art24:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite23PositionValue = 4000;
                                    sprite24PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art25;
                                }
                                break;
                            case ArtStates.art25:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite24PositionValue = 4000;
                                    sprite25PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art26;
                                }
                                break;
                            case ArtStates.art26:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite25PositionValue = 4000;
                                    sprite26PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art27;
                                }
                                break;
                            case ArtStates.art27:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite26PositionValue = 4000;
                                    sprite27PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art28;
                                }
                                break;
                            case ArtStates.art28:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite27PositionValue = 4000;
                                    sprite28PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art29;
                                }
                                break;
                            case ArtStates.art29:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite28PositionValue = 4000;
                                    sprite29PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    _artState = ArtStates.art30;
                                }
                                break;
                            case ArtStates.art30:
                                if (currentTime >= countDuration)
                                {
                                    counterTimer++;
                                    currentTime -= countDuration;

                                    sprite29PositionValue = 4000;
                                    sprite30PositionValue = 0;
                                }
                                if (counterTimer >= limit)
                                {
                                    counterTimer = 0;
                                    CurrentGameState = GameState.RandomRoom;
                                    _artState = ArtStates.art1;
                                }
                                this.TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 33);//set isfixedtime to true for this - 33 is the framerate you want
                                break;

                        }

                        break;
                    case GameState.WumpusRoom:
                        Random randNumber = new Random();
                        int wumpusMovedTONewLocation = randNumber.Next(1, 20);
                        currentPlayerPosition = wumpusMovedTONewLocation;
                        if (
                                currentPlayerPosition == batCave1 ||
                                currentPlayerPosition == batCave2 ||
                                currentPlayerPosition == batCave3 ||
                                currentPlayerPosition == batCave4 ||
                                currentPlayerPosition == batCave5 ||
                                currentPlayerPosition == batCave6 ||
                                currentPlayerPosition == batCave7 ||
                                currentPlayerPosition == batCave8 ||
                                currentPlayerPosition == batCave9 ||
                                currentPlayerPosition == batCave10
                                )
                        {
                            //BATS ATTACK
                            CurrentGameState = GameState.BatRoom;

                        }
                        else if (
                            currentPlayerPosition == pitCave1 ||
                            currentPlayerPosition == pitCave2 ||
                            currentPlayerPosition == pitCave3 ||
                            currentPlayerPosition == pitCave4 ||
                            currentPlayerPosition == pitCave5 ||
                            currentPlayerPosition == pitCave6 ||
                            currentPlayerPosition == pitCave7 ||
                            currentPlayerPosition == pitCave8 ||
                            currentPlayerPosition == pitCave9 ||
                            currentPlayerPosition == pitCave10
                            )
                        {
                            //Fall in pit
                            PitRoomConditionIsOver = true;
                            CurrentGameState = GameState.PitRoom;


                        }
                        else if (currentPlayerPosition == wumpusCave)
                        {
                            //Wumpus Attacks
                            CurrentGameState = GameState.WumpusRoom;

                        }
                        else if (currentPlayerPosition == bulletCave)
                        {
                            //Add Ammo
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        else
                        {
                            //reload gamestate corridor
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        break;
                    case GameState.PitRoom:
                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds; //Time passed since last Update() 
                        if (PitRoomConditionIsOver == true)
                        {
                            if (playFalling == true)
                            {
                                falling.Play();
                                playFalling = false;
                                MediaPlayer.Stop();
                                playingSongSwitch = true;

                            }
                            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                            {
                                introOverCondtion = true;
                                PitRoomConditionIsOver = false;
                                currentPlayerPosition = 1;
                                CurrentGameState = GameState.IntroMenu;
                                

                            }
                            switch (_artState)
                            {
                                case ArtStates.art1:

                                    this.TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 66);//set isfixedtime to true for this - 33 is the framerate you want
                                    sprite8PositionValue = 4000;
                                    sprite1PositionValue = 0;
                                    _artState = ArtStates.art2;
                                    break;
                                case ArtStates.art2:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite1PositionValue = 4000;
                                        sprite2PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art3;

                                    }

                                    break;
                                case ArtStates.art3:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite2PositionValue = 4000;
                                        sprite3PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art4;

                                    }
                                    break;
                                case ArtStates.art4:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite3PositionValue = 4000;
                                        sprite4PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art5;

                                    }
                                    break;
                                case ArtStates.art5:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite4PositionValue = 4000;
                                        sprite5PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art6;

                                    }
                                    break;
                                case ArtStates.art6:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite5PositionValue = 4000;
                                        sprite6PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art7;

                                    }
                                    break;
                                case ArtStates.art7:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite6PositionValue = 4000;
                                        sprite7PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        _artState = ArtStates.art8;

                                    }
                                    break;
                                case ArtStates.art8:
                                    if (currentTime >= countDuration)
                                    {
                                        counterTimer++;
                                        currentTime -= countDuration;

                                        sprite7PositionValue = 4000;
                                        sprite8PositionValue = 0;
                                    }
                                    if (counterTimer >= limit)
                                    {
                                        counterTimer = 0;
                                        if (true)
                                        {
                                            _artState = ArtStates.art1;

                                        }

                                    }
                                    break;
                            }
                        }
                        break;
                    case GameState.BreezeRoom:
                        break;
                    case GameState.SmellRoom:
                        break;
                    case GameState.FlappingRoom:
                        break;
                    case GameState.BulletRoom:
                        Random rNumber = new Random();
                        int bulletMovedToNewLocation = rNumber.Next(1, 20);
                        currentPlayerPosition = bulletMovedToNewLocation;
                        if (
                                currentPlayerPosition == batCave1 ||
                                currentPlayerPosition == batCave2 ||
                                currentPlayerPosition == batCave3 ||
                                currentPlayerPosition == batCave4 ||
                                currentPlayerPosition == batCave5 ||
                                currentPlayerPosition == batCave6 ||
                                currentPlayerPosition == batCave7 ||
                                currentPlayerPosition == batCave8 ||
                                currentPlayerPosition == batCave9 ||
                                currentPlayerPosition == batCave10
                                )
                        {
                            //BATS ATTACK
                            CurrentGameState = GameState.BatRoom;

                        }
                        else if (
                            currentPlayerPosition == pitCave1 ||
                            currentPlayerPosition == pitCave2 ||
                            currentPlayerPosition == pitCave3 ||
                            currentPlayerPosition == pitCave4 ||
                            currentPlayerPosition == pitCave5 ||
                            currentPlayerPosition == pitCave6 ||
                            currentPlayerPosition == pitCave7 ||
                            currentPlayerPosition == pitCave8 ||
                            currentPlayerPosition == pitCave9 ||
                            currentPlayerPosition == pitCave10
                            )
                        {
                            //Fall in pit
                            CurrentGameState = GameState.PitRoom;

                        }
                        else if (currentPlayerPosition == wumpusCave)
                        {
                            //Wumpus Attacks
                            CurrentGameState = GameState.WumpusRoom;

                        }
                        else if (currentPlayerPosition == bulletCave)
                        {
                            //Add Ammo
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        else
                        {
                            //reload gamestate corridor
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        break;
                    case GameState.RandomRoom:
                        Random rrNumber = new Random();
                        int randomMovedToNewLocation = rrNumber.Next(1, 20);
                        currentPlayerPosition = randomMovedToNewLocation;
                        if (
                                currentPlayerPosition == batCave1 ||
                                currentPlayerPosition == batCave2 ||
                                currentPlayerPosition == batCave3 ||
                                currentPlayerPosition == batCave4 ||
                                currentPlayerPosition == batCave5 ||
                                currentPlayerPosition == batCave6 ||
                                currentPlayerPosition == batCave7 ||
                                currentPlayerPosition == batCave8 ||
                                currentPlayerPosition == batCave9 ||
                                currentPlayerPosition == batCave10
                                )
                        {
                            //BATS ATTACK
                            CurrentGameState = GameState.BatRoom;

                        }
                        else if (
                            currentPlayerPosition == pitCave1 ||
                            currentPlayerPosition == pitCave2 ||
                            currentPlayerPosition == pitCave3 ||
                            currentPlayerPosition == pitCave4 ||
                            currentPlayerPosition == pitCave5 ||
                            currentPlayerPosition == pitCave6 ||
                            currentPlayerPosition == pitCave7 ||
                            currentPlayerPosition == pitCave8 ||
                            currentPlayerPosition == pitCave9 ||
                            currentPlayerPosition == pitCave10
                            )
                        {
                            //Fall in pit
                            CurrentGameState = GameState.PitRoom;

                        }
                        else if (currentPlayerPosition == wumpusCave)
                        {
                            //Wumpus Attacks
                            CurrentGameState = GameState.WumpusRoom;

                        }
                        else if (currentPlayerPosition == bulletCave)
                        {
                            //Add Ammo
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        else
                        {
                            //reload gamestate corridor
                            CurrentGameState = GameState.CaveCorridor;

                        }
                        break;


                    default:
                        break;
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
            switch (CurrentGameState)
            {

                case GameState.IntroMenu:
                    _spriteBatch.Begin();

                    //batch - grouping of Draw calls, sprite - creates a camera effect for 2d images
                    _spriteBatch.Draw(introBackground, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
                    //_spriteBatch.Draw(newImage, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0f);

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
                    _spriteBatch.End();

                    break;
                case GameState.HelpScreen:
                    _spriteBatch.Begin();

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
                    _spriteBatch.End();

                    break;
                case GameState.Entrance:
                    _spriteBatch.Begin();

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
                    _spriteBatch.End();

                    break;

                case GameState.CaveCorridor:
                    _spriteBatch.Begin();

                    GraphicsDevice.Clear(Color.White);
                    _spriteBatch.Draw(corridor1, new Rectangle(50, 50, (Convert.ToInt32(screenSizeX) / 2), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                    void DrawDirectionalArrows()
                    {
                        _spriteBatch.Draw(upBtn3, new Rectangle(Convert.ToInt32(screenSizeX) - 575, Convert.ToInt32(screenSizeY) - 525, 150, 250), Color.White);
                        _spriteBatch.Draw(leftBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 850, Convert.ToInt32(screenSizeY) - 325, 300, 150), Color.White);
                        _spriteBatch.Draw(rightBtn1, new Rectangle(Convert.ToInt32(screenSizeX) - 425, Convert.ToInt32(screenSizeY) - 325, 300, 150), Color.White);
                        //Arrow
                        //_spriteBatch.Draw(fireBtn2, new Rectangle(Convert.ToInt32(screenSizeX) - 625, Convert.ToInt32(screenSizeY) - 625, 300, 300), Color.White);
                        _spriteBatch.Draw(buttonRifle_norm, new Rectangle(Convert.ToInt32(screenSizeX) - 680, Convert.ToInt32(screenSizeY) - 225, 400, 200), Color.White);
                    }
                    DrawDirectionalArrows();
                    _spriteBatch.DrawString(corridorFont, @"
   You have reached corridor
   Number: " + $"{currentPlayerPosition}" + @", 
   



   Choose a path: 
   Left, Right, or Straight Ahead
   Or shoot your M4 Rifle - Bullets Remaining: " + $"{bulletsRemaining}", new Vector2(1, screenSizeY - 550), Color.Black);
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


                    int[] batArray = { batCave1, batCave2, batCave3, batCave4, batCave5, batCave6, batCave7, batCave8, batCave9, batCave10 };

                    bool containsNumberStraightAhead = batArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead);
                    bool containsNumberLeft = batArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft);
                    bool containsNumberRight = batArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight);


                    if (containsNumberStraightAhead || containsNumberLeft || containsNumberRight)
                    {
                        _spriteBatch.DrawString(corridorFont, @"



    I can hear bats!", new Vector2(1, screenSizeY - 550), Color.Black);
                    }

                    int[] pitArray = { pitCave1, pitCave2, pitCave3, pitCave4, pitCave5, pitCave6, pitCave7, pitCave8, pitCave9, pitCave10 };

                    bool pitcontainsNumberStraightAhead = pitArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead);
                    bool pitcontainsNumberLeft = pitArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft);
                    bool pitcontainsNumberRight = pitArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight);

                    if (pitcontainsNumberStraightAhead || pitcontainsNumberLeft || pitcontainsNumberRight)
                    {
                        _spriteBatch.DrawString(corridorFont, @"




    I feel a breeze!", new Vector2(1, screenSizeY - 550), Color.Black);
                    }

                    int[] wumpusArray = { wumpusCave};

                    bool wumpuscontainsNumberStraightAhead = wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead);
                    bool wumpuscontainsNumberLeft = wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft);
                    bool wumpuscontainsNumberRight = wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight);

                    if (wumpuscontainsNumberStraightAhead || wumpuscontainsNumberLeft || wumpuscontainsNumberRight)
                    {
                        _spriteBatch.DrawString(corridorFont, $"I smell a beast! ", new Vector2(screenSizeX - 900, 110), Color.Black);
                        _spriteBatch.DrawString(corridorFont, @"





    I smell a beast!", new Vector2(1, screenSizeY - 550), Color.Black);

                    }
                    if (!containsNumberStraightAhead && !containsNumberLeft && !containsNumberRight)
                    {
                        _spriteBatch.DrawString(corridorFont, @"


    You detect nothing...", new Vector2(1, screenSizeY - 550), Color.Black);
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    {
                        if (containsNumberStraightAhead)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Bats Straight Ahead: {batArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead)}", new Vector2(screenSizeX - 900, 150), Color.Black);
                        }
                        if (containsNumberLeft)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Bats To The Left: {batArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft)}", new Vector2(screenSizeX - 900, 190), Color.Black);
                        }
                        if (containsNumberRight)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Bats To The Right: {batArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight)}", new Vector2(screenSizeX - 900, 230), Color.Black);
                        }

                        if (pitcontainsNumberStraightAhead)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Pits Straight Ahead: {pitArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead)}", new Vector2(screenSizeX - 900, 270), Color.Black);
                        }
                        if (pitcontainsNumberLeft)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Pits To The Left: {pitArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft)}", new Vector2(screenSizeX - 900, 310), Color.Black);
                        }
                        if (pitcontainsNumberRight)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Pits To The Right: {pitArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight)}", new Vector2(screenSizeX - 900, 350), Color.Black);
                        }
                        if (wumpuscontainsNumberStraightAhead)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Wumpus Straight Ahead: {wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberStraightAhead)}", new Vector2(screenSizeX - 900, 390), Color.Black);
                        }
                        if (wumpuscontainsNumberLeft)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Wumpus To The Left: {wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberToTheLeft)}", new Vector2(screenSizeX - 900, 430), Color.Black);
                        }
                        if (wumpuscontainsNumberRight)
                        {
                            _spriteBatch.DrawString(corridorFont, $" Wumpus To The Right: {wumpusArray.Contains(caves[currentPlayerPosition].CavernNumberToTheRight)}", new Vector2(screenSizeX - 900, 470), Color.Black);
                        }
                    }








                    void CurrentPositionDetails()
                    {
                        GraphicsDevice.Clear(Color.White);

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


                    if (fireCondition == false)
                    {
                        _spriteBatch.Draw(ironSight_none, new Rectangle((Convert.ToInt32(screenSizeX) / 7), 50, (Convert.ToInt32(screenSizeX) / 4), (Convert.ToInt32(screenSizeY) / 2)), Color.White);

                    }
                    else if (hitWumpus == true)
                    {
                        _spriteBatch.Draw(ironSight_hit, new Rectangle((Convert.ToInt32(screenSizeX) / 7), 50, (Convert.ToInt32(screenSizeX) / 4), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                        fireCondition = true;
                    }
                    else if (missWumpus == false)
                    {

                        _spriteBatch.Draw(ironSight_miss, new Rectangle((Convert.ToInt32(screenSizeX) / 7), 50, (Convert.ToInt32(screenSizeX) / 4), (Convert.ToInt32(screenSizeY) / 2)), Color.White);
                        fireCondition = true;

                    }





                    _spriteBatch.End();

                    break;
                case GameState.BatRoom:
                    _spriteBatch.Begin();

                    GraphicsDevice.Clear(Color.White);

                    _spriteBatch.Draw(bat1, new Rectangle(Convert.ToInt32(sprite1PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat2, new Rectangle(Convert.ToInt32(sprite2PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat3, new Rectangle(Convert.ToInt32(sprite3PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat4, new Rectangle(Convert.ToInt32(sprite4PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat5, new Rectangle(Convert.ToInt32(sprite5PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat6, new Rectangle(Convert.ToInt32(sprite6PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat7, new Rectangle(Convert.ToInt32(sprite7PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat8, new Rectangle(Convert.ToInt32(sprite8PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat9, new Rectangle(Convert.ToInt32(sprite9PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat10, new Rectangle(Convert.ToInt32(sprite10PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat11, new Rectangle(Convert.ToInt32(sprite11PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat12, new Rectangle(Convert.ToInt32(sprite12PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat13, new Rectangle(Convert.ToInt32(sprite13PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat14, new Rectangle(Convert.ToInt32(sprite14PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat15, new Rectangle(Convert.ToInt32(sprite15PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat16, new Rectangle(Convert.ToInt32(sprite16PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat17, new Rectangle(Convert.ToInt32(sprite17PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat18, new Rectangle(Convert.ToInt32(sprite18PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat19, new Rectangle(Convert.ToInt32(sprite19PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat20, new Rectangle(Convert.ToInt32(sprite20PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat21, new Rectangle(Convert.ToInt32(sprite21PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat22, new Rectangle(Convert.ToInt32(sprite22PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat23, new Rectangle(Convert.ToInt32(sprite23PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat24, new Rectangle(Convert.ToInt32(sprite24PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat25, new Rectangle(Convert.ToInt32(sprite25PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat26, new Rectangle(Convert.ToInt32(sprite26PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat27, new Rectangle(Convert.ToInt32(sprite27PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat28, new Rectangle(Convert.ToInt32(sprite28PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat29, new Rectangle(Convert.ToInt32(sprite29PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                    _spriteBatch.Draw(bat30, new Rectangle(Convert.ToInt32(sprite30PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);



                    _spriteBatch.DrawString(corridorFont, "You Entered Room: " + $"{currentPlayerPosition}", new Vector2((screenSizeX / 2) - 275, 10), Color.Black);
                    _spriteBatch.DrawString(corridorFont, @"Super Bats Have Found You!", new Vector2((screenSizeX / 2) - 275, screenSizeY - 100), Color.Black);
                    _spriteBatch.End();

                    break;
                case GameState.WumpusRoom:
                    _spriteBatch.Begin();

                    GraphicsDevice.Clear(Color.White);
                    DrawDirectionalArrows();

                    _spriteBatch.DrawString(corridorFont, @"
                    WUMPUSROOM " + $"{currentPlayerPosition}", new Vector2(1, screenSizeY - 550), Color.Black);
                    _spriteBatch.End();

                    break;
                case GameState.PitRoom:
                    _spriteBatch.Begin();

                    GraphicsDevice.Clear(Color.White);
                    if (PitRoomConditionIsOver == true)
                    {


                        _spriteBatch.Draw(pit1, new Rectangle(Convert.ToInt32(sprite1PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit2, new Rectangle(Convert.ToInt32(sprite2PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit3, new Rectangle(Convert.ToInt32(sprite3PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit4, new Rectangle(Convert.ToInt32(sprite4PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit5, new Rectangle(Convert.ToInt32(sprite5PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit6, new Rectangle(Convert.ToInt32(sprite6PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit7, new Rectangle(Convert.ToInt32(sprite7PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);
                        _spriteBatch.Draw(pit8, new Rectangle(Convert.ToInt32(sprite8PositionValue), 0, (Convert.ToInt32(screenSizeX)), (Convert.ToInt32(screenSizeY) - 50)), Color.White);

                        _spriteBatch.DrawString(corridorFont, "You Entered Room: " + $"{ currentPlayerPosition}", new Vector2((screenSizeX / 2) - 275, 10), Color.Black);
                        _spriteBatch.DrawString(corridorFont, @"The Pit Room!", new Vector2((screenSizeX / 2) - 275, screenSizeY - 175), Color.Black);
                        _spriteBatch.DrawString(corridorFont, @"Press ESC to Exit", new Vector2((screenSizeX / 2) - 275, screenSizeY - 100), Color.Black);
                    }
                    _spriteBatch.End();

                    break;
                case GameState.BreezeRoom:
                    _spriteBatch.Begin();
                    _spriteBatch.End();

                    break;
                case GameState.SmellRoom:
                    _spriteBatch.Begin();
                    _spriteBatch.End();
                    break;
                case GameState.FlappingRoom:
                    _spriteBatch.Begin();
                    _spriteBatch.End();
                    break;
                default:
                    break;

            }

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









