namespace Client_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChatDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFullWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHowToUse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.virtualForms = new Client_GUI.VirtualForm();
            this.virtualDisconnected = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.virtualConnected = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChatHeader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLoggedAs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbMessagesDisplayer = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMessageContent = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewConnectedUsers = new System.Windows.Forms.ListView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblPictureAdded = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.picBoxPictureAdded = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblPrivateTo = new System.Windows.Forms.Label();
            this.comboBoxPrivateTo = new System.Windows.Forms.ComboBox();
            this.radioBtnPublic = new System.Windows.Forms.RadioButton();
            this.radioBtnPrivate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.virtualForms.SuspendLayout();
            this.virtualDisconnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.virtualConnected.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChatHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPictureAdded)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogInOut,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuLogInOut
            // 
            this.menuLogInOut.Image = global::Client_GUI.Properties.Resources.feed;
            this.menuLogInOut.Name = "menuLogInOut";
            this.menuLogInOut.Size = new System.Drawing.Size(116, 22);
            this.menuLogInOut.Text = "Log in...";
            this.menuLogInOut.Click += new System.EventHandler(this.menuLogInOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::Client_GUI.Properties.Resources.close3;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(116, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChatDetails,
            this.toolStripSeparator1,
            this.menuFullWindow});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuChatDetails
            // 
            this.menuChatDetails.Enabled = false;
            this.menuChatDetails.Image = global::Client_GUI.Properties.Resources.network;
            this.menuChatDetails.Name = "menuChatDetails";
            this.menuChatDetails.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuChatDetails.Size = new System.Drawing.Size(165, 22);
            this.menuChatDetails.Text = "Chat Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // menuFullWindow
            // 
            this.menuFullWindow.Image = global::Client_GUI.Properties.Resources.fullscreen;
            this.menuFullWindow.Name = "menuFullWindow";
            this.menuFullWindow.ShortcutKeyDisplayString = "";
            this.menuFullWindow.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuFullWindow.Size = new System.Drawing.Size(165, 22);
            this.menuFullWindow.Text = "Full Window";
            this.menuFullWindow.Click += new System.EventHandler(this.menuFullWindow_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHowToUse,
            this.toolStripSeparator3,
            this.menuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuItemHowToUse
            // 
            this.menuItemHowToUse.Image = global::Client_GUI.Properties.Resources.question4;
            this.menuItemHowToUse.Name = "menuItemHowToUse";
            this.menuItemHowToUse.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuItemHowToUse.Size = new System.Drawing.Size(154, 22);
            this.menuItemHowToUse.Text = "How to Use";
            this.menuItemHowToUse.Click += new System.EventHandler(this.menuItemHowToUse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Image = global::Client_GUI.Properties.Resources.info2;
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(154, 22);
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            this.fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.gif)|*.jpg; *.jpeg; *.png; *.bmp; *.g" +
    "if";
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // virtualForms
            // 
            this.virtualForms.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.virtualForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualForms.Controls.Add(this.virtualDisconnected);
            this.virtualForms.Controls.Add(this.virtualConnected);
            this.virtualForms.Location = new System.Drawing.Point(0, 27);
            this.virtualForms.Multiline = true;
            this.virtualForms.Name = "virtualForms";
            this.virtualForms.SelectedIndex = 0;
            this.virtualForms.Size = new System.Drawing.Size(784, 538);
            this.virtualForms.TabIndex = 0;
            // 
            // virtualDisconnected
            // 
            this.virtualDisconnected.BackColor = System.Drawing.Color.White;
            this.virtualDisconnected.BackgroundImage = global::Client_GUI.Properties.Resources.backgroundChat;
            this.virtualDisconnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.virtualDisconnected.Controls.Add(this.btnStart);
            this.virtualDisconnected.Controls.Add(this.pictureBox1);
            this.virtualDisconnected.Location = new System.Drawing.Point(4, 4);
            this.virtualDisconnected.Name = "virtualDisconnected";
            this.virtualDisconnected.Padding = new System.Windows.Forms.Padding(3);
            this.virtualDisconnected.Size = new System.Drawing.Size(776, 512);
            this.virtualDisconnected.TabIndex = 0;
            this.virtualDisconnected.Text = "(Virtual) Disconnected";
            this.virtualDisconnected.Enter += new System.EventHandler(this.virtualDisconnected_Enter);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.Salmon;
            this.btnStart.Location = new System.Drawing.Point(295, 357);
            this.btnStart.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 40);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start to Chat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(163, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // virtualConnected
            // 
            this.virtualConnected.BackColor = System.Drawing.SystemColors.Control;
            this.virtualConnected.BackgroundImage = global::Client_GUI.Properties.Resources.backgroundChat;
            this.virtualConnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.virtualConnected.Controls.Add(this.panel5);
            this.virtualConnected.Controls.Add(this.panel4);
            this.virtualConnected.Location = new System.Drawing.Point(4, 4);
            this.virtualConnected.Name = "virtualConnected";
            this.virtualConnected.Padding = new System.Windows.Forms.Padding(3);
            this.virtualConnected.Size = new System.Drawing.Size(776, 512);
            this.virtualConnected.TabIndex = 1;
            this.virtualConnected.Text = "(Virtual) Connected";
            this.virtualConnected.Enter += new System.EventHandler(this.virtualConnected_Enter);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(217, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 456);
            this.panel5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelChatHeader);
            this.panel1.Controls.Add(this.rtbMessagesDisplayer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 415);
            this.panel1.TabIndex = 0;
            // 
            // panelChatHeader
            // 
            this.panelChatHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChatHeader.BackColor = System.Drawing.Color.Silver;
            this.panelChatHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChatHeader.Controls.Add(this.panel7);
            this.panelChatHeader.Location = new System.Drawing.Point(5, 9);
            this.panelChatHeader.Name = "panelChatHeader";
            this.panelChatHeader.Size = new System.Drawing.Size(540, 34);
            this.panelChatHeader.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.btnLoggedAs);
            this.panel7.Controls.Add(this.btnExit);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(532, 26);
            this.panel7.TabIndex = 3;
            // 
            // btnLoggedAs
            // 
            this.btnLoggedAs.BackColor = System.Drawing.Color.Transparent;
            this.btnLoggedAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoggedAs.FlatAppearance.BorderSize = 0;
            this.btnLoggedAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoggedAs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLoggedAs.Image = global::Client_GUI.Properties.Resources.arrow_right11;
            this.btnLoggedAs.Location = new System.Drawing.Point(0, 0);
            this.btnLoggedAs.Name = "btnLoggedAs";
            this.btnLoggedAs.Size = new System.Drawing.Size(472, 26);
            this.btnLoggedAs.TabIndex = 4;
            this.btnLoggedAs.TabStop = false;
            this.btnLoggedAs.Text = "Logged as: ";
            this.btnLoggedAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoggedAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoggedAs.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Image = global::Client_GUI.Properties.Resources.close31;
            this.btnExit.Location = new System.Drawing.Point(472, 0);
            this.btnExit.MaximumSize = new System.Drawing.Size(60, 26);
            this.btnExit.MinimumSize = new System.Drawing.Size(60, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(60, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbMessagesDisplayer
            // 
            this.rtbMessagesDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessagesDisplayer.BackColor = System.Drawing.SystemColors.Window;
            this.rtbMessagesDisplayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMessagesDisplayer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbMessagesDisplayer.Location = new System.Drawing.Point(5, 49);
            this.rtbMessagesDisplayer.Name = "rtbMessagesDisplayer";
            this.rtbMessagesDisplayer.ReadOnly = true;
            this.rtbMessagesDisplayer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessagesDisplayer.Size = new System.Drawing.Size(540, 361);
            this.rtbMessagesDisplayer.TabIndex = 1;
            this.rtbMessagesDisplayer.TabStop = false;
            this.rtbMessagesDisplayer.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtMessageContent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 423);
            this.panel3.MaximumSize = new System.Drawing.Size(3000, 33);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 33);
            this.panel3.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(460, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 33);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Client_GUI.Properties.Resources.arrowRight11;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.AcceptsReturn = true;
            this.txtMessageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageContent.Font = new System.Drawing.Font("Arial", 11F);
            this.txtMessageContent.Location = new System.Drawing.Point(37, 5);
            this.txtMessageContent.Multiline = true;
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.Size = new System.Drawing.Size(415, 24);
            this.txtMessageContent.TabIndex = 0;
            this.txtMessageContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessageContent_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(10, 28);
            this.panel4.MaximumSize = new System.Drawing.Size(190, 2000);
            this.panel4.MinimumSize = new System.Drawing.Size(190, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 456);
            this.panel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.splitContainer1);
            this.panel8.Location = new System.Drawing.Point(0, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 407);
            this.panel8.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewConnectedUsers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(190, 407);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // listViewConnectedUsers
            // 
            this.listViewConnectedUsers.BackColor = System.Drawing.Color.White;
            this.listViewConnectedUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewConnectedUsers.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewConnectedUsers.FullRowSelect = true;
            this.listViewConnectedUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewConnectedUsers.Name = "listViewConnectedUsers";
            this.listViewConnectedUsers.Size = new System.Drawing.Size(190, 213);
            this.listViewConnectedUsers.TabIndex = 3;
            this.listViewConnectedUsers.TabStop = false;
            this.listViewConnectedUsers.UseCompatibleStateImageBehavior = false;
            this.listViewConnectedUsers.View = System.Windows.Forms.View.List;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.GhostWhite;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.splitContainer2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 190);
            this.panel6.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel1.Controls.Add(this.lblPictureAdded);
            this.splitContainer2.Panel1.Controls.Add(this.panel9);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.lblPrivateTo);
            this.splitContainer2.Panel2.Controls.Add(this.comboBoxPrivateTo);
            this.splitContainer2.Panel2.Controls.Add(this.radioBtnPublic);
            this.splitContainer2.Panel2.Controls.Add(this.radioBtnPrivate);
            this.splitContainer2.Size = new System.Drawing.Size(188, 188);
            this.splitContainer2.SplitterDistance = 101;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // lblPictureAdded
            // 
            this.lblPictureAdded.AutoSize = true;
            this.lblPictureAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblPictureAdded.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPictureAdded.ForeColor = System.Drawing.Color.Black;
            this.lblPictureAdded.Location = new System.Drawing.Point(14, 51);
            this.lblPictureAdded.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPictureAdded.Name = "lblPictureAdded";
            this.lblPictureAdded.Size = new System.Drawing.Size(73, 32);
            this.lblPictureAdded.TabIndex = 6;
            this.lblPictureAdded.Text = "   Image attached!";
            this.lblPictureAdded.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnRemoveImage);
            this.panel9.Controls.Add(this.picBoxPictureAdded);
            this.panel9.Location = new System.Drawing.Point(99, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(78, 82);
            this.panel9.TabIndex = 5;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveImage.BackColor = System.Drawing.Color.Red;
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(56, 3);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(17, 17);
            this.btnRemoveImage.TabIndex = 6;
            this.btnRemoveImage.Text = "X";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // picBoxPictureAdded
            // 
            this.picBoxPictureAdded.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBoxPictureAdded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxPictureAdded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPictureAdded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxPictureAdded.Location = new System.Drawing.Point(0, 0);
            this.picBoxPictureAdded.Name = "picBoxPictureAdded";
            this.picBoxPictureAdded.Size = new System.Drawing.Size(76, 80);
            this.picBoxPictureAdded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPictureAdded.TabIndex = 5;
            this.picBoxPictureAdded.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddImage.Location = new System.Drawing.Point(7, 10);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(87, 34);
            this.btnAddImage.TabIndex = 4;
            this.btnAddImage.Text = "Add image...";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblPrivateTo
            // 
            this.lblPrivateTo.AutoSize = true;
            this.lblPrivateTo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPrivateTo.Location = new System.Drawing.Point(75, 49);
            this.lblPrivateTo.Name = "lblPrivateTo";
            this.lblPrivateTo.Size = new System.Drawing.Size(23, 13);
            this.lblPrivateTo.TabIndex = 3;
            this.lblPrivateTo.Text = "To:";
            // 
            // comboBoxPrivateTo
            // 
            this.comboBoxPrivateTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivateTo.Enabled = false;
            this.comboBoxPrivateTo.FormattingEnabled = true;
            this.comboBoxPrivateTo.Location = new System.Drawing.Point(104, 46);
            this.comboBoxPrivateTo.Name = "comboBoxPrivateTo";
            this.comboBoxPrivateTo.Size = new System.Drawing.Size(74, 21);
            this.comboBoxPrivateTo.TabIndex = 2;
            this.comboBoxPrivateTo.TabStop = false;
            // 
            // radioBtnPublic
            // 
            this.radioBtnPublic.AutoSize = true;
            this.radioBtnPublic.Checked = true;
            this.radioBtnPublic.Location = new System.Drawing.Point(11, 17);
            this.radioBtnPublic.Name = "radioBtnPublic";
            this.radioBtnPublic.Size = new System.Drawing.Size(54, 17);
            this.radioBtnPublic.TabIndex = 0;
            this.radioBtnPublic.TabStop = true;
            this.radioBtnPublic.Text = "Public";
            this.radioBtnPublic.UseVisualStyleBackColor = true;
            // 
            // radioBtnPrivate
            // 
            this.radioBtnPrivate.AutoSize = true;
            this.radioBtnPrivate.Location = new System.Drawing.Point(11, 47);
            this.radioBtnPrivate.Name = "radioBtnPrivate";
            this.radioBtnPrivate.Size = new System.Drawing.Size(58, 17);
            this.radioBtnPrivate.TabIndex = 1;
            this.radioBtnPrivate.Text = "Private";
            this.radioBtnPrivate.UseVisualStyleBackColor = true;
            this.radioBtnPrivate.CheckedChanged += new System.EventHandler(this.radioBtnPrivate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Client_GUI.Properties.Resources.backgroundChat;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 34);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users connected:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.virtualForms);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = global::Client_GUI.Properties.Resources.favicon;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ohad\'s Chat - Server Side";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.virtualForms.ResumeLayout(false);
            this.virtualDisconnected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.virtualConnected.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelChatHeader.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPictureAdded)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuFullWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemHowToUse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripMenuItem menuLogInOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage virtualDisconnected;
        private VirtualForm virtualForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage virtualConnected;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMessageContent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ToolStripMenuItem menuChatDetails;
        private System.Windows.Forms.ListView listViewConnectedUsers;
        private System.Windows.Forms.Panel panelChatHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLoggedAs;
        private System.Windows.Forms.RichTextBox rtbMessagesDisplayer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioBtnPrivate;
        private System.Windows.Forms.RadioButton radioBtnPublic;
        private System.Windows.Forms.ComboBox comboBoxPrivateTo;
        private System.Windows.Forms.Label lblPrivateTo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblPictureAdded;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox picBoxPictureAdded;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnRemoveImage;
    }
}

