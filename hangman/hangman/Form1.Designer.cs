namespace hangman
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.letter0 = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.Label();
            this.letter2 = new System.Windows.Forms.Label();
            this.letter3 = new System.Windows.Forms.Label();
            this.letter4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.used = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // letter0
            // 
            this.letter0.AutoSize = true;
            this.letter0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letter0.Location = new System.Drawing.Point(17, 198);
            this.letter0.Name = "letter0";
            this.letter0.Size = new System.Drawing.Size(22, 29);
            this.letter0.TabIndex = 5;
            this.letter0.Text = "-";
            // 
            // letter1
            // 
            this.letter1.AutoSize = true;
            this.letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letter1.Location = new System.Drawing.Point(63, 198);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(22, 29);
            this.letter1.TabIndex = 6;
            this.letter1.Text = "-";
            // 
            // letter2
            // 
            this.letter2.AutoSize = true;
            this.letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letter2.Location = new System.Drawing.Point(109, 198);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(22, 29);
            this.letter2.TabIndex = 7;
            this.letter2.Text = "-";
            // 
            // letter3
            // 
            this.letter3.AutoSize = true;
            this.letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letter3.Location = new System.Drawing.Point(155, 198);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(22, 29);
            this.letter3.TabIndex = 8;
            this.letter3.Text = "-";
            // 
            // letter4
            // 
            this.letter4.AutoSize = true;
            this.letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letter4.Location = new System.Drawing.Point(201, 198);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(22, 29);
            this.letter4.TabIndex = 9;
            this.letter4.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // used
            // 
            this.used.AutoSize = true;
            this.used.Location = new System.Drawing.Point(12, 242);
            this.used.Name = "used";
            this.used.Size = new System.Drawing.Size(0, 13);
            this.used.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "použitá písmena:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.used);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.letter4);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.letter0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label letter0;
        private System.Windows.Forms.Label letter1;
        private System.Windows.Forms.Label letter2;
        private System.Windows.Forms.Label letter3;
        private System.Windows.Forms.Label letter4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label used;
        private System.Windows.Forms.Label label1;
    }
}

