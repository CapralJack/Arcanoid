using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class FormGame : Form
    {
        int racket_x, racket_y;
        int racket_shift_x = 10;
        int ball_x, ball_y;
        int side_lx, side_rx, side_ux;
        int ball_shift_x=8;
        int ball_shift_y=10;
        int ball_sx, ball_sy;

        
         

        public FormGame()
        {
            InitializeComponent();
        }

        private void Init_game()
        {
            racket_x = racket_main.Location.X;
            racket_y = racket_main.Location.Y;
            side_lx = label_left.Location.X + label_left.Width;
            side_rx = label_right.Location.X;
            side_ux = label3.Location.X + label3.Height;
            ball_x = ball.Location.X;
            ball_y = ball.Location.Y;
            ball_sx = ball_shift_x;
            ball_sy = - ball_shift_y;


        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            Init_game();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
                
                switch (key)
            {
                //case Keys.Escape: Application.Close(); break;
                     
                case Keys.Left: shift_racket(- racket_shift_x); break; //buton for racket movement
                case Keys.Right: shift_racket(racket_shift_x); break;
                case Keys.Enter: timer.Enabled = true; break;

            }
        }
        
        private void shift_racket(int sx)
        {
            int ax1 = racket_x + sx;
            int ax2 = ax1 + racket_main.Width;

            if (side_lx > ax1) ax1=side_lx;
            if (side_rx < ax2) ax1=side_rx-racket_main.Width;
            racket_x = ax1;

            racket_main.Location = new Point(racket_x, racket_y);
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
             move_ball();
        }

        private void move_ball()
        {
            int bx1, by1, bx2, by2; // лок.п.
            bx1 = ball_x;
            bx2 = ball_x + ball.Width;
            by1 = ball_y;
            by2 = ball_y + ball.Height;
           if(bx2+ball_sx>side_rx) ball_sx=-ball_shift_x; // reflection - condition for left wall
           if (bx1 + ball_sx < side_lx) ball_sx = ball_shift_x; // same for right
           if (by1 + ball_sy < side_ux) ball_sy = ball_shift_y; // same for seil

            if (by2+ball_sy>racket_y)
            {
                int bx0 = (bx1+bx2)/2

            }

            ball_x += ball_sx;
            ball_y += ball_sy;
            ball.Location = new Point(ball_x, ball_y);

        }
        
    }
}
