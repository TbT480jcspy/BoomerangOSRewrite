using Silk.NET.Maths;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Graphics.Math
{
    public class Camera2D
    {
        public int Width { get; }
        public int Height { get; }

        public Matrix4X4<float> Projection { get; private set; }

        public Camera2D(int width, int height)
        {
            Width = width;
            Height = height;

            Projection = CreateProjection();
        }

        private Matrix4X4<float> CreateProjection()
        {
            return Matrix4X4.CreateOrthographicOffCenter(0f, Width, Height, 0f, -1f, 1f);
        }
    }
}
