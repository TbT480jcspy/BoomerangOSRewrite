using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangOS.Common.Time
{
    public class GameTime
    {
        public double DeltaTime { get; private set; }
        public double TotalTime { get; private set; }

        public void Update(double deltaTime)
        {
            DeltaTime = deltaTime;
            TotalTime += deltaTime;
        }
    }
}
