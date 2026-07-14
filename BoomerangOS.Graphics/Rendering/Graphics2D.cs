using BoomerangOS.Graphics._2D;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Graphics.Rendering
{
    public class Graphics2D
    {
        private QuadRenderer _quad;

        public Graphics2D(QuadRenderer quad)
        {
            _quad = quad;
        }

        public void Rectangle(float x, float y, float width, float height)
        {
            _quad.Draw(x,y,width,height);
        }
    }
}
