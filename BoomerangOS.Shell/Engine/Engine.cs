using BoomerangOS.Common.Logging;
using BoomerangOS.Common.Time;
using BoomerangOS.Graphics._2D;
using BoomerangOS.Graphics.Math;
using BoomerangOS.Graphics.Rendering;
using BoomerangOS.Shell.Scenes;
using Silk.NET.Windowing;

namespace BoomerangOS.Shell.Engine
{
    public class Engine
    {
        private IWindow _window = null!;

        private GLRenderer _renderer = null!;

        private FPSCounter _fpsCounter = new();

        private GameTime _gameTime = new();

        private SceneManager _sceneManager = new();

        private Graphics2D _graphics2D = null!;


        private int _lastFPS;


        public void Run()
        {
            Logger.Info(" | Hello, Boomerang User ;) | ");


            var options = WindowOptions.Default;

            options.Title = "BoomerangOS";
            options.Size = new Silk.NET.Maths.Vector2D<int>(1280, 720);


            _window = Window.Create(options);


            _window.Load += OnLoad;
            _window.Render += OnRender;
            _window.Closing += OnClosing;


            _window.Run();


            _renderer.Shutdown();
        }


        private void OnLoad()
        {
            Logger.Info("Creating OpenGL Context");


            if (_window == null)
            {
                Logger.Error("Window is null!");
                return;
            }


            var gl = Silk.NET.OpenGL.GL.GetApi(_window);


            Logger.Info("OpenGL Context Created");


            // Create 2D camera
            var camera = new Camera2D(
                1280,
                720
            );


            // Create quad renderer
            var quadRenderer = new QuadRenderer(
                gl,
                camera
            );


            Logger.Info("Quad Renderer Created");


            // Create main renderer
            _renderer = new GLRenderer(
                gl,
                quadRenderer
            );


            Logger.Info("Renderer Created");


            _renderer.Initialize();


            Logger.Info("Renderer Initialized");


            // Create 2D graphics API
            _graphics2D = new Graphics2D(
                quadRenderer
            );


            // Start boot scene
            _sceneManager.ChangeScene(
                new BootScene(
                    _graphics2D
                )
            );


            Logger.Info("Boot Scene Loaded");
        }


        private void OnRender(double deltaTime)
        {
            _gameTime.Update(deltaTime);


            _sceneManager.Update(deltaTime);


            _fpsCounter.Update();


            if (_fpsCounter.FPS != _lastFPS)
            {
                _lastFPS = _fpsCounter.FPS;

                Logger.Info($"FPS: {_lastFPS}");
            }


            _renderer.BeginFrame();


            _sceneManager.Render();


            _renderer.EndFrame();
        }


        private void OnClosing()
        {
            Logger.Info("Bye, Boomerang User!");
        }
    }
}