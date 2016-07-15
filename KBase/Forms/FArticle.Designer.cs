namespace KBase.View.Forms
{
    partial class FArticle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FArticle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKArea = new System.Windows.Forms.ComboBox();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRoot = new System.Windows.Forms.FlowLayoutPanel();
            this.llKArea = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.llTheme = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.llTitle = new System.Windows.Forms.LinkLabel();
            this.btnSaveArticle = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTags = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.tcContent = new System.Windows.Forms.TabControl();
            this.tpAddNew = new System.Windows.Forms.TabPage();
            this.cmsMenuTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstbManageTags = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiInsertTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbInsertTags = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsContentType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tscbContentType = new System.Windows.Forms.ToolStripComboBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpRoot.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpTags.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.tcContent.SuspendLayout();
            this.cmsMenuTags.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.cmsContentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbDescription, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescription
            // 
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(84, 3);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(696, 20);
            this.tbDescription.TabIndex = 1;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Location = new System.Drawing.Point(533, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 45);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbTheme, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(253, 26);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Theme:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTheme
            // 
            this.cbTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(58, 3);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(192, 21);
            this.cbTheme.TabIndex = 1;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(268, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbKArea, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 26);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Knowledge Area:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbKArea
            // 
            this.cbKArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKArea.FormattingEnabled = true;
            this.cbKArea.Location = new System.Drawing.Point(112, 3);
            this.cbKArea.Name = "cbKArea";
            this.cbKArea.Size = new System.Drawing.Size(138, 21);
            this.cbKArea.TabIndex = 1;
            this.cbKArea.SelectedIndexChanged += new System.EventHandler(this.cbKArea_SelectedIndexChanged);
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.tableLayoutPanel1);
            this.gbTitle.Location = new System.Drawing.Point(3, 3);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(259, 45);
            this.gbTitle.TabIndex = 1;
            this.gbTitle.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Location = new System.Drawing.Point(45, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(205, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flpRoot
            // 
            this.flpRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRoot.AutoSize = true;
            this.flpRoot.Controls.Add(this.llKArea);
            this.flpRoot.Controls.Add(this.label6);
            this.flpRoot.Controls.Add(this.llTheme);
            this.flpRoot.Controls.Add(this.label7);
            this.flpRoot.Controls.Add(this.llTitle);
            this.flpRoot.Controls.Add(this.btnSaveArticle);
            this.flpRoot.Controls.Add(this.lbMessage);
            this.flpRoot.Location = new System.Drawing.Point(3, 3);
            this.flpRoot.Name = "flpRoot";
            this.flpRoot.Size = new System.Drawing.Size(1088, 29);
            this.flpRoot.TabIndex = 5;
            // 
            // llKArea
            // 
            this.llKArea.AutoSize = true;
            this.llKArea.Location = new System.Drawing.Point(3, 0);
            this.llKArea.Name = "llKArea";
            this.llKArea.Size = new System.Drawing.Size(0, 13);
            this.llKArea.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "/";
            // 
            // llTheme
            // 
            this.llTheme.AutoSize = true;
            this.llTheme.Location = new System.Drawing.Point(27, 0);
            this.llTheme.Name = "llTheme";
            this.llTheme.Size = new System.Drawing.Size(0, 13);
            this.llTheme.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "/";
            // 
            // llTitle
            // 
            this.llTitle.AutoSize = true;
            this.llTitle.Location = new System.Drawing.Point(51, 0);
            this.llTitle.Name = "llTitle";
            this.llTitle.Size = new System.Drawing.Size(0, 13);
            this.llTitle.TabIndex = 2;
            // 
            // btnSaveArticle
            // 
            this.btnSaveArticle.BackgroundImage = global::KBase.View.Properties.Resources.floppyImg;
            this.btnSaveArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveArticle.Location = new System.Drawing.Point(57, 3);
            this.btnSaveArticle.Name = "btnSaveArticle";
            this.btnSaveArticle.Size = new System.Drawing.Size(23, 23);
            this.btnSaveArticle.TabIndex = 1;
            this.btnSaveArticle.UseVisualStyleBackColor = true;
            this.btnSaveArticle.Click += new System.EventHandler(this.btnSaveArticle_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.gbTitle);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox4);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1088, 104);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // flpTags
            // 
            this.flpTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTags.AutoSize = true;
            this.flpTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTags.Controls.Add(this.btnAddTag);
            this.flpTags.Location = new System.Drawing.Point(3, 148);
            this.flpTags.Name = "flpTags";
            this.flpTags.Size = new System.Drawing.Size(1088, 29);
            this.flpTags.TabIndex = 7;
            // 
            // btnAddTag
            // 
            this.btnAddTag.BackgroundImage = global::KBase.View.Properties.Resources.plusImg;
            this.btnAddTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTag.Location = new System.Drawing.Point(3, 3);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(23, 23);
            this.btnAddTag.TabIndex = 0;
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // gbContent
            // 
            this.gbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContent.Controls.Add(this.tcContent);
            this.gbContent.Location = new System.Drawing.Point(3, 183);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(1088, 302);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            // 
            // tcContent
            // 
            this.tcContent.Controls.Add(this.tpAddNew);
            this.tcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcContent.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcContent.Location = new System.Drawing.Point(3, 16);
            this.tcContent.Name = "tcContent";
            this.tcContent.Padding = new System.Drawing.Point(12, 4);
            this.tcContent.SelectedIndex = 0;
            this.tcContent.Size = new System.Drawing.Size(1082, 283);
            this.tcContent.TabIndex = 0;
            this.tcContent.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcContent_DrawItem);
            this.tcContent.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcContent_Selecting);
            this.tcContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tcContent_MouseDoubleClick);
            this.tcContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcContent_MouseDown);
            // 
            // tpAddNew
            // 
            this.tpAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddNew.Location = new System.Drawing.Point(4, 24);
            this.tpAddNew.Name = "tpAddNew";
            this.tpAddNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNew.Size = new System.Drawing.Size(1074, 255);
            this.tpAddNew.TabIndex = 0;
            this.tpAddNew.Text = "+";
            this.tpAddNew.UseVisualStyleBackColor = true;
            // 
            // cmsMenuTags
            // 
            this.cmsMenuTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbManageTags,
            this.tsmiInsertTags});
            this.cmsMenuTags.Name = "cmsMenuTags";
            this.cmsMenuTags.Size = new System.Drawing.Size(161, 51);
            // 
            // tstbManageTags
            // 
            this.tstbManageTags.Name = "tstbManageTags";
            this.tstbManageTags.ReadOnly = true;
            this.tstbManageTags.Size = new System.Drawing.Size(100, 23);
            this.tstbManageTags.Text = "Manage Tags...";
            this.tstbManageTags.ToolTipText = "Add, Remove, Modify Tags";
            this.tstbManageTags.Click += new System.EventHandler(this.tstbManageTags_Click);
            // 
            // tsmiInsertTags
            // 
            this.tsmiInsertTags.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbInsertTags});
            this.tsmiInsertTags.Name = "tsmiInsertTags";
            this.tsmiInsertTags.Size = new System.Drawing.Size(160, 22);
            this.tsmiInsertTags.Text = "Insert Tags";
            // 
            // tscbInsertTags
            // 
            this.tscbInsertTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbInsertTags.Name = "tscbInsertTags";
            this.tscbInsertTags.Size = new System.Drawing.Size(121, 23);
            this.tscbInsertTags.SelectedIndexChanged += new System.EventHandler(this.tscbInsertTags_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.flpTags, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.gbContent, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.flpRoot, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1094, 472);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cmsContentType
            // 
            this.cmsContentType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbContentType});
            this.cmsContentType.Name = "cmsMenuTags";
            this.cmsContentType.Size = new System.Drawing.Size(182, 31);
            // 
            // tscbContentType
            // 
            this.tscbContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbContentType.Name = "tscbContentType";
            this.tscbContentType.Size = new System.Drawing.Size(121, 23);
            this.tscbContentType.SelectedIndexChanged += new System.EventHandler(this.tscbContentType_SelectedIndexChanged);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(86, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 13);
            this.lbMessage.TabIndex = 7;
            // 
            // FArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 472);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FArticle";
            this.Text = "Article";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpRoot.ResumeLayout(false);
            this.flpRoot.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpTags.ResumeLayout(false);
            this.gbContent.ResumeLayout(false);
            this.tcContent.ResumeLayout(false);
            this.cmsMenuTags.ResumeLayout(false);
            this.cmsMenuTags.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.cmsContentType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKArea;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpRoot;
        private System.Windows.Forms.LinkLabel llKArea;
        private System.Windows.Forms.LinkLabel llTheme;
        private System.Windows.Forms.LinkLabel llTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flpTags;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.ContextMenuStrip cmsMenuTags;
        private System.Windows.Forms.ToolStripTextBox tstbManageTags;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTags;
        private System.Windows.Forms.ToolStripComboBox tscbInsertTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveArticle;
        private System.Windows.Forms.TabControl tcContent;
        private System.Windows.Forms.TabPage tpAddNew;
        private System.Windows.Forms.ContextMenuStrip cmsContentType;
        private System.Windows.Forms.ToolStripComboBox tscbContentType;
        private System.Windows.Forms.Label lbMessage;
    }
}