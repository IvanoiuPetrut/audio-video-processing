﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Utilities
{
    public class RegionOfInterestSelector
    {
        private bool isMousePressed;
        private Point startPoint;
        private Rectangle rect;

        public RegionOfInterestSelector()
        {
            isMousePressed = false;
        }
        public bool IsMousePressed
        {
            get { return isMousePressed; }
        }
        public Rectangle Rect
        {
            get { return rect; }
        }

        public void StartSelection(Point startPoint)
        {
            isMousePressed = true;
            this.startPoint = startPoint;
        }

        public void UpdateSelection(Point currentPoint)
        {
            int width = Math.Max(startPoint.X, currentPoint.X) - Math.Min(startPoint.X, currentPoint.X);
            int height = Math.Max(startPoint.Y, currentPoint.Y) - Math.Min(startPoint.Y, currentPoint.Y);
            rect = new Rectangle(Math.Min(startPoint.X, currentPoint.X), Math.Min(startPoint.Y, currentPoint.Y), width, height);
        }

        public void EndSelection(Point endPoint)
        {
            isMousePressed = false;
        }
        public void DrawSelection(Graphics g)
        {
            if (isMousePressed)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    g.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
