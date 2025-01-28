namespace Project001;

public class Game1 : Game
{
    private readonly GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private GameManager _gameManager;
    private KeyboardState lastKeyState;
    private KeyboardState currentKeyState;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        Globals.Game = this;
        // Globals.Bounds = new(1024, 768);
        Globals.Bounds = new(1600, 900);
        _graphics.PreferredBackBufferWidth = Globals.Bounds.X;
        _graphics.PreferredBackBufferHeight = Globals.Bounds.Y;
        _graphics.ApplyChanges();
        // Window.Title = "GameDev Quickie: Memory Game";
        Window.Title = "Marisas & Bastians Memory Game";

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        Globals.SpriteBatch = _spriteBatch;
        Globals.Content = Content;
        _graphics.ToggleFullScreen();
        _gameManager = new();
    }

    protected override void Update(GameTime gameTime)
    {
        currentKeyState = Keyboard.GetState();
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || (currentKeyState.IsKeyDown(Keys.Escape) && lastKeyState.IsKeyUp(Keys.Escape)))
        {
            if (_gameManager._gameState is MenuState)
            {
                this.Exit();
            }

            _gameManager.ChangeState(GameStates.Menu);
        }

        Globals.Update(gameTime);
        _gameManager.Update();

        lastKeyState = currentKeyState;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.DarkGray);

        _spriteBatch.Begin();
        _gameManager.Draw();
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
