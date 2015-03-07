namespace TicTacToe
{
    partial class PlayChose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayChose));
            this.singleplay_btn = new System.Windows.Forms.Button();
            this.multiplay_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplay_btn
            // 
            this.singleplay_btn.BackColor = System.Drawing.Color.Transparent;
            this.singleplay_btn.BackgroundImage = global::TicTacToe.Properties.Resources.Untitled;
            this.singleplay_btn.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleplay_btn.Location = new System.Drawing.Point(3, 120);
            this.singleplay_btn.Name = "singleplay_btn";
            this.singleplay_btn.Size = new System.Drawing.Size(104, 107);
            this.singleplay_btn.TabIndex = 0;
            this.singleplay_btn.Text = "Play agains computer";
            this.singleplay_btn.UseVisualStyleBackColor = false;
            this.singleplay_btn.Click += new System.EventHandler(this.singleplay_btn_Click);
            this.singleplay_btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.singleplay_btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // multiplay_btn
            // 
            this.multiplay_btn.BackgroundImage = global::TicTacToe.Properties.Resources.Untitled;
            this.multiplay_btn.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplay_btn.Location = new System.Drawing.Point(241, 120);
            this.multiplay_btn.Name = "multiplay_btn";
            this.multiplay_btn.Size = new System.Drawing.Size(104, 107);
            this.multiplay_btn.TabIndex = 1;
            this.multiplay_btn.Text = "Play agains friend";
            this.multiplay_btn.UseVisualStyleBackColor = true;
            this.multiplay_btn.Click += new System.EventHandler(this.multiplay_btn_Click);
            this.multiplay_btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.multiplay_btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // PlayChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 344);
            this.Controls.Add(this.multiplay_btn);
            this.Controls.Add(this.singleplay_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "PlayChose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplay_btn;
        private System.Windows.Forms.Button multiplay_btn;
    }
}