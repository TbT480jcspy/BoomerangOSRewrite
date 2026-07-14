using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Shell.Scenes
{
    public interface IScene
    {
        void Load();
        void Update(double deltaTime);
        void Render();
        void Unload();
    }
}
