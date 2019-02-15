namespace MovingCatMackenzie
{
    partial class MovingCatForm
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
            this.picCat = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatMackenzie.Properties.Resources.cat2;
            this.picCat.Location = new System.Drawing.Point(-5, 50);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(157, 161);
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "cat1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "cat2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MovingCatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCat);
            this.Name = "MovingCatForm";
            this.Text = "MovingCat";
            this.Load += new System.EventHandler(this.MovingCatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

