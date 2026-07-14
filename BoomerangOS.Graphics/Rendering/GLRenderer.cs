using System;
using BoomerangOS.Common.Logging;
using Silk.NET.OpenGL;

namespace BoomerangOS.Graphics.Rendering
{
    public class GLRenderer : IRenderer
    {
        private GL _gl = null!;

        public GLRenderer(GL gl)
        {
            _gl = gl;
        }

        public void Initialize()
        {
            Logger.Info("Initializing OpenGL Renderer");

            _gl.ClearColor(0.05f, 0.05f, 0.08f, 1.0f);
        }

        public void BeginFrame()
        {
            _gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public void EndFrame()
        {

        }

        public void Shutdown()
        {
            Logger.Info("Renderer shutdown");
        }
    }
}
