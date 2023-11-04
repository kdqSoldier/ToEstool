

namespace ToEstool
{
    partial class ToEstool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToEstool));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTM = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_xls = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_xlsx = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_csv = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfileTM_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.computeTM = new System.Windows.Forms.ToolStripMenuItem();
            this.computemTM_Indirect = new System.Windows.Forms.ToolStripMenuItem();
            this.computemTM_IGG3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_readdata = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer_one = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer_two = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel_observation = new System.Windows.Forms.TableLayoutPanel();
            this.label_observation = new System.Windows.Forms.Label();
            this.dataGridView_observation = new System.Windows.Forms.DataGridView();
            this.splitContainer_three = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel_knuowpoint = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_knowpoint = new System.Windows.Forms.DataGridView();
            this.label_knoepoint = new System.Windows.Forms.Label();
            this.tableLayoutPanel_estimated = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_estimated = new System.Windows.Forms.DataGridView();
            this.label_estimated = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.全局参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_one)).BeginInit();
            this.splitContainer_one.Panel1.SuspendLayout();
            this.splitContainer_one.Panel2.SuspendLayout();
            this.splitContainer_one.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_two)).BeginInit();
            this.splitContainer_two.Panel1.SuspendLayout();
            this.splitContainer_two.Panel2.SuspendLayout();
            this.splitContainer_two.SuspendLayout();
            this.tableLayoutPanel_observation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_observation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_three)).BeginInit();
            this.splitContainer_three.Panel1.SuspendLayout();
            this.splitContainer_three.Panel2.SuspendLayout();
            this.splitContainer_three.SuspendLayout();
            this.tableLayoutPanel_knuowpoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_knowpoint)).BeginInit();
            this.tableLayoutPanel_estimated.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_estimated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 12F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTM,
            this.computeTM,
            this.全局参数设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTM
            // 
            this.fileTM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputfileTM});
            this.fileTM.Font = new System.Drawing.Font("宋体", 12F);
            this.fileTM.Name = "fileTM";
            this.fileTM.Size = new System.Drawing.Size(70, 28);
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
            this.inputfileTM.Size = new System.Drawing.Size(188, 30);
            this.inputfileTM.Text = "导入数据";
            // 
            // inputfileTM_xls
            // 
            this.inputfileTM_xls.Name = "inputfileTM_xls";
            this.inputfileTM_xls.Size = new System.Drawing.Size(200, 30);
            this.inputfileTM_xls.Text = ".xls文件";
            this.inputfileTM_xls.Click += new System.EventHandler(this.InputfileTM_xls_Click);
            // 
            // inputfileTM_xlsx
            // 
            this.inputfileTM_xlsx.Name = "inputfileTM_xlsx";
            this.inputfileTM_xlsx.Size = new System.Drawing.Size(200, 30);
            this.inputfileTM_xlsx.Text = ".xlsx文件";
            this.inputfileTM_xlsx.Click += new System.EventHandler(this.inputfileTM_xlsx_Click);
            // 
            // inputfileTM_csv
            // 
            this.inputfileTM_csv.Name = "inputfileTM_csv";
            this.inputfileTM_csv.Size = new System.Drawing.Size(200, 30);
            this.inputfileTM_csv.Text = ".csv文件";
            this.inputfileTM_csv.Click += new System.EventHandler(this.inputfileTM_csv_Click);
            // 
            // inputfileTM_txt
            // 
            this.inputfileTM_txt.Name = "inputfileTM_txt";
            this.inputfileTM_txt.Size = new System.Drawing.Size(200, 30);
            this.inputfileTM_txt.Text = "文本文件";
            this.inputfileTM_txt.Click += new System.EventHandler(this.inputfileTM_txt_Click);
            // 
            // computeTM
            // 
            this.computeTM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computemTM_Indirect,
            this.computemTM_IGG3});
            this.computeTM.Font = new System.Drawing.Font("宋体", 12F);
            this.computeTM.Name = "computeTM";
            this.computeTM.Size = new System.Drawing.Size(70, 28);
            this.computeTM.Text = "平差";
            // 
            // computemTM_Indirect
            // 
            this.computemTM_Indirect.Name = "computemTM_Indirect";
            this.computemTM_Indirect.Size = new System.Drawing.Size(248, 30);
            this.computemTM_Indirect.Text = "间接平差";
            this.computemTM_Indirect.Click += new System.EventHandler(this.computemTM_Indirect_Click);
            // 
            // computemTM_IGG3
            // 
            this.computemTM_IGG3.Name = "computemTM_IGG3";
            this.computemTM_IGG3.Size = new System.Drawing.Size(248, 30);
            this.computemTM_IGG3.Text = "抗差估计-IGG3";
            this.computemTM_IGG3.Click += new System.EventHandler(this.computemTM_IGG3_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_path.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox_path.Location = new System.Drawing.Point(86, 3);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(1287, 37);
            this.textBox_path.TabIndex = 13;
            // 
            // button_readdata
            // 
            this.button_readdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_readdata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_readdata.Font = new System.Drawing.Font("宋体", 13F);
            this.button_readdata.Location = new System.Drawing.Point(1398, 4);
            this.button_readdata.Margin = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.button_readdata.Name = "button_readdata";
            this.button_readdata.Size = new System.Drawing.Size(165, 36);
            this.button_readdata.TabIndex = 4;
            this.button_readdata.Text = "读取数据";
            this.button_readdata.UseVisualStyleBackColor = false;
            this.button_readdata.Click += new System.EventHandler(this.button_readdata_Click);
            // 
            // splitContainer_one
            // 
            this.splitContainer_one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_one.Location = new System.Drawing.Point(0, 32);
            this.splitContainer_one.Name = "splitContainer_one";
            this.splitContainer_one.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_one.Panel1
            // 
            this.splitContainer_one.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer_one.Panel2
            // 
            this.splitContainer_one.Panel2.Controls.Add(this.splitContainer_two);
            this.splitContainer_one.Size = new System.Drawing.Size(1578, 765);
            this.splitContainer_one.SplitterDistance = 44;
            this.splitContainer_one.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.004448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.99555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_readdata, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_path, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1578, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer_two
            // 
            this.splitContainer_two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_two.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_two.Name = "splitContainer_two";
            // 
            // splitContainer_two.Panel1
            // 
            this.splitContainer_two.Panel1.Controls.Add(this.tableLayoutPanel_observation);
            // 
            // splitContainer_two.Panel2
            // 
            this.splitContainer_two.Panel2.Controls.Add(this.splitContainer_three);
            this.splitContainer_two.Size = new System.Drawing.Size(1578, 717);
            this.splitContainer_two.SplitterDistance = 977;
            this.splitContainer_two.TabIndex = 0;
            // 
            // tableLayoutPanel_observation
            // 
            this.tableLayoutPanel_observation.ColumnCount = 1;
            this.tableLayoutPanel_observation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_observation.Controls.Add(this.label_observation, 0, 0);
            this.tableLayoutPanel_observation.Controls.Add(this.dataGridView_observation, 0, 1);
            this.tableLayoutPanel_observation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_observation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_observation.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tableLayoutPanel_observation.Name = "tableLayoutPanel_observation";
            this.tableLayoutPanel_observation.RowCount = 2;
            this.tableLayoutPanel_observation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.751804F));
            this.tableLayoutPanel_observation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.2482F));
            this.tableLayoutPanel_observation.Size = new System.Drawing.Size(977, 717);
            this.tableLayoutPanel_observation.TabIndex = 0;
            // 
            // label_observation
            // 
            this.label_observation.AutoSize = true;
            this.label_observation.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_observation.Font = new System.Drawing.Font("宋体", 13F);
            this.label_observation.Location = new System.Drawing.Point(15, 0);
            this.label_observation.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label_observation.Name = "label_observation";
            this.label_observation.Size = new System.Drawing.Size(116, 26);
            this.label_observation.TabIndex = 0;
            this.label_observation.Text = "观测数据";
            // 
            // dataGridView_observation
            // 
            this.dataGridView_observation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_observation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_observation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_observation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_observation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_observation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_observation.Font = new System.Drawing.Font("宋体", 13F);
            this.dataGridView_observation.Location = new System.Drawing.Point(10, 29);
            this.dataGridView_observation.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.dataGridView_observation.Name = "dataGridView_observation";
            this.dataGridView_observation.RowTemplate.Height = 30;
            this.dataGridView_observation.Size = new System.Drawing.Size(964, 678);
            this.dataGridView_observation.TabIndex = 1;
            // 
            // splitContainer_three
            // 
            this.splitContainer_three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_three.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_three.Name = "splitContainer_three";
            this.splitContainer_three.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_three.Panel1
            // 
            this.splitContainer_three.Panel1.Controls.Add(this.tableLayoutPanel_knuowpoint);
            // 
            // splitContainer_three.Panel2
            // 
            this.splitContainer_three.Panel2.Controls.Add(this.tableLayoutPanel_estimated);
            this.splitContainer_three.Size = new System.Drawing.Size(597, 717);
            this.splitContainer_three.SplitterDistance = 321;
            this.splitContainer_three.TabIndex = 0;
            // 
            // tableLayoutPanel_knuowpoint
            // 
            this.tableLayoutPanel_knuowpoint.ColumnCount = 1;
            this.tableLayoutPanel_knuowpoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_knuowpoint.Controls.Add(this.dataGridView_knowpoint, 0, 1);
            this.tableLayoutPanel_knuowpoint.Controls.Add(this.label_knoepoint, 0, 0);
            this.tableLayoutPanel_knuowpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_knuowpoint.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_knuowpoint.Name = "tableLayoutPanel_knuowpoint";
            this.tableLayoutPanel_knuowpoint.RowCount = 2;
            this.tableLayoutPanel_knuowpoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.280254F));
            this.tableLayoutPanel_knuowpoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.71974F));
            this.tableLayoutPanel_knuowpoint.Size = new System.Drawing.Size(597, 321);
            this.tableLayoutPanel_knuowpoint.TabIndex = 0;
            // 
            // dataGridView_knowpoint
            // 
            this.dataGridView_knowpoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_knowpoint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_knowpoint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_knowpoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_knowpoint.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_knowpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_knowpoint.Font = new System.Drawing.Font("宋体", 13F);
            this.dataGridView_knowpoint.Location = new System.Drawing.Point(3, 29);
            this.dataGridView_knowpoint.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.dataGridView_knowpoint.Name = "dataGridView_knowpoint";
            this.dataGridView_knowpoint.RowTemplate.Height = 30;
            this.dataGridView_knowpoint.Size = new System.Drawing.Size(584, 289);
            this.dataGridView_knowpoint.TabIndex = 2;
            // 
            // label_knoepoint
            // 
            this.label_knoepoint.AutoSize = true;
            this.label_knoepoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_knoepoint.Font = new System.Drawing.Font("宋体", 13F);
            this.label_knoepoint.Location = new System.Drawing.Point(15, 0);
            this.label_knoepoint.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label_knoepoint.Name = "label_knoepoint";
            this.label_knoepoint.Size = new System.Drawing.Size(90, 26);
            this.label_knoepoint.TabIndex = 1;
            this.label_knoepoint.Text = "已知点";
            // 
            // tableLayoutPanel_estimated
            // 
            this.tableLayoutPanel_estimated.ColumnCount = 1;
            this.tableLayoutPanel_estimated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_estimated.Controls.Add(this.dataGridView_estimated, 0, 1);
            this.tableLayoutPanel_estimated.Controls.Add(this.label_estimated, 0, 0);
            this.tableLayoutPanel_estimated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_estimated.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_estimated.Name = "tableLayoutPanel_estimated";
            this.tableLayoutPanel_estimated.RowCount = 2;
            this.tableLayoutPanel_estimated.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.933333F));
            this.tableLayoutPanel_estimated.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.06667F));
            this.tableLayoutPanel_estimated.Size = new System.Drawing.Size(597, 392);
            this.tableLayoutPanel_estimated.TabIndex = 0;
            // 
            // dataGridView_estimated
            // 
            this.dataGridView_estimated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_estimated.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_estimated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_estimated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_estimated.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_estimated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_estimated.Font = new System.Drawing.Font("宋体", 13F);
            this.dataGridView_estimated.Location = new System.Drawing.Point(3, 30);
            this.dataGridView_estimated.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.dataGridView_estimated.Name = "dataGridView_estimated";
            this.dataGridView_estimated.RowTemplate.Height = 30;
            this.dataGridView_estimated.Size = new System.Drawing.Size(584, 352);
            this.dataGridView_estimated.TabIndex = 3;
            // 
            // label_estimated
            // 
            this.label_estimated.AutoSize = true;
            this.label_estimated.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_estimated.Font = new System.Drawing.Font("宋体", 13F);
            this.label_estimated.Location = new System.Drawing.Point(15, 0);
            this.label_estimated.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label_estimated.Name = "label_estimated";
            this.label_estimated.Size = new System.Drawing.Size(142, 27);
            this.label_estimated.TabIndex = 2;
            this.label_estimated.Text = "未知点估值";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // 全局参数设置ToolStripMenuItem
            // 
            this.全局参数设置ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F);
            this.全局参数设置ToolStripMenuItem.Name = "全局参数设置ToolStripMenuItem";
            this.全局参数设置ToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.全局参数设置ToolStripMenuItem.Text = "全局参数设置";
            this.全局参数设置ToolStripMenuItem.Click += new System.EventHandler(this.全局参数设置ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::ToEstool.Properties.Resources.ToEstool;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 36);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ToEstool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 797);
            this.Controls.Add(this.splitContainer_one);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToEstool";
            this.Text = "ToEstool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer_one.Panel1.ResumeLayout(false);
            this.splitContainer_one.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_one)).EndInit();
            this.splitContainer_one.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer_two.Panel1.ResumeLayout(false);
            this.splitContainer_two.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_two)).EndInit();
            this.splitContainer_two.ResumeLayout(false);
            this.tableLayoutPanel_observation.ResumeLayout(false);
            this.tableLayoutPanel_observation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_observation)).EndInit();
            this.splitContainer_three.Panel1.ResumeLayout(false);
            this.splitContainer_three.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_three)).EndInit();
            this.splitContainer_three.ResumeLayout(false);
            this.tableLayoutPanel_knuowpoint.ResumeLayout(false);
            this.tableLayoutPanel_knuowpoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_knowpoint)).EndInit();
            this.tableLayoutPanel_estimated.ResumeLayout(false);
            this.tableLayoutPanel_estimated.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_estimated)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer_one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer_two;
        private System.Windows.Forms.ToolStripMenuItem computeTM;
        private System.Windows.Forms.ToolStripMenuItem computemTM_Indirect;
        private System.Windows.Forms.ToolStripMenuItem computemTM_IGG3;
        private System.Windows.Forms.SplitContainer splitContainer_three;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_observation;
        private System.Windows.Forms.Label label_observation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_knuowpoint;
        private System.Windows.Forms.Label label_knoepoint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_estimated;
        private System.Windows.Forms.Label label_estimated;
        private System.Windows.Forms.DataGridView dataGridView_observation;
        private System.Windows.Forms.DataGridView dataGridView_knowpoint;
        private System.Windows.Forms.DataGridView dataGridView_estimated;
        private System.Windows.Forms.ToolStripMenuItem 全局参数设置ToolStripMenuItem;
    }
}