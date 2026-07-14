using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.UI.Text
{
    public class TextElement
    {
        public string Text { get; set; } = string.Empty;
        public float X { get; set; }
        public float Y { get; set; }
        public float Scale { get; set; } = 1.0f;
        public float Opacity { get; set; } = 1.0f;
    }
}
