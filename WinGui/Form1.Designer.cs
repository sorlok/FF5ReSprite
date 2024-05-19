namespace WinGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtSteamDir = new TextBox();
            btnChoose = new Button();
            lblSteam = new Label();
            lblDirections = new Label();
            chkBepIn = new CheckBox();
            chkConfig = new CheckBox();
            chkMagicite = new CheckBox();
            chkExport = new CheckBox();
            chkValidDir = new CheckBox();
            lblDirLbl = new Label();
            btnDoStuff = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tblCharaNames = new TableLayoutPanel();
            cbKrile = new ComboBox();
            cbFaris = new ComboBox();
            cbGaluf = new ComboBox();
            cbLenna = new ComboBox();
            cbBartz = new ComboBox();
            lblBartz = new Label();
            lblLenna = new Label();
            lblGaluf = new Label();
            lblFaris = new Label();
            lblKrile = new Label();
            txtBartz = new TextBox();
            txtLenna = new TextBox();
            txtGaluf = new TextBox();
            txtFaris = new TextBox();
            txtKrile = new TextBox();
            lblCharaNames = new Label();
            btnApply = new Button();
            lblStatus = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnCleanse = new Button();
            tblNpcNames = new TableLayoutPanel();
            cbExdeath = new ComboBox();
            cbGilgamesh = new ComboBox();
            cbTycoon = new ComboBox();
            lblTycoon = new Label();
            lblGilgamesh = new Label();
            lblExdeath = new Label();
            txtTycoon = new TextBox();
            txtGilgamesh = new TextBox();
            txtExdeath = new TextBox();
            lblNpcs = new Label();
            flowLayoutPanel1.SuspendLayout();
            tblCharaNames.SuspendLayout();
            tblNpcNames.SuspendLayout();
            SuspendLayout();
            // 
            // txtSteamDir
            // 
            txtSteamDir.Enabled = false;
            txtSteamDir.Location = new Point(219, 14);
            txtSteamDir.Margin = new Padding(5);
            txtSteamDir.Name = "txtSteamDir";
            txtSteamDir.Size = new Size(247, 32);
            txtSteamDir.TabIndex = 0;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(476, 11);
            btnChoose.Margin = new Padding(5);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(128, 36);
            btnChoose.TabIndex = 1;
            btnChoose.TabStop = false;
            btnChoose.Text = "Choose...";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // lblSteam
            // 
            lblSteam.AutoSize = true;
            lblSteam.Location = new Point(12, 17);
            lblSteam.Name = "lblSteam";
            lblSteam.Size = new Size(199, 24);
            lblSteam.TabIndex = 2;
            lblSteam.Text = "FF5 (Steam) Folder:";
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Location = new Point(196, 10);
            lblDirections.Margin = new Padding(3, 10, 3, 0);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(176, 24);
            lblDirections.TabIndex = 3;
            lblDirections.Text = "TODO: Directions";
            // 
            // chkBepIn
            // 
            chkBepIn.AutoCheck = false;
            chkBepIn.AutoSize = true;
            chkBepIn.Checked = true;
            chkBepIn.CheckState = CheckState.Checked;
            chkBepIn.Location = new Point(830, 17);
            chkBepIn.Name = "chkBepIn";
            chkBepIn.Size = new Size(107, 28);
            chkBepIn.TabIndex = 4;
            chkBepIn.TabStop = false;
            chkBepIn.Text = "BepInEx";
            chkBepIn.UseVisualStyleBackColor = true;
            // 
            // chkConfig
            // 
            chkConfig.AutoCheck = false;
            chkConfig.AutoSize = true;
            chkConfig.Checked = true;
            chkConfig.CheckState = CheckState.Checked;
            chkConfig.Location = new Point(957, 17);
            chkConfig.Name = "chkConfig";
            chkConfig.Size = new Size(116, 28);
            chkConfig.TabIndex = 5;
            chkConfig.TabStop = false;
            chkConfig.Text = "ConfigDir";
            chkConfig.UseVisualStyleBackColor = true;
            // 
            // chkMagicite
            // 
            chkMagicite.AutoCheck = false;
            chkMagicite.AutoSize = true;
            chkMagicite.Checked = true;
            chkMagicite.CheckState = CheckState.Checked;
            chkMagicite.Location = new Point(1088, 17);
            chkMagicite.Name = "chkMagicite";
            chkMagicite.Size = new Size(108, 28);
            chkMagicite.TabIndex = 6;
            chkMagicite.TabStop = false;
            chkMagicite.Text = "Magicite";
            chkMagicite.UseVisualStyleBackColor = true;
            // 
            // chkExport
            // 
            chkExport.AutoCheck = false;
            chkExport.AutoSize = true;
            chkExport.Checked = true;
            chkExport.CheckState = CheckState.Checked;
            chkExport.Location = new Point(1202, 17);
            chkExport.Name = "chkExport";
            chkExport.Size = new Size(89, 28);
            chkExport.TabIndex = 7;
            chkExport.TabStop = false;
            chkExport.Text = "Export";
            chkExport.UseVisualStyleBackColor = true;
            // 
            // chkValidDir
            // 
            chkValidDir.AutoCheck = false;
            chkValidDir.AutoSize = true;
            chkValidDir.Checked = true;
            chkValidDir.CheckState = CheckState.Checked;
            chkValidDir.Location = new Point(693, 17);
            chkValidDir.Name = "chkValidDir";
            chkValidDir.Size = new Size(131, 28);
            chkValidDir.TabIndex = 8;
            chkValidDir.TabStop = false;
            chkValidDir.Text = "ValidFolder";
            chkValidDir.UseVisualStyleBackColor = true;
            // 
            // lblDirLbl
            // 
            lblDirLbl.AutoSize = true;
            lblDirLbl.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDirLbl.Location = new Point(3, 10);
            lblDirLbl.Margin = new Padding(3, 10, 3, 0);
            lblDirLbl.Name = "lblDirLbl";
            lblDirLbl.Size = new Size(187, 24);
            lblDirLbl.TabIndex = 9;
            lblDirLbl.Text = "ACTION NEEDED:";
            // 
            // btnDoStuff
            // 
            btnDoStuff.BackColor = Color.Yellow;
            btnDoStuff.ForeColor = Color.Red;
            btnDoStuff.Location = new Point(380, 5);
            btnDoStuff.Margin = new Padding(5);
            btnDoStuff.Name = "btnDoStuff";
            btnDoStuff.Size = new Size(210, 36);
            btnDoStuff.TabIndex = 10;
            btnDoStuff.Text = "Install BepInEx";
            btnDoStuff.UseVisualStyleBackColor = false;
            btnDoStuff.Click += btnDoStuff_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblDirLbl);
            flowLayoutPanel1.Controls.Add(lblDirections);
            flowLayoutPanel1.Controls.Add(btnDoStuff);
            flowLayoutPanel1.Location = new Point(12, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1361, 47);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // tblCharaNames
            // 
            tblCharaNames.ColumnCount = 3;
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.57485F));
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.42515F));
            tblCharaNames.Controls.Add(cbKrile, 1, 4);
            tblCharaNames.Controls.Add(cbFaris, 1, 3);
            tblCharaNames.Controls.Add(cbGaluf, 1, 2);
            tblCharaNames.Controls.Add(cbLenna, 1, 1);
            tblCharaNames.Controls.Add(cbBartz, 1, 0);
            tblCharaNames.Controls.Add(lblBartz, 0, 0);
            tblCharaNames.Controls.Add(lblLenna, 0, 1);
            tblCharaNames.Controls.Add(lblGaluf, 0, 2);
            tblCharaNames.Controls.Add(lblFaris, 0, 3);
            tblCharaNames.Controls.Add(lblKrile, 0, 4);
            tblCharaNames.Controls.Add(txtBartz, 2, 0);
            tblCharaNames.Controls.Add(txtLenna, 2, 1);
            tblCharaNames.Controls.Add(txtGaluf, 2, 2);
            tblCharaNames.Controls.Add(txtFaris, 2, 3);
            tblCharaNames.Controls.Add(txtKrile, 2, 4);
            tblCharaNames.Location = new Point(46, 154);
            tblCharaNames.Name = "tblCharaNames";
            tblCharaNames.RowCount = 5;
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.Size = new Size(587, 242);
            tblCharaNames.TabIndex = 12;
            // 
            // cbKrile
            // 
            cbKrile.DrawMode = DrawMode.OwnerDrawVariable;
            cbKrile.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKrile.DropDownWidth = 200;
            cbKrile.FormattingEnabled = true;
            cbKrile.ItemHeight = 38;
            cbKrile.Location = new Point(89, 194);
            cbKrile.Name = "cbKrile";
            cbKrile.Size = new Size(50, 44);
            cbKrile.TabIndex = 19;
            cbKrile.DrawItem += cbDrawCustomItem;
            cbKrile.MeasureItem += cbMeasureCustomItem;
            cbKrile.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbFaris
            // 
            cbFaris.DrawMode = DrawMode.OwnerDrawVariable;
            cbFaris.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaris.DropDownWidth = 200;
            cbFaris.FormattingEnabled = true;
            cbFaris.ItemHeight = 38;
            cbFaris.Location = new Point(89, 147);
            cbFaris.Name = "cbFaris";
            cbFaris.Size = new Size(50, 44);
            cbFaris.TabIndex = 18;
            cbFaris.DrawItem += cbDrawCustomItem;
            cbFaris.MeasureItem += cbMeasureCustomItem;
            cbFaris.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbGaluf
            // 
            cbGaluf.DrawMode = DrawMode.OwnerDrawVariable;
            cbGaluf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGaluf.DropDownWidth = 200;
            cbGaluf.FormattingEnabled = true;
            cbGaluf.ItemHeight = 38;
            cbGaluf.Location = new Point(89, 99);
            cbGaluf.Name = "cbGaluf";
            cbGaluf.Size = new Size(50, 44);
            cbGaluf.TabIndex = 17;
            cbGaluf.DrawItem += cbDrawCustomItem;
            cbGaluf.MeasureItem += cbMeasureCustomItem;
            cbGaluf.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbLenna
            // 
            cbLenna.DrawMode = DrawMode.OwnerDrawVariable;
            cbLenna.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLenna.DropDownWidth = 200;
            cbLenna.FormattingEnabled = true;
            cbLenna.ItemHeight = 38;
            cbLenna.Location = new Point(89, 51);
            cbLenna.Name = "cbLenna";
            cbLenna.Size = new Size(50, 44);
            cbLenna.TabIndex = 16;
            cbLenna.DrawItem += cbDrawCustomItem;
            cbLenna.MeasureItem += cbMeasureCustomItem;
            cbLenna.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbBartz
            // 
            cbBartz.DrawMode = DrawMode.OwnerDrawVariable;
            cbBartz.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBartz.DropDownWidth = 200;
            cbBartz.FormattingEnabled = true;
            cbBartz.ItemHeight = 38;
            cbBartz.Location = new Point(89, 3);
            cbBartz.Name = "cbBartz";
            cbBartz.Size = new Size(50, 44);
            cbBartz.TabIndex = 15;
            cbBartz.DrawItem += cbDrawCustomItem;
            cbBartz.MeasureItem += cbMeasureCustomItem;
            cbBartz.SelectedIndexChanged += cbSelItemChanged;
            // 
            // lblBartz
            // 
            lblBartz.AutoSize = true;
            lblBartz.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBartz.Location = new Point(3, 10);
            lblBartz.Margin = new Padding(3, 10, 3, 0);
            lblBartz.Name = "lblBartz";
            lblBartz.Size = new Size(63, 25);
            lblBartz.TabIndex = 12;
            lblBartz.Text = "Bartz";
            // 
            // lblLenna
            // 
            lblLenna.AutoSize = true;
            lblLenna.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLenna.Location = new Point(3, 58);
            lblLenna.Margin = new Padding(3, 10, 3, 0);
            lblLenna.Name = "lblLenna";
            lblLenna.Size = new Size(70, 25);
            lblLenna.TabIndex = 14;
            lblLenna.Text = "Lenna";
            // 
            // lblGaluf
            // 
            lblGaluf.AutoSize = true;
            lblGaluf.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGaluf.Location = new Point(3, 106);
            lblGaluf.Margin = new Padding(3, 10, 3, 0);
            lblGaluf.Name = "lblGaluf";
            lblGaluf.Size = new Size(63, 25);
            lblGaluf.TabIndex = 16;
            lblGaluf.Text = "Galuf";
            // 
            // lblFaris
            // 
            lblFaris.AutoSize = true;
            lblFaris.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaris.Location = new Point(3, 154);
            lblFaris.Margin = new Padding(3, 10, 3, 0);
            lblFaris.Name = "lblFaris";
            lblFaris.Size = new Size(60, 25);
            lblFaris.TabIndex = 18;
            lblFaris.Text = "Faris";
            // 
            // lblKrile
            // 
            lblKrile.AutoSize = true;
            lblKrile.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKrile.Location = new Point(3, 201);
            lblKrile.Margin = new Padding(3, 10, 3, 0);
            lblKrile.Name = "lblKrile";
            lblKrile.Size = new Size(55, 25);
            lblKrile.TabIndex = 20;
            lblKrile.Text = "Krile";
            // 
            // txtBartz
            // 
            txtBartz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBartz.Location = new Point(152, 3);
            txtBartz.Name = "txtBartz";
            txtBartz.Size = new Size(432, 32);
            txtBartz.TabIndex = 13;
            txtBartz.Text = "Bartz";
            txtBartz.TextChanged += txtBartz_TextChanged;
            // 
            // txtLenna
            // 
            txtLenna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLenna.Location = new Point(152, 51);
            txtLenna.Name = "txtLenna";
            txtLenna.Size = new Size(432, 32);
            txtLenna.TabIndex = 15;
            txtLenna.Text = "Lenna";
            txtLenna.TextChanged += txtLenna_TextChanged;
            // 
            // txtGaluf
            // 
            txtGaluf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGaluf.Location = new Point(152, 99);
            txtGaluf.Name = "txtGaluf";
            txtGaluf.Size = new Size(432, 32);
            txtGaluf.TabIndex = 17;
            txtGaluf.Text = "Galuf";
            txtGaluf.TextChanged += txtGaluf_TextChanged;
            // 
            // txtFaris
            // 
            txtFaris.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFaris.Location = new Point(152, 147);
            txtFaris.Name = "txtFaris";
            txtFaris.Size = new Size(432, 32);
            txtFaris.TabIndex = 19;
            txtFaris.Text = "Faris";
            txtFaris.TextChanged += txtFaris_TextChanged;
            // 
            // txtKrile
            // 
            txtKrile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtKrile.Location = new Point(152, 194);
            txtKrile.Name = "txtKrile";
            txtKrile.Size = new Size(432, 32);
            txtKrile.TabIndex = 21;
            txtKrile.Text = "Krile";
            txtKrile.TextChanged += txtKrile_TextChanged;
            // 
            // lblCharaNames
            // 
            lblCharaNames.AutoSize = true;
            lblCharaNames.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharaNames.Location = new Point(46, 127);
            lblCharaNames.Margin = new Padding(3, 10, 3, 0);
            lblCharaNames.Name = "lblCharaNames";
            lblCharaNames.Size = new Size(282, 24);
            lblCharaNames.TabIndex = 11;
            lblCharaNames.Text = "Character Names && Sprites";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(513, 428);
            btnApply.Margin = new Padding(5);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(348, 93);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply Changes";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(114, 553);
            lblStatus.Margin = new Padding(3, 10, 3, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1135, 63);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status Update:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnCleanse
            // 
            btnCleanse.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCleanse.Location = new Point(871, 485);
            btnCleanse.Margin = new Padding(5);
            btnCleanse.Name = "btnCleanse";
            btnCleanse.Size = new Size(128, 36);
            btnCleanse.TabIndex = 99;
            btnCleanse.TabStop = false;
            btnCleanse.Text = "(Cleanse)";
            btnCleanse.UseVisualStyleBackColor = true;
            btnCleanse.Click += btnCleanse_Click;
            // 
            // tblNpcNames
            // 
            tblNpcNames.ColumnCount = 3;
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8392859F));
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.16071F));
            tblNpcNames.Controls.Add(cbExdeath, 1, 2);
            tblNpcNames.Controls.Add(cbGilgamesh, 1, 1);
            tblNpcNames.Controls.Add(cbTycoon, 1, 0);
            tblNpcNames.Controls.Add(lblTycoon, 0, 0);
            tblNpcNames.Controls.Add(lblGilgamesh, 0, 1);
            tblNpcNames.Controls.Add(lblExdeath, 0, 2);
            tblNpcNames.Controls.Add(txtTycoon, 2, 0);
            tblNpcNames.Controls.Add(txtGilgamesh, 2, 1);
            tblNpcNames.Controls.Add(txtExdeath, 2, 2);
            tblNpcNames.Location = new Point(725, 154);
            tblNpcNames.Name = "tblNpcNames";
            tblNpcNames.RowCount = 5;
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.Size = new Size(587, 242);
            tblNpcNames.TabIndex = 101;
            // 
            // cbExdeath
            // 
            cbExdeath.DrawMode = DrawMode.OwnerDrawVariable;
            cbExdeath.DropDownStyle = ComboBoxStyle.DropDownList;
            cbExdeath.DropDownWidth = 200;
            cbExdeath.FormattingEnabled = true;
            cbExdeath.ItemHeight = 38;
            cbExdeath.Location = new Point(142, 103);
            cbExdeath.Name = "cbExdeath";
            cbExdeath.Size = new Size(50, 44);
            cbExdeath.TabIndex = 17;
            cbExdeath.DrawItem += cbDrawCustomItem;
            cbExdeath.MeasureItem += cbMeasureCustomItem;
            cbExdeath.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbGilgamesh
            // 
            cbGilgamesh.DrawMode = DrawMode.OwnerDrawVariable;
            cbGilgamesh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGilgamesh.DropDownWidth = 200;
            cbGilgamesh.FormattingEnabled = true;
            cbGilgamesh.ItemHeight = 38;
            cbGilgamesh.Location = new Point(142, 52);
            cbGilgamesh.Name = "cbGilgamesh";
            cbGilgamesh.Size = new Size(50, 44);
            cbGilgamesh.TabIndex = 16;
            cbGilgamesh.DrawItem += cbDrawCustomItem;
            cbGilgamesh.MeasureItem += cbMeasureCustomItem;
            cbGilgamesh.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbTycoon
            // 
            cbTycoon.DrawMode = DrawMode.OwnerDrawVariable;
            cbTycoon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTycoon.DropDownWidth = 200;
            cbTycoon.FormattingEnabled = true;
            cbTycoon.ItemHeight = 38;
            cbTycoon.Location = new Point(142, 3);
            cbTycoon.Name = "cbTycoon";
            cbTycoon.Size = new Size(50, 44);
            cbTycoon.TabIndex = 15;
            cbTycoon.DrawItem += cbDrawCustomItem;
            cbTycoon.MeasureItem += cbMeasureCustomItem;
            cbTycoon.SelectedIndexChanged += cbSelItemChanged;
            // 
            // lblTycoon
            // 
            lblTycoon.AutoSize = true;
            lblTycoon.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTycoon.Location = new Point(3, 10);
            lblTycoon.Margin = new Padding(3, 10, 3, 0);
            lblTycoon.Name = "lblTycoon";
            lblTycoon.Size = new Size(133, 25);
            lblTycoon.TabIndex = 12;
            lblTycoon.Text = "King Tycoon";
            // 
            // lblGilgamesh
            // 
            lblGilgamesh.AutoSize = true;
            lblGilgamesh.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGilgamesh.Location = new Point(3, 59);
            lblGilgamesh.Margin = new Padding(3, 10, 3, 0);
            lblGilgamesh.Name = "lblGilgamesh";
            lblGilgamesh.Size = new Size(114, 25);
            lblGilgamesh.TabIndex = 14;
            lblGilgamesh.Text = "Gilgamesh";
            // 
            // lblExdeath
            // 
            lblExdeath.AutoSize = true;
            lblExdeath.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExdeath.Location = new Point(3, 110);
            lblExdeath.Margin = new Padding(3, 10, 3, 0);
            lblExdeath.Name = "lblExdeath";
            lblExdeath.Size = new Size(90, 25);
            lblExdeath.TabIndex = 16;
            lblExdeath.Text = "Exdeath";
            // 
            // txtTycoon
            // 
            txtTycoon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTycoon.Location = new Point(204, 3);
            txtTycoon.Name = "txtTycoon";
            txtTycoon.Size = new Size(380, 32);
            txtTycoon.TabIndex = 13;
            txtTycoon.Text = "King Tycoon";
            txtTycoon.TextChanged += txtTycoon_TextChanged;
            // 
            // txtGilgamesh
            // 
            txtGilgamesh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGilgamesh.Location = new Point(204, 52);
            txtGilgamesh.Name = "txtGilgamesh";
            txtGilgamesh.Size = new Size(380, 32);
            txtGilgamesh.TabIndex = 15;
            txtGilgamesh.Text = "Gilgamesh";
            txtGilgamesh.TextChanged += txtGilgamesh_TextChanged;
            // 
            // txtExdeath
            // 
            txtExdeath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtExdeath.Location = new Point(204, 103);
            txtExdeath.Name = "txtExdeath";
            txtExdeath.Size = new Size(380, 32);
            txtExdeath.TabIndex = 17;
            txtExdeath.Text = "Exdeath";
            txtExdeath.TextChanged += txtExdeath_TextChanged;
            // 
            // lblNpcs
            // 
            lblNpcs.AutoSize = true;
            lblNpcs.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNpcs.Location = new Point(725, 127);
            lblNpcs.Margin = new Padding(3, 10, 3, 0);
            lblNpcs.Name = "lblNpcs";
            lblNpcs.Size = new Size(226, 24);
            lblNpcs.TabIndex = 100;
            lblNpcs.Text = "NPC Names && Sprites";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 720);
            Controls.Add(tblNpcNames);
            Controls.Add(lblNpcs);
            Controls.Add(lblStatus);
            Controls.Add(btnApply);
            Controls.Add(btnCleanse);
            Controls.Add(tblCharaNames);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chkValidDir);
            Controls.Add(lblCharaNames);
            Controls.Add(chkExport);
            Controls.Add(chkMagicite);
            Controls.Add(chkConfig);
            Controls.Add(chkBepIn);
            Controls.Add(lblSteam);
            Controls.Add(btnChoose);
            Controls.Add(txtSteamDir);
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "FF5 WGRPGui";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tblCharaNames.ResumeLayout(false);
            tblCharaNames.PerformLayout();
            tblNpcNames.ResumeLayout(false);
            tblNpcNames.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSteamDir;
        private Button btnChoose;
        private Label lblSteam;
        private Label lblDirections;
        private CheckBox chkBepIn;
        private CheckBox chkConfig;
        private CheckBox chkMagicite;
        private CheckBox chkExport;
        private CheckBox chkValidDir;
        private Label lblDirLbl;
        private Button btnDoStuff;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tblCharaNames;
        private Label lblCharaNames;
        private Label lblBartz;
        private Label lblLenna;
        private Label lblFaris;
        private Label lblGaluf;
        private Label lblKrile;
        private Button btnApply;
        private Label lblStatus;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cbBartz;
        private ComboBox cbKrile;
        private ComboBox cbFaris;
        private ComboBox cbGaluf;
        private ComboBox cbLenna;
        private Button btnCleanse;
        private TableLayoutPanel tblNpcNames;
        private ComboBox cbTycoon;
        private ComboBox cbGilgamesh;
        private ComboBox cbExdeath;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
        private ComboBox comboBox5;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblTycoon;
        private Label lblGilgamesh;
        private Label lblExdeath;
        private TextBox txtGilgamesh;
        private TextBox txtExdeath;
        private Label lblOther1;
        private Label label5;
        private TextBox txtTycoon;
        private Label lblNpcs;
        private TextBox txtBartz;
        private TextBox txtLenna;
        private TextBox txtGaluf;
        private TextBox txtFaris;
        private TextBox txtKrile;
    }
}
