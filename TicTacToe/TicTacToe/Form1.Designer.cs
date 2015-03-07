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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.player1 = new System.Windows.Forms.Label();
            this.Draw_label = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.draw_counter = new System.Windows.Forms.Label();
            this.xWin_counter = new System.Windows.Forms.Label();
            this.oWin_counter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(93, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Forte", 36F);
            this.A3.Location = new System.Drawing.Point(174, 28);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Forte", 36F);
            this.B1.Location = new System.Drawing.Point(12, 108);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Forte", 36F);
            this.B2.Location = new System.Drawing.Point(93, 108);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Forte", 36F);
            this.B3.Location = new System.Drawing.Point(174, 108);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Forte", 36F);
            this.C1.Location = new System.Drawing.Point(12, 190);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Forte", 36F);
            this.C2.Location = new System.Drawing.Point(93, 190);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Forte", 36F);
            this.C3.Location = new System.Drawing.Point(174, 189);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.newGameToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.BackgroundImage")));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.resetToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetToolStripMenuItem.BackgroundImage")));
            this.resetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.resetToolStripMenuItem.Text = "Reset Results";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.exitToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.BackgroundImage")));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(14, 270);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(70, 27);
            this.player1.TabIndex = 10;
            this.player1.Text = "Player 1";
            // 
            // Draw_label
            // 
            this.Draw_label.AutoSize = true;
            this.Draw_label.BackColor = System.Drawing.Color.Transparent;
            this.Draw_label.Font = new System.Drawing.Font("Chiller", 18F);
            this.Draw_label.Location = new System.Drawing.Point(109, 270);
            this.Draw_label.Name = "Draw_label";
            this.Draw_label.Size = new System.Drawing.Size(44, 27);
            this.Draw_label.TabIndex = 11;
            this.Draw_label.Text = "Draw";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Font = new System.Drawing.Font("Chiller", 18F);
            this.player2.Location = new System.Drawing.Point(177, 270);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(72, 27);
            this.player2.TabIndex = 12;
            this.player2.Text = "Player 2";
            // 
            // draw_counter
            // 
            this.draw_counter.AutoSize = true;
            this.draw_counter.BackColor = System.Drawing.Color.Transparent;
            this.draw_counter.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold);
            this.draw_counter.Location = new System.Drawing.Point(121, 293);
            this.draw_counter.Name = "draw_counter";
            this.draw_counter.Size = new System.Drawing.Size(20, 23);
            this.draw_counter.TabIndex = 13;
            this.draw_counter.Text = "0";
            // 
            // xWin_counter
            // 
            this.xWin_counter.AutoSize = true;
            this.xWin_counter.BackColor = System.Drawing.Color.Transparent;
            this.xWin_counter.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWin_counter.Location = new System.Drawing.Point(39, 293);
            this.xWin_counter.Name = "xWin_counter";
            this.xWin_counter.Size = new System.Drawing.Size(20, 23);
            this.xWin_counter.TabIndex = 14;
            this.xWin_counter.Text = "0";
            // 
            // oWin_counter
            // 
            this.oWin_counter.AutoSize = true;
            this.oWin_counter.BackColor = System.Drawing.Color.Transparent;
            this.oWin_counter.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold);
            this.oWin_counter.Location = new System.Drawing.Point(203, 293);
            this.oWin_counter.Name = "oWin_counter";
            this.oWin_counter.Size = new System.Drawing.Size(20, 23);
            this.oWin_counter.TabIndex = 15;
            this.oWin_counter.Text = "0";
            // 
            // Form1
            // 
            this.AccessibleName = "Georgi Micev";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(263, 323);
            this.Controls.Add(this.oWin_counter);
            this.Controls.Add(this.xWin_counter);
            this.Controls.Add(this.draw_counter);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.Draw_label);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.C3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button A1;
        public System.Windows.Forms.Button A2;
        public System.Windows.Forms.Button A3;
        public System.Windows.Forms.Button B1;
        public System.Windows.Forms.Button B2;
        public System.Windows.Forms.Button B3;
        public System.Windows.Forms.Button C1;
        public System.Windows.Forms.Button C2;
        public System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label Draw_label;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label draw_counter;
        private System.Windows.Forms.Label xWin_counter;
        private System.Windows.Forms.Label oWin_counter;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

