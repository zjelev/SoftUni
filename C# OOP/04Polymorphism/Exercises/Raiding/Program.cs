﻿namespace Raiding
{
    using Raiding.Core;
    class Program
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
