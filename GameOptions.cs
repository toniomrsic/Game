﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    /// <summary>
    /// Game options
    /// </summary>
    static class GameOptions
    {
        public static int SpriteHeight = 100;
        public static int SpriteWidth = 100;
        public static int Speed = 5;

        public static int LeftEdge = 0;
        public static int RightEdge = 800;
        public static int UpEdge = 0;
        public static int DownEdge = 100;

        public static void SetBorders(int width, int height)
        {
            GameOptions.RightEdge = width;
            GameOptions.DownEdge = height;
        }

    }
}
