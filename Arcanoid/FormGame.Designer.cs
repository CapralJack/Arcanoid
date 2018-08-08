namespace Arcanoid
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.racket_main = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.brick1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 26);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_left
            // 
            this.label_left.BackColor = System.Drawing.Color.Yellow;
            this.label_left.Location = new System.Drawing.Point(-2, 25);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(23, 524);
            this.label_left.TabIndex = 1;
            // 
            // label_right
            // 
            this.label_right.BackColor = System.Drawing.Color.Yellow;
            this.label_right.Location = new System.Drawing.Point(770, 25);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(23, 524);
            this.label_right.TabIndex = 2;
            // 
            // racket_main
            // 
            this.racket_main.Enabled = false;
            this.racket_main.Location = new System.Drawing.Point(347, 547);
            this.racket_main.Name = "racket_main";
            this.racket_main.Size = new System.Drawing.Size(104, 31);
            this.racket_main.TabIndex = 3;
            this.racket_main.Text = "=====";
            this.racket_main.UseVisualStyleBackColor = true;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(394, 528);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 4;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Firebrick;
            this.brick1.Location = new System.Drawing.Point(74, 144);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(76, 25);
            this.brick1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(641, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Firebrick;
            this.brick3.Location = new System.Drawing.Point(565, 65);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(76, 25);
            this.brick3.TabIndex = 8;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Firebrick;
            this.brick2.Location = new System.Drawing.Point(405, 175);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(76, 25);
            this.brick2.TabIndex = 9;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Firebrick;
            this.brick4.Location = new System.Drawing.Point(146, 342);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(76, 25);
            this.brick4.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(791, 580);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket_main);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.Button racket_main;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Timer timer;
    }
}