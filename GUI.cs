using Cosmos.System.Graphics;
using System.Drawing;
using Mouse = Cosmos.System.MouseManager;
using Point = Cosmos.System.Graphics.Point;
using Sys = Cosmos.System;

namespace MyGUI_OS
{
    public static class GUI
    {
        private static Canvas canvas;
        private static Pen pen;

        private static Point oldMousePos;

        public static void RegisterGUI()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            pen = new Pen(Color.White);
            canvas.Clear(Color.Blue);

            Mouse.ScreenHeight = (uint)canvas.Mode.Rows;
            Mouse.ScreenWidth = (uint)canvas.Mode.Columns;

            Sys.MouseManager.X = 1;
            Sys.MouseManager.Y = 1;
        }

        public static void DrawCursor()
        {
            Pen pen = new Pen(Color.Black);
            canvas.DrawFilledRectangle(pen, 50, 50, 100, 100);

            canvas.DrawLine(pen, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, (int)(Sys.MouseManager.X + 8), (int)Sys.MouseManager.Y);
            canvas.DrawLine(pen, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, (int)Sys.MouseManager.X, (int)(Sys.MouseManager.Y + 8));
            canvas.DrawLine(pen, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, (int)(Sys.MouseManager.X + 8), (int)(Sys.MouseManager.Y + 8));

            canvas.Clear(Color.Cyan);
        }
    }
}


