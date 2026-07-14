using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.UI.Fonts
{
    public class Font
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public uint Texture { get; set; }

        public Font(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}
