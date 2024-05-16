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
            picBoxKrile = new PictureBox();
            cbBartz = new ComboBox();
            picBoxFaris = new PictureBox();
            picBoxGaluf = new PictureBox();
            picBoxLenna = new PictureBox();
            picBoxBartz = new PictureBox();
            txtLenna = new TextBox();
            txtGaluf = new TextBox();
            txtFaris = new TextBox();
            txtKrile = new TextBox();
            lblBartz = new Label();
            lblLenna = new Label();
            lblGaluf = new Label();
            lblFaris = new Label();
            lblKrile = new Label();
            txtBartz = new TextBox();
            lblCharaNames = new Label();
            btnApply = new Button();
            lblStatus = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnCleanse = new Button();
            tblNpcNames = new TableLayoutPanel();
            cbExdeath = new ComboBox();
            cbGilgamesh = new ComboBox();
            cbTycoon = new ComboBox();
            picBoxExdeath = new PictureBox();
            picBoxGilgamesh = new PictureBox();
            picBoxTycoon = new PictureBox();
            txtGilgamesh = new TextBox();
            txtExdeath = new TextBox();
            lblTycoon = new Label();
            lblGilgamesh = new Label();
            lblExdeath = new Label();
            txtTycoon = new TextBox();
            lblNpcs = new Label();
            flowLayoutPanel1.SuspendLayout();
            tblCharaNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxKrile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFaris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGaluf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLenna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBartz).BeginInit();
            tblNpcNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExdeath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGilgamesh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTycoon).BeginInit();
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
            tblCharaNames.ColumnCount = 4;
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.96154F));
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.03846F));
            tblCharaNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 396F));
            tblCharaNames.Controls.Add(cbKrile, 1, 4);
            tblCharaNames.Controls.Add(cbFaris, 1, 3);
            tblCharaNames.Controls.Add(cbGaluf, 1, 2);
            tblCharaNames.Controls.Add(cbLenna, 1, 1);
            tblCharaNames.Controls.Add(picBoxKrile, 2, 4);
            tblCharaNames.Controls.Add(cbBartz, 1, 0);
            tblCharaNames.Controls.Add(picBoxFaris, 2, 3);
            tblCharaNames.Controls.Add(picBoxGaluf, 2, 2);
            tblCharaNames.Controls.Add(picBoxLenna, 2, 1);
            tblCharaNames.Controls.Add(picBoxBartz, 2, 0);
            tblCharaNames.Controls.Add(txtLenna, 3, 1);
            tblCharaNames.Controls.Add(txtGaluf, 3, 2);
            tblCharaNames.Controls.Add(txtFaris, 3, 3);
            tblCharaNames.Controls.Add(txtKrile, 3, 4);
            tblCharaNames.Controls.Add(lblBartz, 0, 0);
            tblCharaNames.Controls.Add(lblLenna, 0, 1);
            tblCharaNames.Controls.Add(lblGaluf, 0, 2);
            tblCharaNames.Controls.Add(lblFaris, 0, 3);
            tblCharaNames.Controls.Add(lblKrile, 0, 4);
            tblCharaNames.Controls.Add(txtBartz, 3, 0);
            tblCharaNames.Location = new Point(46, 154);
            tblCharaNames.Name = "tblCharaNames";
            tblCharaNames.RowCount = 5;
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6129036F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3870964F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCharaNames.Size = new Size(587, 227);
            tblCharaNames.TabIndex = 12;
            // 
            // cbKrile
            // 
            cbKrile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbKrile.DrawMode = DrawMode.OwnerDrawVariable;
            cbKrile.DropDownWidth = 200;
            cbKrile.FormattingEnabled = true;
            cbKrile.Location = new Point(89, 187);
            cbKrile.Name = "cbKrile";
            cbKrile.Size = new Size(47, 33);
            cbKrile.TabIndex = 19;
            cbKrile.DrawItem += cbDrawCustomItem;
            cbKrile.MeasureItem += cbMeasureCustomItem;
            cbKrile.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbFaris
            // 
            cbFaris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbFaris.DrawMode = DrawMode.OwnerDrawVariable;
            cbFaris.DropDownWidth = 200;
            cbFaris.FormattingEnabled = true;
            cbFaris.Location = new Point(89, 140);
            cbFaris.Name = "cbFaris";
            cbFaris.Size = new Size(47, 33);
            cbFaris.TabIndex = 18;
            cbFaris.DrawItem += cbDrawCustomItem;
            cbFaris.MeasureItem += cbMeasureCustomItem;
            cbFaris.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbGaluf
            // 
            cbGaluf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGaluf.DrawMode = DrawMode.OwnerDrawVariable;
            cbGaluf.DropDownWidth = 200;
            cbGaluf.FormattingEnabled = true;
            cbGaluf.Location = new Point(89, 96);
            cbGaluf.Name = "cbGaluf";
            cbGaluf.Size = new Size(47, 33);
            cbGaluf.TabIndex = 17;
            cbGaluf.DrawItem += cbDrawCustomItem;
            cbGaluf.MeasureItem += cbMeasureCustomItem;
            cbGaluf.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbLenna
            // 
            cbLenna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbLenna.DrawMode = DrawMode.OwnerDrawVariable;
            cbLenna.DropDownWidth = 200;
            cbLenna.FormattingEnabled = true;
            cbLenna.Location = new Point(89, 51);
            cbLenna.Name = "cbLenna";
            cbLenna.Size = new Size(47, 33);
            cbLenna.TabIndex = 16;
            cbLenna.DrawItem += cbDrawCustomItem;
            cbLenna.MeasureItem += cbMeasureCustomItem;
            cbLenna.SelectedIndexChanged += cbSelItemChanged;
            // 
            // picBoxKrile
            // 
            picBoxKrile.Anchor = AnchorStyles.None;
            picBoxKrile.ImageLocation = "";
            picBoxKrile.Location = new Point(142, 187);
            picBoxKrile.Name = "picBoxKrile";
            picBoxKrile.Size = new Size(45, 37);
            picBoxKrile.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxKrile.TabIndex = 17;
            picBoxKrile.TabStop = false;
            // 
            // cbBartz
            // 
            cbBartz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBartz.DrawMode = DrawMode.OwnerDrawVariable;
            cbBartz.DropDownWidth = 200;
            cbBartz.FormattingEnabled = true;
            cbBartz.Location = new Point(89, 3);
            cbBartz.Name = "cbBartz";
            cbBartz.Size = new Size(47, 33);
            cbBartz.TabIndex = 15;
            cbBartz.DrawItem += cbDrawCustomItem;
            cbBartz.MeasureItem += cbMeasureCustomItem;
            cbBartz.SelectedIndexChanged += cbSelItemChanged;
            // 
            // picBoxFaris
            // 
            picBoxFaris.Anchor = AnchorStyles.None;
            picBoxFaris.ImageLocation = "";
            picBoxFaris.Location = new Point(142, 141);
            picBoxFaris.Name = "picBoxFaris";
            picBoxFaris.Size = new Size(45, 38);
            picBoxFaris.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxFaris.TabIndex = 16;
            picBoxFaris.TabStop = false;
            // 
            // picBoxGaluf
            // 
            picBoxGaluf.Anchor = AnchorStyles.None;
            picBoxGaluf.ImageLocation = "";
            picBoxGaluf.Location = new Point(142, 96);
            picBoxGaluf.Name = "picBoxGaluf";
            picBoxGaluf.Size = new Size(45, 38);
            picBoxGaluf.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxGaluf.TabIndex = 15;
            picBoxGaluf.TabStop = false;
            // 
            // picBoxLenna
            // 
            picBoxLenna.Anchor = AnchorStyles.None;
            picBoxLenna.ImageLocation = "";
            picBoxLenna.Location = new Point(142, 51);
            picBoxLenna.Name = "picBoxLenna";
            picBoxLenna.Size = new Size(45, 39);
            picBoxLenna.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxLenna.TabIndex = 14;
            picBoxLenna.TabStop = false;
            // 
            // picBoxBartz
            // 
            picBoxBartz.Anchor = AnchorStyles.None;
            picBoxBartz.ImageLocation = "";
            picBoxBartz.Location = new Point(142, 3);
            picBoxBartz.Name = "picBoxBartz";
            picBoxBartz.Size = new Size(45, 42);
            picBoxBartz.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxBartz.TabIndex = 13;
            picBoxBartz.TabStop = false;
            // 
            // txtLenna
            // 
            txtLenna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLenna.Location = new Point(193, 51);
            txtLenna.Name = "txtLenna";
            txtLenna.Size = new Size(391, 32);
            txtLenna.TabIndex = 15;
            txtLenna.Text = "Lenna";
            txtLenna.TextChanged += txtLenna_TextChanged;
            // 
            // txtGaluf
            // 
            txtGaluf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGaluf.Location = new Point(193, 96);
            txtGaluf.Name = "txtGaluf";
            txtGaluf.Size = new Size(391, 32);
            txtGaluf.TabIndex = 17;
            txtGaluf.Text = "Galuf";
            txtGaluf.TextChanged += txtGaluf_TextChanged;
            // 
            // txtFaris
            // 
            txtFaris.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFaris.Location = new Point(193, 140);
            txtFaris.Name = "txtFaris";
            txtFaris.Size = new Size(391, 32);
            txtFaris.TabIndex = 19;
            txtFaris.Text = "Faris";
            txtFaris.TextChanged += txtFaris_TextChanged;
            // 
            // txtKrile
            // 
            txtKrile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtKrile.Location = new Point(193, 187);
            txtKrile.Name = "txtKrile";
            txtKrile.Size = new Size(391, 32);
            txtKrile.TabIndex = 21;
            txtKrile.Text = "Krile";
            txtKrile.TextChanged += txtKrile_TextChanged;
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
            lblGaluf.Location = new Point(3, 103);
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
            lblFaris.Location = new Point(3, 147);
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
            lblKrile.Location = new Point(3, 194);
            lblKrile.Margin = new Padding(3, 10, 3, 0);
            lblKrile.Name = "lblKrile";
            lblKrile.Size = new Size(55, 25);
            lblKrile.TabIndex = 20;
            lblKrile.Text = "Krile";
            // 
            // txtBartz
            // 
            txtBartz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBartz.Location = new Point(193, 3);
            txtBartz.Name = "txtBartz";
            txtBartz.Size = new Size(391, 32);
            txtBartz.TabIndex = 13;
            txtBartz.Text = "Bartz";
            txtBartz.TextChanged += txtBartz_TextChanged;
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
            tblNpcNames.ColumnCount = 4;
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.96154F));
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.03846F));
            tblNpcNames.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 344F));
            tblNpcNames.Controls.Add(cbExdeath, 1, 2);
            tblNpcNames.Controls.Add(cbGilgamesh, 1, 1);
            tblNpcNames.Controls.Add(cbTycoon, 1, 0);
            tblNpcNames.Controls.Add(picBoxExdeath, 2, 2);
            tblNpcNames.Controls.Add(picBoxGilgamesh, 2, 1);
            tblNpcNames.Controls.Add(picBoxTycoon, 2, 0);
            tblNpcNames.Controls.Add(txtGilgamesh, 3, 1);
            tblNpcNames.Controls.Add(txtExdeath, 3, 2);
            tblNpcNames.Controls.Add(lblTycoon, 0, 0);
            tblNpcNames.Controls.Add(lblGilgamesh, 0, 1);
            tblNpcNames.Controls.Add(lblExdeath, 0, 2);
            tblNpcNames.Controls.Add(txtTycoon, 3, 0);
            tblNpcNames.Location = new Point(725, 154);
            tblNpcNames.Name = "tblNpcNames";
            tblNpcNames.RowCount = 5;
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6129036F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3870964F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblNpcNames.Size = new Size(587, 227);
            tblNpcNames.TabIndex = 101;
            // 
            // cbExdeath
            // 
            cbExdeath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbExdeath.DrawMode = DrawMode.OwnerDrawVariable;
            cbExdeath.DropDownWidth = 200;
            cbExdeath.FormattingEnabled = true;
            cbExdeath.Location = new Point(142, 96);
            cbExdeath.Name = "cbExdeath";
            cbExdeath.Size = new Size(47, 33);
            cbExdeath.TabIndex = 17;
            cbExdeath.DrawItem += cbDrawCustomItem;
            cbExdeath.MeasureItem += cbMeasureCustomItem;
            cbExdeath.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbGilgamesh
            // 
            cbGilgamesh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGilgamesh.DrawMode = DrawMode.OwnerDrawVariable;
            cbGilgamesh.DropDownWidth = 200;
            cbGilgamesh.FormattingEnabled = true;
            cbGilgamesh.Location = new Point(142, 51);
            cbGilgamesh.Name = "cbGilgamesh";
            cbGilgamesh.Size = new Size(47, 33);
            cbGilgamesh.TabIndex = 16;
            cbGilgamesh.DrawItem += cbDrawCustomItem;
            cbGilgamesh.MeasureItem += cbMeasureCustomItem;
            cbGilgamesh.SelectedIndexChanged += cbSelItemChanged;
            // 
            // cbTycoon
            // 
            cbTycoon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTycoon.DrawMode = DrawMode.OwnerDrawVariable;
            cbTycoon.DropDownWidth = 200;
            cbTycoon.FormattingEnabled = true;
            cbTycoon.Location = new Point(142, 3);
            cbTycoon.Name = "cbTycoon";
            cbTycoon.Size = new Size(47, 33);
            cbTycoon.TabIndex = 15;
            cbTycoon.DrawItem += cbDrawCustomItem;
            cbTycoon.MeasureItem += cbMeasureCustomItem;
            cbTycoon.SelectedIndexChanged += cbSelItemChanged;
            // 
            // picBoxExdeath
            // 
            picBoxExdeath.Anchor = AnchorStyles.None;
            picBoxExdeath.ImageLocation = "";
            picBoxExdeath.Location = new Point(195, 96);
            picBoxExdeath.Name = "picBoxExdeath";
            picBoxExdeath.Size = new Size(45, 38);
            picBoxExdeath.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxExdeath.TabIndex = 15;
            picBoxExdeath.TabStop = false;
            // 
            // picBoxGilgamesh
            // 
            picBoxGilgamesh.Anchor = AnchorStyles.None;
            picBoxGilgamesh.ImageLocation = "";
            picBoxGilgamesh.Location = new Point(195, 51);
            picBoxGilgamesh.Name = "picBoxGilgamesh";
            picBoxGilgamesh.Size = new Size(45, 39);
            picBoxGilgamesh.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxGilgamesh.TabIndex = 14;
            picBoxGilgamesh.TabStop = false;
            // 
            // picBoxTycoon
            // 
            picBoxTycoon.Anchor = AnchorStyles.None;
            picBoxTycoon.ImageLocation = "";
            picBoxTycoon.Location = new Point(195, 3);
            picBoxTycoon.Name = "picBoxTycoon";
            picBoxTycoon.Size = new Size(45, 42);
            picBoxTycoon.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxTycoon.TabIndex = 13;
            picBoxTycoon.TabStop = false;
            // 
            // txtGilgamesh
            // 
            txtGilgamesh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGilgamesh.Location = new Point(246, 51);
            txtGilgamesh.Name = "txtGilgamesh";
            txtGilgamesh.Size = new Size(338, 32);
            txtGilgamesh.TabIndex = 15;
            txtGilgamesh.Text = "Gilgamesh";
            txtGilgamesh.TextChanged += txtGilgamesh_TextChanged;
            // 
            // txtExdeath
            // 
            txtExdeath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtExdeath.Location = new Point(246, 96);
            txtExdeath.Name = "txtExdeath";
            txtExdeath.Size = new Size(338, 32);
            txtExdeath.TabIndex = 17;
            txtExdeath.Text = "Exdeath";
            txtExdeath.TextChanged += txtExdeath_TextChanged;
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
            lblGilgamesh.Location = new Point(3, 58);
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
            lblExdeath.Location = new Point(3, 103);
            lblExdeath.Margin = new Padding(3, 10, 3, 0);
            lblExdeath.Name = "lblExdeath";
            lblExdeath.Size = new Size(90, 25);
            lblExdeath.TabIndex = 16;
            lblExdeath.Text = "Exdeath";
            // 
            // txtTycoon
            // 
            txtTycoon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTycoon.Location = new Point(246, 3);
            txtTycoon.Name = "txtTycoon";
            txtTycoon.Size = new Size(338, 32);
            txtTycoon.TabIndex = 13;
            txtTycoon.Text = "King Tycoon";
            txtTycoon.TextChanged += txtTycoon_TextChanged;
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
            ((System.ComponentModel.ISupportInitialize)picBoxKrile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxFaris).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGaluf).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLenna).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBartz).EndInit();
            tblNpcNames.ResumeLayout(false);
            tblNpcNames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExdeath).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGilgamesh).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxTycoon).EndInit();
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
        private TextBox txtBartz;
        private TextBox txtLenna;
        private Label lblLenna;
        private TextBox txtFaris;
        private Label lblFaris;
        private TextBox txtGaluf;
        private Label lblGaluf;
        private Label lblKrile;
        private TextBox txtKrile;
        private PictureBox picBoxBartz;
        private PictureBox picBoxKrile;
        private PictureBox picBoxFaris;
        private PictureBox picBoxGaluf;
        private PictureBox picBoxLenna;
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
        private PictureBox picBoxTycoon;
        private PictureBox picBoxGilgamesh;
        private PictureBox picBoxExdeath;
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
    }
}
