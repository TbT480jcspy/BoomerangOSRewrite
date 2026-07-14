using BoomerangOS.Common.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using BoomerangOS.Graphics.Rendering;

namespace BoomerangOS.Shell.Scenes
{
    public class BootScene : IScene
    {
        private double _time;
        private float _scale = 1f;

        private readonly Graphics2D _graphics;


        public BootScene(Graphics2D graphics)
        {
            _graphics = graphics;
        }
        public void Load()
        {
            Logger.Info("Boot Scene Loaded");
        }

        public void Update(double deltaTime)
        {
            _time += deltaTime;

            _scale = 1f + (float)Math.Sin(_time * 2) * 0.05f;
        }

        public void Render()
        {
            _graphics.Rectangle(
        540,
        310,
        200,
        100
    );
        }

        public void Unload()
        {
            Logger.Info("Boot Scene Unloaded");
        }
    }
}
