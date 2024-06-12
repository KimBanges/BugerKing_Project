namespace BugerKing_Project
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            imageList1 = new System.Windows.Forms.ImageList(components);
            pbBack = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "배경이미지.jpg");
            // 
            // pbBack
            // 
            pbBack.Dock = System.Windows.Forms.DockStyle.Fill;
            pbBack.Image = (System.Drawing.Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new System.Drawing.Point(0, 0);
            pbBack.Name = "pbBack";
            pbBack.Size = new System.Drawing.Size(984, 561);
            pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 0;
            pbBack.TabStop = false;
            pbBack.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Red;
            label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(719, 515);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(242, 37);
            label1.TabIndex = 1;
            label1.Text = "화면을 눌러주세요";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(label1);
            Controls.Add(pbBack);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label label1;
    }
}