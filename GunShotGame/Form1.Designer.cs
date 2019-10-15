namespace GunShotGame
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
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.FireAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Wide Latin", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.Color.Red;
            this.Load.Location = new System.Drawing.Point(27, 348);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(98, 72);
            this.Load.TabIndex = 0;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Spin
            // 
            this.Spin.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.Color.Red;
            this.Spin.Location = new System.Drawing.Point(147, 348);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(105, 72);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fire
            // 
            this.Fire.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.Red;
            this.Fire.Location = new System.Drawing.Point(290, 348);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(105, 72);
            this.Fire.TabIndex = 2;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // FireAway
            // 
            this.FireAway.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireAway.ForeColor = System.Drawing.Color.Red;
            this.FireAway.Location = new System.Drawing.Point(433, 348);
            this.FireAway.Name = "FireAway";
            this.FireAway.Size = new System.Drawing.Size(144, 72);
            this.FireAway.TabIndex = 3;
            this.FireAway.Text = "FIRE AWAY";
            this.FireAway.UseVisualStyleBackColor = true;
            this.FireAway.Click += new System.EventHandler(this.FireAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Font = new System.Drawing.Font("Wide Latin", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlayAgain.Location = new System.Drawing.Point(632, 362);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(137, 44);
            this.PlayAgain.TabIndex = 4;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GunShotGame.Resource1.GameStart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GunShotGame.Resource1.GameStart;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 426);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.FireAway);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button FireAway;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

