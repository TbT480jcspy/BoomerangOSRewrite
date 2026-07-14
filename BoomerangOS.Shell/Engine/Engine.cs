using System;
using System.Collections.Generic;
using System.Text;
using BoomerangOS.Common.Logging;
using BoomerangOS.Graphics.Rendering;
using Silk.NET.Windowing;
using BoomerangOS.Common.Time;

namespace BoomerangOS.Shell.Engine
{
    public class Engine
    {
        private IWindow _window = null!;

        private IRenderer _renderer = null!;

        private FPSCounter _fpsCounter = new();

        private GameTime _gameTime = new();


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

            if (gl == null)
            {
                Logger.Error("OpenGL context is null!");
                return;
            }

            Logger.Info("OpenGL Context Created");

            _renderer = new GLRenderer(gl);

            Logger.Info("Renderer Created");

            _renderer.Initialize();

            Logger.Info("Renderer Initialized");
        }

        private void OnRender(double deltaTime)
        {
            _gameTime.Update(deltaTime);

            _fpsCounter.Update();

            if (_fpsCounter.FPS != _lastFPS)
            {
                _lastFPS = _fpsCounter.FPS;

                Logger.Info($"FPS: {_lastFPS}");
            }

            _renderer.BeginFrame();

            _renderer.EndFrame();
        }

        private void OnClosing()
        {
            Logger.Info("Bye, Boomerang User!");
        }


    }
}
