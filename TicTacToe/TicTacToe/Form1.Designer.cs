namespace TicTacToe
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_player = new System.Windows.Forms.RadioButton();
            this.rb_AI = new System.Windows.Forms.RadioButton();
            this.rb_random = new System.Windows.Forms.RadioButton();
            this.lbl_errorMsg = new System.Windows.Forms.Label();
            this.btn_exitGame = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.panel_gameBoard = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_0_0 = new System.Windows.Forms.Button();
            this.btn_0_1 = new System.Windows.Forms.Button();
            this.btn_0_2 = new System.Windows.Forms.Button();
            this.btn_1_0 = new System.Windows.Forms.Button();
            this.btn_1_1 = new System.Windows.Forms.Button();
            this.btn_1_2 = new System.Windows.Forms.Button();
            this.btn_2_0 = new System.Windows.Forms.Button();
            this.btn_2_1 = new System.Windows.Forms.Button();
            this.btn_2_2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel_gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_player);
            this.groupBox1.Controls.Add(this.rb_AI);
            this.groupBox1.Controls.Add(this.rb_random);
            this.groupBox1.Location = new System.Drawing.Point(54, 1219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 158);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Who goes first...";
            // 
            // rb_player
            // 
            this.rb_player.AutoSize = true;
            this.rb_player.Location = new System.Drawing.Point(17, 104);
            this.rb_player.Name = "rb_player";
            this.rb_player.Size = new System.Drawing.Size(104, 29);
            this.rb_player.TabIndex = 2;
            this.rb_player.Text = "Player";
            this.rb_player.UseVisualStyleBackColor = true;
            this.rb_player.Click += new System.EventHandler(this.radioButtonClickEvent);
            // 
            // rb_AI
            // 
            this.rb_AI.AutoSize = true;
            this.rb_AI.Location = new System.Drawing.Point(17, 69);
            this.rb_AI.Name = "rb_AI";
            this.rb_AI.Size = new System.Drawing.Size(62, 29);
            this.rb_AI.TabIndex = 1;
            this.rb_AI.Text = "AI";
            this.rb_AI.UseVisualStyleBackColor = true;
            this.rb_AI.Click += new System.EventHandler(this.radioButtonClickEvent);
            // 
            // rb_random
            // 
            this.rb_random.AutoSize = true;
            this.rb_random.Location = new System.Drawing.Point(17, 34);
            this.rb_random.Name = "rb_random";
            this.rb_random.Size = new System.Drawing.Size(123, 29);
            this.rb_random.TabIndex = 0;
            this.rb_random.Text = "Random";
            this.rb_random.UseVisualStyleBackColor = true;
            this.rb_random.Click += new System.EventHandler(this.radioButtonClickEvent);
            // 
            // lbl_errorMsg
            // 
            this.lbl_errorMsg.AutoSize = true;
            this.lbl_errorMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_errorMsg.Location = new System.Drawing.Point(54, 1384);
            this.lbl_errorMsg.Name = "lbl_errorMsg";
            this.lbl_errorMsg.Size = new System.Drawing.Size(378, 25);
            this.lbl_errorMsg.TabIndex = 23;
            this.lbl_errorMsg.Text = "Must choose one of the options above";
            this.lbl_errorMsg.Visible = false;
            // 
            // btn_exitGame
            // 
            this.btn_exitGame.Location = new System.Drawing.Point(868, 1307);
            this.btn_exitGame.Name = "btn_exitGame";
            this.btn_exitGame.Size = new System.Drawing.Size(163, 60);
            this.btn_exitGame.TabIndex = 26;
            this.btn_exitGame.Text = "Exit Game";
            this.btn_exitGame.UseVisualStyleBackColor = true;
            this.btn_exitGame.Click += new System.EventHandler(this.btn_exitGame_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(680, 1307);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(163, 60);
            this.btn_newGame.TabIndex = 25;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_startGame
            // 
            this.btn_startGame.Location = new System.Drawing.Point(496, 1307);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(163, 60);
            this.btn_startGame.TabIndex = 24;
            this.btn_startGame.Text = "Start Game";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // panel_gameBoard
            // 
            this.panel_gameBoard.Controls.Add(this.label5);
            this.panel_gameBoard.Controls.Add(this.label4);
            this.panel_gameBoard.Controls.Add(this.label3);
            this.panel_gameBoard.Controls.Add(this.label2);
            this.panel_gameBoard.Controls.Add(this.label1);
            this.panel_gameBoard.Controls.Add(this.A);
            this.panel_gameBoard.Controls.Add(this.panel4);
            this.panel_gameBoard.Controls.Add(this.panel3);
            this.panel_gameBoard.Controls.Add(this.panel2);
            this.panel_gameBoard.Controls.Add(this.panel5);
            this.panel_gameBoard.Controls.Add(this.btn_0_0);
            this.panel_gameBoard.Controls.Add(this.btn_0_1);
            this.panel_gameBoard.Controls.Add(this.btn_0_2);
            this.panel_gameBoard.Controls.Add(this.btn_1_0);
            this.panel_gameBoard.Controls.Add(this.btn_1_1);
            this.panel_gameBoard.Controls.Add(this.btn_1_2);
            this.panel_gameBoard.Controls.Add(this.btn_2_0);
            this.panel_gameBoard.Controls.Add(this.btn_2_1);
            this.panel_gameBoard.Controls.Add(this.btn_2_2);
            this.panel_gameBoard.Location = new System.Drawing.Point(122, 64);
            this.panel_gameBoard.Name = "panel_gameBoard";
            this.panel_gameBoard.Size = new System.Drawing.Size(1174, 1080);
            this.panel_gameBoard.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 40);
            this.label5.TabIndex = 37;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 40);
            this.label4.TabIndex = 36;
            this.label4.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 831);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 40);
            this.label3.TabIndex = 35;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 40);
            this.label2.TabIndex = 34;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "B";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(259, 40);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(36, 40);
            this.A.TabIndex = 32;
            this.A.Text = "A";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(131, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 22);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(131, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 22);
            this.panel3.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(717, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 866);
            this.panel2.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(426, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 866);
            this.panel5.TabIndex = 28;
            // 
            // btn_0_0
            // 
            this.btn_0_0.FlatAppearance.BorderSize = 0;
            this.btn_0_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_0.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_0.Location = new System.Drawing.Point(170, 117);
            this.btn_0_0.Name = "btn_0_0";
            this.btn_0_0.Size = new System.Drawing.Size(250, 250);
            this.btn_0_0.TabIndex = 26;
            this.btn_0_0.UseVisualStyleBackColor = true;
            // 
            // btn_0_1
            // 
            this.btn_0_1.FlatAppearance.BorderSize = 0;
            this.btn_0_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_1.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_1.Location = new System.Drawing.Point(475, 117);
            this.btn_0_1.Name = "btn_0_1";
            this.btn_0_1.Size = new System.Drawing.Size(250, 250);
            this.btn_0_1.TabIndex = 27;
            this.btn_0_1.UseVisualStyleBackColor = true;
            // 
            // btn_0_2
            // 
            this.btn_0_2.FlatAppearance.BorderSize = 0;
            this.btn_0_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_2.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_2.Location = new System.Drawing.Point(749, 117);
            this.btn_0_2.Name = "btn_0_2";
            this.btn_0_2.Size = new System.Drawing.Size(250, 250);
            this.btn_0_2.TabIndex = 25;
            this.btn_0_2.UseVisualStyleBackColor = true;
            // 
            // btn_1_0
            // 
            this.btn_1_0.FlatAppearance.BorderSize = 0;
            this.btn_1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_0.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_0.Location = new System.Drawing.Point(170, 421);
            this.btn_1_0.Name = "btn_1_0";
            this.btn_1_0.Size = new System.Drawing.Size(250, 250);
            this.btn_1_0.TabIndex = 24;
            this.btn_1_0.UseVisualStyleBackColor = true;
            // 
            // btn_1_1
            // 
            this.btn_1_1.FlatAppearance.BorderSize = 0;
            this.btn_1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_1.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_1.Location = new System.Drawing.Point(475, 411);
            this.btn_1_1.Name = "btn_1_1";
            this.btn_1_1.Size = new System.Drawing.Size(250, 250);
            this.btn_1_1.TabIndex = 23;
            this.btn_1_1.UseVisualStyleBackColor = true;
            // 
            // btn_1_2
            // 
            this.btn_1_2.FlatAppearance.BorderSize = 0;
            this.btn_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_2.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_2.Location = new System.Drawing.Point(749, 421);
            this.btn_1_2.Name = "btn_1_2";
            this.btn_1_2.Size = new System.Drawing.Size(250, 250);
            this.btn_1_2.TabIndex = 22;
            this.btn_1_2.UseVisualStyleBackColor = true;
            // 
            // btn_2_0
            // 
            this.btn_2_0.FlatAppearance.BorderSize = 0;
            this.btn_2_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_0.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_0.Location = new System.Drawing.Point(170, 705);
            this.btn_2_0.Name = "btn_2_0";
            this.btn_2_0.Size = new System.Drawing.Size(250, 250);
            this.btn_2_0.TabIndex = 21;
            this.btn_2_0.UseVisualStyleBackColor = true;
            // 
            // btn_2_1
            // 
            this.btn_2_1.FlatAppearance.BorderSize = 0;
            this.btn_2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_1.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_1.Location = new System.Drawing.Point(475, 705);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(250, 250);
            this.btn_2_1.TabIndex = 20;
            this.btn_2_1.UseVisualStyleBackColor = true;
            // 
            // btn_2_2
            // 
            this.btn_2_2.FlatAppearance.BorderSize = 0;
            this.btn_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_2.Font = new System.Drawing.Font("Trebuchet MS", 85.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_2.Location = new System.Drawing.Point(749, 705);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(250, 250);
            this.btn_2_2.TabIndex = 19;
            this.btn_2_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1447);
            this.Controls.Add(this.panel_gameBoard);
            this.Controls.Add(this.btn_exitGame);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btn_startGame);
            this.Controls.Add(this.lbl_errorMsg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_gameBoard.ResumeLayout(false);
            this.panel_gameBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_AI;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_player;
        private System.Windows.Forms.Label lbl_errorMsg;
        private System.Windows.Forms.Button btn_exitGame;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.Panel panel_gameBoard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_0_0;
        private System.Windows.Forms.Button btn_0_1;
        private System.Windows.Forms.Button btn_0_2;
        private System.Windows.Forms.Button btn_1_0;
        private System.Windows.Forms.Button btn_1_1;
        private System.Windows.Forms.Button btn_1_2;
        private System.Windows.Forms.Button btn_2_0;
        private System.Windows.Forms.Button btn_2_1;
        private System.Windows.Forms.Button btn_2_2;
    }
}

