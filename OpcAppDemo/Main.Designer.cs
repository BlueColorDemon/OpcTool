namespace OpcAppDemo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listboxAlias = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslServerState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslServerStartTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslversion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnInit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnOpcConfig = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnWriteDb = new System.Windows.Forms.Button();
            this.btnReadDb = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWriteTagValue = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.txtTimeStamps = new System.Windows.Forms.TextBox();
            this.txtQualities = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtxtRecord = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtxtRecordDb = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHostName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHostIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opc服务器参数";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(82, 84);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.ReadOnly = true;
            this.txtServerName.Size = new System.Drawing.Size(181, 21);
            this.txtServerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "服务名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(82, 52);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.ReadOnly = true;
            this.txtHostName.Size = new System.Drawing.Size(181, 21);
            this.txtHostName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "主机名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(82, 20);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.ReadOnly = true;
            this.txtHostIP.Size = new System.Drawing.Size(181, 21);
            this.txtHostIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "主机IP：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxAlias);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "变量列表";
            // 
            // listboxAlias
            // 
            this.listboxAlias.BackColor = System.Drawing.Color.White;
            this.listboxAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxAlias.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listboxAlias.ForeColor = System.Drawing.Color.Black;
            this.listboxAlias.FormattingEnabled = true;
            this.listboxAlias.ItemHeight = 12;
            this.listboxAlias.Location = new System.Drawing.Point(3, 17);
            this.listboxAlias.Name = "listboxAlias";
            this.listboxAlias.Size = new System.Drawing.Size(282, 348);
            this.listboxAlias.TabIndex = 1;
            this.listboxAlias.SelectedIndexChanged += new System.EventHandler(this.listboxAlias_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(300, 514);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslServerState,
            this.tsslServerStartTime,
            this.tsslversion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslServerState
            // 
            this.tsslServerState.Name = "tsslServerState";
            this.tsslServerState.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslServerStartTime
            // 
            this.tsslServerStartTime.Name = "tsslServerStartTime";
            this.tsslServerStartTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslversion
            // 
            this.tsslversion.Name = "tsslversion";
            this.tsslversion.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInit,
            this.toolStripSeparator1,
            this.tbtnOpcConfig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnInit
            // 
            this.tbtnInit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnInit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnInit.Image")));
            this.tbtnInit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInit.Name = "tbtnInit";
            this.tbtnInit.Size = new System.Drawing.Size(76, 22);
            this.tbtnInit.Text = "初始化（&I）";
            this.tbtnInit.Click += new System.EventHandler(this.tbtnInit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnOpcConfig
            // 
            this.tbtnOpcConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnOpcConfig.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpcConfig.Image")));
            this.tbtnOpcConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpcConfig.Name = "tbtnOpcConfig";
            this.tbtnOpcConfig.Size = new System.Drawing.Size(96, 22);
            this.tbtnOpcConfig.Text = "Opc-配置（&S）";
            this.tbtnOpcConfig.Click += new System.EventHandler(this.tbtnOpcConfig_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(984, 514);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel1.Controls.Add(this.lblState);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer3.Size = new System.Drawing.Size(680, 514);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnWriteDb);
            this.groupBox7.Controls.Add(this.btnReadDb);
            this.groupBox7.Location = new System.Drawing.Point(6, 244);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(189, 100);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "数据库操作";
            // 
            // btnWriteDb
            // 
            this.btnWriteDb.Enabled = false;
            this.btnWriteDb.Location = new System.Drawing.Point(21, 20);
            this.btnWriteDb.Name = "btnWriteDb";
            this.btnWriteDb.Size = new System.Drawing.Size(157, 23);
            this.btnWriteDb.TabIndex = 7;
            this.btnWriteDb.Text = "读取Opc状态入库";
            this.btnWriteDb.UseVisualStyleBackColor = true;
            this.btnWriteDb.Click += new System.EventHandler(this.btnWriteDb_Click);
            // 
            // btnReadDb
            // 
            this.btnReadDb.Enabled = false;
            this.btnReadDb.Location = new System.Drawing.Point(21, 62);
            this.btnReadDb.Name = "btnReadDb";
            this.btnReadDb.Size = new System.Drawing.Size(157, 23);
            this.btnReadDb.TabIndex = 8;
            this.btnReadDb.Text = "查询数据库记录";
            this.btnReadDb.UseVisualStyleBackColor = true;
            this.btnReadDb.Click += new System.EventHandler(this.btnReadDb_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWriteTagValue);
            this.groupBox3.Controls.Add(this.btnWrite);
            this.groupBox3.Location = new System.Drawing.Point(6, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "写入";
            // 
            // txtWriteTagValue
            // 
            this.txtWriteTagValue.Location = new System.Drawing.Point(23, 20);
            this.txtWriteTagValue.Name = "txtWriteTagValue";
            this.txtWriteTagValue.Size = new System.Drawing.Size(157, 21);
            this.txtWriteTagValue.TabIndex = 4;
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(23, 61);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(157, 23);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblState.Location = new System.Drawing.Point(6, 362);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(189, 142);
            this.lblState.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTagValue);
            this.groupBox6.Controls.Add(this.txtTimeStamps);
            this.groupBox6.Controls.Add(this.txtQualities);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(6, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(189, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "当前值";
            // 
            // txtTagValue
            // 
            this.txtTagValue.Location = new System.Drawing.Point(56, 21);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.ReadOnly = true;
            this.txtTagValue.Size = new System.Drawing.Size(124, 21);
            this.txtTagValue.TabIndex = 3;
            // 
            // txtTimeStamps
            // 
            this.txtTimeStamps.Location = new System.Drawing.Point(56, 75);
            this.txtTimeStamps.Name = "txtTimeStamps";
            this.txtTimeStamps.ReadOnly = true;
            this.txtTimeStamps.Size = new System.Drawing.Size(124, 21);
            this.txtTimeStamps.TabIndex = 3;
            // 
            // txtQualities
            // 
            this.txtQualities.Location = new System.Drawing.Point(56, 48);
            this.txtQualities.Name = "txtQualities";
            this.txtQualities.ReadOnly = true;
            this.txtQualities.Size = new System.Drawing.Size(124, 21);
            this.txtQualities.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "时间戳:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "品质:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tag值:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(5, 5);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer4.Size = new System.Drawing.Size(464, 502);
            this.splitContainer4.SplitterDistance = 260;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtRecord);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 260);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "实时记录";
            // 
            // rtxtRecord
            // 
            this.rtxtRecord.BackColor = System.Drawing.Color.Black;
            this.rtxtRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtRecord.ForeColor = System.Drawing.Color.Lime;
            this.rtxtRecord.Location = new System.Drawing.Point(3, 17);
            this.rtxtRecord.Name = "rtxtRecord";
            this.rtxtRecord.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxtRecord.Size = new System.Drawing.Size(458, 240);
            this.rtxtRecord.TabIndex = 1;
            this.rtxtRecord.Text = "";
            this.rtxtRecord.TextChanged += new System.EventHandler(this.rtxtRecord_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtxtRecordDb);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 238);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据库记录";
            // 
            // rtxtRecordDb
            // 
            this.rtxtRecordDb.BackColor = System.Drawing.Color.Black;
            this.rtxtRecordDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtRecordDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtRecordDb.ForeColor = System.Drawing.Color.Lime;
            this.rtxtRecordDb.Location = new System.Drawing.Point(3, 17);
            this.rtxtRecordDb.Name = "rtxtRecordDb";
            this.rtxtRecordDb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxtRecordDb.Size = new System.Drawing.Size(458, 218);
            this.rtxtRecordDb.TabIndex = 1;
            this.rtxtRecordDb.Text = "";
            this.rtxtRecordDb.TextChanged += new System.EventHandler(this.rtxtRecordDb_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opc-控制";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxAlias;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerState;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerStartTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslversion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnInit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnOpcConfig;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnReadDb;
        private System.Windows.Forms.Button btnWriteDb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxtRecord;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtxtRecordDb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTagValue;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWriteTagValue;
        private System.Windows.Forms.TextBox txtTimeStamps;
        private System.Windows.Forms.TextBox txtQualities;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}

