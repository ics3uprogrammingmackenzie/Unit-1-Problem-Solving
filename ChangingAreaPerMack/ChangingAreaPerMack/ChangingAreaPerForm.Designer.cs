namespace ChangingAreaPerMack
{
    partial class frmChangingAreaPer
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPerimiter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimiterAnswer = new System.Windows.Forms.Label();
            this.lblWidthAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblPerimiter
            // 
            this.lblPerimiter.AutoSize = true;
            this.lblPerimiter.Location = new System.Drawing.Point(12, 171);
            this.lblPerimiter.Name = "lblPerimiter";
            this.lblPerimiter.Size = new System.Drawing.Size(81, 13);
            this.lblPerimiter.TabIndex = 1;
            this.lblPerimiter.Text = "The perimiter is:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 222);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "The area is:";
            this.lblArea.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(122, 85);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(122, 43);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 43);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(58, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length (M)";
            this.lblLength.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 92);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(56, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width  (M)";
            // 
            // lblPerimiterAnswer
            // 
            this.lblPerimiterAnswer.AutoSize = true;
            this.lblPerimiterAnswer.Location = new System.Drawing.Point(187, 171);
            this.lblPerimiterAnswer.Name = "lblPerimiterAnswer";
            this.lblPerimiterAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblPerimiterAnswer.TabIndex = 7;
            this.lblPerimiterAnswer.Text = "label2";
            // 
            // lblWidthAnswer
            // 
            this.lblWidthAnswer.AutoSize = true;
            this.lblWidthAnswer.Location = new System.Drawing.Point(187, 222);
            this.lblWidthAnswer.Name = "lblWidthAnswer";
            this.lblWidthAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblWidthAnswer.TabIndex = 8;
            this.lblWidthAnswer.Text = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 111);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // frmChangingAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWidthAnswer);
            this.Controls.Add(this.lblPerimiterAnswer);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimiter);
            this.Controls.Add(this.label1);
            this.Name = "frmChangingAreaPer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPerimiter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimiterAnswer;
        private System.Windows.Forms.Label lblWidthAnswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}

