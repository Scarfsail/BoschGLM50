namespace GLM50.Calculations
{
    partial class TriangleCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleCalculation));
            this.sideA = new System.Windows.Forms.Label();
            this.sideB = new System.Windows.Forms.Label();
            this.sideC = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.angleA = new System.Windows.Forms.Label();
            this.angleB = new System.Windows.Forms.Label();
            this.angleC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideA
            // 
            this.sideA.AutoSize = true;
            this.sideA.Location = new System.Drawing.Point(250, 144);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(13, 13);
            this.sideA.TabIndex = 0;
            this.sideA.Text = "a";
            // 
            // sideB
            // 
            this.sideB.AutoSize = true;
            this.sideB.Location = new System.Drawing.Point(101, 144);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(13, 13);
            this.sideB.TabIndex = 1;
            this.sideB.Text = "b";
            // 
            // sideC
            // 
            this.sideC.AutoSize = true;
            this.sideC.Location = new System.Drawing.Point(153, 277);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(13, 13);
            this.sideC.TabIndex = 2;
            this.sideC.Text = "c";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(253, 8);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 254);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // angleA
            // 
            this.angleA.AutoSize = true;
            this.angleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleA.Location = new System.Drawing.Point(40, 253);
            this.angleA.Name = "angleA";
            this.angleA.Size = new System.Drawing.Size(14, 13);
            this.angleA.TabIndex = 5;
            this.angleA.Text = "α";
            // 
            // angleB
            // 
            this.angleB.AutoSize = true;
            this.angleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleB.Location = new System.Drawing.Point(303, 253);
            this.angleB.Name = "angleB";
            this.angleB.Size = new System.Drawing.Size(13, 13);
            this.angleB.TabIndex = 6;
            this.angleB.Text = "β";
            // 
            // angleC
            // 
            this.angleC.AutoSize = true;
            this.angleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleC.Location = new System.Drawing.Point(153, 18);
            this.angleC.Name = "angleC";
            this.angleC.Size = new System.Drawing.Size(11, 13);
            this.angleC.TabIndex = 7;
            this.angleC.Text = "ᵞ";
            // 
            // TriangleCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 299);
            this.Controls.Add(this.angleC);
            this.Controls.Add(this.angleB);
            this.Controls.Add(this.angleA);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.sideC);
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TriangleCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TriangleCalculation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sideA;
        private System.Windows.Forms.Label sideB;
        private System.Windows.Forms.Label sideC;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label angleA;
        private System.Windows.Forms.Label angleB;
        private System.Windows.Forms.Label angleC;
    }
}