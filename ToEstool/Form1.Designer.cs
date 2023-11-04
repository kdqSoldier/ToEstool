namespace ToEstool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTM = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_xls = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_xlsx = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_csv = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_readdata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTM
            // 
            this.fileTM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputfileTM});
            this.fileTM.Font = new System.Drawing.Font("宋体", 11F);
            this.fileTM.Name = "fileTM";
            this.fileTM.Size = new System.Drawing.Size(66, 26);
            this.fileTM.Text = "文件";
            // 
            // inputfileTM
            // 
            this.inputfileTM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputfileTM_xls,
            this.inputfileTM_xlsx,
            this.inputfileTM_csv,
            this.inputfileTM_txt});
            this.inputfileTM.Name = "inputfileTM";
            this.inputfileTM.Size = new System.Drawing.Size(180, 30);
            this.inputfileTM.Text = "导入数据";
            // 
            // inputfileTM_xls
            // 
            this.inputfileTM_xls.Name = "inputfileTM_xls";
            this.inputfileTM_xls.Size = new System.Drawing.Size(191, 30);
            this.inputfileTM_xls.Text = ".xls文件";
            // 
            // inputfileTM_xlsx
            // 
            this.inputfileTM_xlsx.Name = "inputfileTM_xlsx";
            this.inputfileTM_xlsx.Size = new System.Drawing.Size(191, 30);
            this.inputfileTM_xlsx.Text = ".xlsx文件";
            // 
            // inputfileTM_csv
            // 
            this.inputfileTM_csv.Name = "inputfileTM_csv";
            this.inputfileTM_csv.Size = new System.Drawing.Size(191, 30);
            this.inputfileTM_csv.Text = ".csv文件";
            // 
            // inputfileTM_txt
            // 
            this.inputfileTM_txt.Name = "inputfileTM_txt";
            this.inputfileTM_txt.Size = new System.Drawing.Size(191, 30);
            this.inputfileTM_txt.Text = "文本文件";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ToEstool.Properties.Resources.ToEstool;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_path
            // 
            this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_path.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox_path.Location = new System.Drawing.Point(100, 49);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(1278, 37);
            this.textBox_path.TabIndex = 13;
            // 
            // button_readdata
            // 
            this.button_readdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_readdata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_readdata.Font = new System.Drawing.Font("宋体", 13F);
            this.button_readdata.Location = new System.Drawing.Point(1400, 51);
            this.button_readdata.Margin = new System.Windows.Forms.Padding(4);
            this.button_readdata.Name = "button_readdata";
            this.button_readdata.Size = new System.Drawing.Size(150, 35);
            this.button_readdata.TabIndex = 4;
            this.button_readdata.Text = "读取数据";
            this.button_readdata.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "观测数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 797);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_readdata);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTM;
        private System.Windows.Forms.ToolStripMenuItem inputfileTM;
        private System.Windows.Forms.ToolStripMenuItem inputfileTM_xls;
        private System.Windows.Forms.ToolStripMenuItem inputfileTM_xlsx;
        private System.Windows.Forms.ToolStripMenuItem inputfileTM_csv;
        private System.Windows.Forms.ToolStripMenuItem inputfileTM_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_readdata;
        private System.Windows.Forms.Label label1;
    }
}

