using BoomerangOS.Common.Logging;
using BoomerangOS.Graphics._2D;
using Silk.NET.OpenGL;
using System;

namespace BoomerangOS.Graphics.Rendering
{
    public class GLRenderer : IRenderer
    {
        private GL _gl = null!;

        private QuadRenderer _quadRenderer;

        public QuadRenderer QuadRenderer
        {
            get
            {
                return _quadRenderer;
            }
        }

        public GLRenderer(GL gl, QuadRenderer quadRenderer)
        {
            _gl = gl;
            _quadRenderer = quadRenderer;
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
