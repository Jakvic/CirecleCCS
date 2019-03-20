namespace CirecleCCS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_x = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.label_xval = new System.Windows.Forms.Label();
            this.label_yval = new System.Windows.Forms.Label();
            this.labelccsX = new System.Windows.Forms.Label();
            this.label_CcsY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_x)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_x
            // 
            this.pictureBox_x.BackColor = System.Drawing.Color.Black;
            this.pictureBox_x.Location = new System.Drawing.Point(105, 30);
            this.pictureBox_x.Name = "pictureBox_x";
            this.pictureBox_x.Size = new System.Drawing.Size(541, 417);
            this.pictureBox_x.TabIndex = 0;
            this.pictureBox_x.TabStop = false;
            this.pictureBox_x.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_x_Paint);
            this.pictureBox_x.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_x_MouseDown);
            this.pictureBox_x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_x_MouseMove);
            this.pictureBox_x.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_x_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox_x);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 546);
            this.panel1.TabIndex = 1;
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadImage.Font = new System.Drawing.Font("Courier New", 10F);
            this.button_LoadImage.Location = new System.Drawing.Point(743, 32);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(105, 63);
            this.button_LoadImage.TabIndex = 2;
            this.button_LoadImage.Text = "Load_Image";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // label_xval
            // 
            this.label_xval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_xval.AutoSize = true;
            this.label_xval.Font = new System.Drawing.Font("Courier New", 9F);
            this.label_xval.Location = new System.Drawing.Point(768, 222);
            this.label_xval.Name = "label_xval";
            this.label_xval.Size = new System.Drawing.Size(35, 15);
            this.label_xval.TabIndex = 3;
            this.label_xval.Text = "XVal";
            // 
            // label_yval
            // 
            this.label_yval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_yval.AutoSize = true;
            this.label_yval.Font = new System.Drawing.Font("Courier New", 9F);
            this.label_yval.Location = new System.Drawing.Point(768, 248);
            this.label_yval.Name = "label_yval";
            this.label_yval.Size = new System.Drawing.Size(35, 15);
            this.label_yval.TabIndex = 3;
            this.label_yval.Text = "YVal";
            // 
            // labelccsX
            // 
            this.labelccsX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelccsX.AutoSize = true;
            this.labelccsX.Font = new System.Drawing.Font("Courier New", 9F);
            this.labelccsX.Location = new System.Drawing.Point(768, 273);
            this.labelccsX.Name = "labelccsX";
            this.labelccsX.Size = new System.Drawing.Size(35, 15);
            this.labelccsX.TabIndex = 3;
            this.labelccsX.Text = "CcsX";
            // 
            // label_CcsY
            // 
            this.label_CcsY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CcsY.AutoSize = true;
            this.label_CcsY.Font = new System.Drawing.Font("Courier New", 9F);
            this.label_CcsY.Location = new System.Drawing.Point(768, 299);
            this.label_CcsY.Name = "label_CcsY";
            this.label_CcsY.Size = new System.Drawing.Size(35, 15);
            this.label_CcsY.TabIndex = 3;
            this.label_CcsY.Text = "CcsY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 550);
            this.Controls.Add(this.label_CcsY);
            this.Controls.Add(this.labelccsX);
            this.Controls.Add(this.label_yval);
            this.Controls.Add(this.label_xval);
            this.Controls.Add(this.button_LoadImage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_x)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_x;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.Label label_xval;
        private System.Windows.Forms.Label label_yval;
        private System.Windows.Forms.Label labelccsX;
        private System.Windows.Forms.Label label_CcsY;
    }
}

