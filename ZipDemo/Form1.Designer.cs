namespace ZipDemo
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
            this.btnZip = new System.Windows.Forms.Button();
            this.btn_Unzip = new System.Windows.Forms.Button();
            this.btn_html = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(12, 12);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 0;
            this.btnZip.Text = "压缩文件";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.BtnZip_Click);
            // 
            // btn_Unzip
            // 
            this.btn_Unzip.Location = new System.Drawing.Point(93, 12);
            this.btn_Unzip.Name = "btn_Unzip";
            this.btn_Unzip.Size = new System.Drawing.Size(75, 23);
            this.btn_Unzip.TabIndex = 1;
            this.btn_Unzip.Text = "解压";
            this.btn_Unzip.UseVisualStyleBackColor = true;
            this.btn_Unzip.Click += new System.EventHandler(this.Btn_Unzip_Click);
            // 
            // btn_html
            // 
            this.btn_html.Location = new System.Drawing.Point(175, 11);
            this.btn_html.Name = "btn_html";
            this.btn_html.Size = new System.Drawing.Size(86, 23);
            this.btn_html.TabIndex = 2;
            this.btn_html.Text = "压缩html文件";
            this.btn_html.UseVisualStyleBackColor = true;
            this.btn_html.Click += new System.EventHandler(this.Btn_html_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_html);
            this.Controls.Add(this.btn_Unzip);
            this.Controls.Add(this.btnZip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btn_Unzip;
        private System.Windows.Forms.Button btn_html;
    }
}

