using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RanSanMoi
{
    public partial class Form1 : Form
    {
        Random randMatrix = new Random();
        Matrix matrix;
        int highscore = 0;
        int score = 0;
        Random randFood = new Random();
        Food food;
        Graphics paper;
        Snake snake = new Snake();
        Boolean left = false, right = false, up = false, down = false;
        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
            matrix = new Matrix(randMatrix);
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snake.drawSnake(paper);
            matrix.drawMatrix(paper);

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                timer1.Enabled = true;
                left = false;right = false;up = false;down = false;
                label1.Text = "";
            }
            if (e.KeyData == Keys.Up && down ==false )
            {
                up = true;
                down = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                up = false;
                down = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                up = false;
                down = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                up = false;
                down = false;
                left = false;
                right = true;
            }
            if (e.KeyCode == Keys.F1)
            {
                Application.Restart();
            }
            //Pause or Resum
            if (e.KeyCode == Keys.F2)
            {
                if (label1.Text == "F2: Resume")
                {
                    timer1.Enabled = true;
                    label1.Text = "";
                }
                else
                {
                    timer1.Enabled = false;
                    label1.Text = "F2: Resume";
                }
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripScore.Text = score.ToString();
            if (down == true) { snake.moveDown(); }
            if (up == true) { snake.moveUp(); }
            if (left == true) { snake.moveLeft(); }
            if (right == true) { snake.moveRight(); }
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 5;
                    snake.growSnake();
                    food.foodLocation(randFood);
                }
                if (score > highscore)
                    highscore = score;
                toolStripStatusLabelScorehigh.Text = highscore.ToString();
            }
            if (score > 50)
            {
                timer1.Interval = 90;
            }
            if (score > 100)
            {
                timer1.Interval = 80;
                matrix.matrixLocation(randMatrix);
            }
            if (score > 150)
            {
                timer1.Interval = 70;
            }

            collistion();
            this.Invalidate();
        }

      

        public void collistion()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    Restart();
                }
            }
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y >300)
            {
                Restart();
            }
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 300)
            {
                Restart();
            }
            if (snake.SnakeRec[0].IntersectsWith(matrix.matrixRec))
            {
                Restart();
            }
        }

        void Restart()
        {
            timer1.Enabled = false;
            label1.Text = "Bấm phím Enter để bắt đầu chơi!!!";
            toolStripScore.Text = "0";
            score = 0;
            MessageBox.Show("Kết thúc trò chơi!!!!","Thông báo");
            snake = new Snake();
        }

       

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    timer1.Enabled = true;
        //    DialogResult dg;
        //    dg = MessageBox.Show("Bạn có chắc là muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
        //    if (dg == DialogResult.Yes)
        //    {
        //       Application.Exit();
        //    }
        //    else
        //    {
        //       timer1.Enabled = false;
        //    }
        //}
        private void labelnumber1_Click(object sender, EventArgs e)
        {
            labelnumber1.BackColor = Color.Red;
            labelnumber2.BackColor = Color.Yellow;
            labelnumber3.BackColor = Color.Yellow;
            labelnumber4.BackColor = Color.Yellow;
            labelnumber5.BackColor = Color.Yellow;
            timer1.Interval = 100;
        }
        private void labelnumber2_Click(object sender, EventArgs e)
        {
            
            labelnumber1.BackColor = Color.Yellow;
            labelnumber2.BackColor = Color.Red;
            labelnumber3.BackColor = Color.Yellow;
            labelnumber4.BackColor = Color.Yellow;
            labelnumber5.BackColor = Color.Yellow;
            timer1.Interval = 90;
        }
        private void labelnumber3_Click(object sender, EventArgs e)
        {

            labelnumber1.BackColor = Color.Yellow;
            labelnumber2.BackColor = Color.Yellow;
            labelnumber3.BackColor = Color.Red;
            labelnumber4.BackColor = Color.Yellow;
            labelnumber5.BackColor = Color.Yellow;
            timer1.Interval = 70;
        }
        private void labelnumber4_Click(object sender, EventArgs e)
        {

            labelnumber1.BackColor = Color.Yellow;
            labelnumber2.BackColor = Color.Yellow;
            labelnumber3.BackColor = Color.Yellow;
            labelnumber4.BackColor = Color.Red;
            labelnumber5.BackColor = Color.Yellow;
            timer1.Interval = 60;
        }

        private void labelnumber5_Click(object sender, EventArgs e)
        {
            labelnumber1.BackColor = Color.Yellow;
            labelnumber2.BackColor = Color.Yellow;
            labelnumber3.BackColor = Color.Yellow;
            labelnumber4.BackColor = Color.Yellow;
            labelnumber5.BackColor =  Color.Red;
            timer1.Interval = 40;
        }
    }
}
