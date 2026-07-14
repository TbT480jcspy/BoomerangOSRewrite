using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BoomerangOS.Common.Time
{
    public class FPSCounter
    {
        private readonly Stopwatch _timer = new();

        private int _frames;
        private int _fps;

        public int FPS => _fps;

        public FPSCounter()
        {
            _timer.Start();
        }

        public void Update()
        {
            _frames++;

            if (_timer.ElapsedMilliseconds >= 1000)
            {
                _fps = _frames;

                _frames = 0;

                _timer.Restart();
            }
        }
    }
}
