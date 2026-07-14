using Silk.NET.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Graphics._2D
{
    public class Texture
    {
        public uint Handle { get; private set; }
        private readonly GL _gl;

        public Texture(GL gl)
        {
            _gl = gl;
        }
    }
}
