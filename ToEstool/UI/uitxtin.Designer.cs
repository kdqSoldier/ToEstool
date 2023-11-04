namespace ToEstool.UI
{
    partial class uitxtin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uitxtin));
            this.comboBox_splitstr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_true = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_splitstr
            // 
            this.comboBox_splitstr.Font = new System.Drawing.Font("宋体", 13F);
            this.comboBox_splitstr.FormattingEnabled = true;
            this.comboBox_splitstr.Location = new System.Drawing.Point(145, 31);
            this.comboBox_splitstr.Name = "comboBox_splitstr";
            this.comboBox_splitstr.Size = new System.Drawing.Size(207, 34);
            this.comboBox_splitstr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "分隔符：";
            // 
            // button_true
            // 
            this.button_true.Font = new System.Drawing.Font("宋体", 13F);
            this.button_true.Location = new System.Drawing.Point(257, 139);
            this.button_true.Name = "button_true";
            this.button_true.Size = new System.Drawing.Size(95, 40);
            this.button_true.TabIndex = 2;
            this.button_true.Text = "确定";
            this.button_true.UseVisualStyleBackColor = true;
            this.button_true.Click += new System.EventHandler(this.button_true_Click);
            // 
            // uitxtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 213);
            this.Controls.Add(this.button_true);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_splitstr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uitxtin";
            this.Text = "选择分隔符";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_splitstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_true;
    }
}