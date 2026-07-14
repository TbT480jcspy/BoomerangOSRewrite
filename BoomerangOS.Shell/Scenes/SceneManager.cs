using BoomerangOS.Common.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Shell.Scenes
{
    public class SceneManager
    {
        private IScene? _currentScene;

        public void ChangeScene(IScene newScene)
        {
            Logger.Info($"Changing Scene to {newScene.GetType().Name}");

            _currentScene?.Unload();

            _currentScene = newScene;

            _currentScene.Load();
        }

        public void Update(double deltaTime)
        {
            _currentScene?.Update(deltaTime);
        }

        public void Render()
        {
            _currentScene?.Render();
        }
    }
}
