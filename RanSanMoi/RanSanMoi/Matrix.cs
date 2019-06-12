using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoi
{
    class Matrix
    {

        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle matrixRec;

        public Matrix(Random randMatrix)
        {
            x = randMatrix.Next(15, 30) * 10;
            y = randMatrix.Next(15, 30) * 10;
            brush = new SolidBrush(Color.Black);
            width = 25; height = 10;
            matrixRec = new Rectangle(x, y, width, height);
        }
        public void matrixLocation(Random randMatrix)
        {
            x = randMatrix.Next(15, 30) * 10;
            y = randMatrix.Next(15, 30) * 10;
        }
        public void drawMatrix(Graphics paper)
        {
            matrixRec.X = x;
            matrixRec.Y = y;
            paper.FillEllipse(brush, matrixRec);
        }
    }
       
}
