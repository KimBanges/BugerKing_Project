namespace BugerKing_Project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new System.Windows.Forms.Label();
            lbPaySum = new System.Windows.Forms.Label();
            btnPayLast = new System.Windows.Forms.Button();
            btnOrderLast = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(231, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 50);
            label1.TabIndex = 1;
            label1.Text = "결재화면";
            // 
            // lbPaySum
            // 
            lbPaySum.AutoSize = true;
            lbPaySum.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbPaySum.Location = new System.Drawing.Point(6, 39);
            lbPaySum.Name = "lbPaySum";
            lbPaySum.Size = new System.Drawing.Size(18, 30);
            lbPaySum.TabIndex = 2;
            lbPaySum.Text = ".";
            // 
            // btnPayLast
            // 
            btnPayLast.BackColor = System.Drawing.Color.Red;
            btnPayLast.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPayLast.ForeColor = System.Drawing.Color.White;
            btnPayLast.Location = new System.Drawing.Point(327, 545);
            btnPayLast.Name = "btnPayLast";
            btnPayLast.Size = new System.Drawing.Size(309, 110);
            btnPayLast.TabIndex = 31;
            btnPayLast.Text = "결재하기";
            btnPayLast.UseVisualStyleBackColor = false;
            btnPayLast.Click += btnPayLast_Click;
            // 
            // btnOrderLast
            // 
            btnOrderLast.BackColor = System.Drawing.Color.Black;
            btnOrderLast.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOrderLast.ForeColor = System.Drawing.Color.White;
            btnOrderLast.Location = new System.Drawing.Point(12, 545);
            btnOrderLast.Name = "btnOrderLast";
            btnOrderLast.Size = new System.Drawing.Size(309, 110);
            btnOrderLast.TabIndex = 32;
            btnOrderLast.Text = "주문확인";
            btnOrderLast.UseVisualStyleBackColor = false;
            btnOrderLast.Click += btnOrderLast_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Controls.Add(lbPaySum);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(624, 413);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "주문내용";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(551, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(85, 85);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(648, 667);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnOrderLast);
            Controls.Add(btnPayLast);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPaySum;
        private System.Windows.Forms.Button btnPayLast;
        private System.Windows.Forms.Button btnOrderLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}