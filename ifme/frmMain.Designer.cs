﻿namespace ifme
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstMedia = new System.Windows.Forms.ListView();
            this.colMediaFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediaDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediaType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediaTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediaStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMediaConfig = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.grpStreamInfo = new System.Windows.Forms.GroupBox();
            this.txtMediaInfo = new System.Windows.Forms.TextBox();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.grpVideoInterlace = new System.Windows.Forms.GroupBox();
            this.chkVideoDeinterlace = new System.Windows.Forms.CheckBox();
            this.cboVideoDeinterlaceField = new System.Windows.Forms.ComboBox();
            this.lblVideoDeinterlaceField = new System.Windows.Forms.Label();
            this.cboVideoDeinterlaceMode = new System.Windows.Forms.ComboBox();
            this.lblVideoDeinterlaceMode = new System.Windows.Forms.Label();
            this.grpVideoStream = new System.Windows.Forms.GroupBox();
            this.cboVideoStreamLang = new System.Windows.Forms.ComboBox();
            this.btnVideoAdd = new System.Windows.Forms.Button();
            this.btnVideoDel = new System.Windows.Forms.Button();
            this.lstVideo = new System.Windows.Forms.ListView();
            this.colVideoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVideoLang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVideoInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVideoMoveUp = new System.Windows.Forms.Button();
            this.btnVideoMoveDown = new System.Windows.Forms.Button();
            this.grpVideoCodec = new System.Windows.Forms.GroupBox();
            this.btnVideoAdvDec = new System.Windows.Forms.Button();
            this.btnVideoAdv = new System.Windows.Forms.Button();
            this.nudVideoMultiPass = new System.Windows.Forms.NumericUpDown();
            this.lblVideoMultiPass = new System.Windows.Forms.Label();
            this.nudVideoRateFactor = new System.Windows.Forms.NumericUpDown();
            this.lblVideoRateFactor = new System.Windows.Forms.Label();
            this.cboVideoRateControl = new System.Windows.Forms.ComboBox();
            this.lblVideoRateControl = new System.Windows.Forms.Label();
            this.cboVideoTune = new System.Windows.Forms.ComboBox();
            this.lblVideoTune = new System.Windows.Forms.Label();
            this.cboVideoPreset = new System.Windows.Forms.ComboBox();
            this.lblVideoPreset = new System.Windows.Forms.Label();
            this.cboVideoEncoder = new System.Windows.Forms.ComboBox();
            this.lblVideoEncoder = new System.Windows.Forms.Label();
            this.grpVideoPicture = new System.Windows.Forms.GroupBox();
            this.cboVideoPixelFormat = new System.Windows.Forms.ComboBox();
            this.lblPixelFormat = new System.Windows.Forms.Label();
            this.cboVideoBitDepth = new System.Windows.Forms.ComboBox();
            this.lblVideoBitDepth = new System.Windows.Forms.Label();
            this.cboVideoFrameRate = new System.Windows.Forms.ComboBox();
            this.lblVideoFrameRate = new System.Windows.Forms.Label();
            this.cboVideoResolution = new System.Windows.Forms.ComboBox();
            this.lblVideoResolution = new System.Windows.Forms.Label();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.pnlAudio = new System.Windows.Forms.Panel();
            this.grpAudioCodec = new System.Windows.Forms.GroupBox();
            this.btnAudioAdvDec = new System.Windows.Forms.Button();
            this.cboAudioMode = new System.Windows.Forms.ComboBox();
            this.lblAudioMode = new System.Windows.Forms.Label();
            this.btnAudioAdv = new System.Windows.Forms.Button();
            this.cboAudioChannel = new System.Windows.Forms.ComboBox();
            this.lblAudioChannel = new System.Windows.Forms.Label();
            this.cboAudioSampleRate = new System.Windows.Forms.ComboBox();
            this.lblAudioSampleRate = new System.Windows.Forms.Label();
            this.cboAudioQuality = new System.Windows.Forms.ComboBox();
            this.lblAudioQuality = new System.Windows.Forms.Label();
            this.cboAudioEncoder = new System.Windows.Forms.ComboBox();
            this.lblAudioEncoder = new System.Windows.Forms.Label();
            this.grpAudioStream = new System.Windows.Forms.GroupBox();
            this.cboAudioStreamLang = new System.Windows.Forms.ComboBox();
            this.lstAudio = new System.Windows.Forms.ListView();
            this.colAudioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudioLang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudioInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAudioMoveUp = new System.Windows.Forms.Button();
            this.btnAudioMoveDown = new System.Windows.Forms.Button();
            this.btnAudioDel = new System.Windows.Forms.Button();
            this.btnAudioAdd = new System.Windows.Forms.Button();
            this.tabSubtitle = new System.Windows.Forms.TabPage();
            this.pnlSubtitle = new System.Windows.Forms.Panel();
            this.chkSubHard = new System.Windows.Forms.CheckBox();
            this.btnSubAdd2 = new System.Windows.Forms.Button();
            this.cboSubLang = new System.Windows.Forms.ComboBox();
            this.lblSubLang = new System.Windows.Forms.Label();
            this.lstSub = new System.Windows.Forms.ListView();
            this.colSubId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubLang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubMoveDown = new System.Windows.Forms.Button();
            this.btnSubMoveUp = new System.Windows.Forms.Button();
            this.btnSubDel = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.tabAttachment = new System.Windows.Forms.TabPage();
            this.pnlAttachment = new System.Windows.Forms.Panel();
            this.btnAttchAdd2 = new System.Windows.Forms.Button();
            this.cboAttachMime = new System.Windows.Forms.ComboBox();
            this.lblAttachMime = new System.Windows.Forms.Label();
            this.lstAttach = new System.Windows.Forms.ListView();
            this.colAttachId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAttachFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAttachMime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAttachDel = new System.Windows.Forms.Button();
            this.btnAttachAdd = new System.Windows.Forms.Button();
            this.tabAdvance = new System.Windows.Forms.TabPage();
            this.pnlDecoder = new System.Windows.Forms.Panel();
            this.chkAdvTrim = new System.Windows.Forms.CheckBox();
            this.grpAdvTrim = new System.Windows.Forms.GroupBox();
            this.mtxAdvTimeDuration = new System.Windows.Forms.MaskedTextBox();
            this.mtxAdvTimeEnd = new System.Windows.Forms.MaskedTextBox();
            this.mtxAdvTimeStart = new System.Windows.Forms.MaskedTextBox();
            this.lblAdvTimeEqual = new System.Windows.Forms.Label();
            this.lblAdvTimeUntil = new System.Windows.Forms.Label();
            this.lblAdvTimeEnd = new System.Windows.Forms.Label();
            this.lblAdvTimeDuration = new System.Windows.Forms.Label();
            this.lblAdvTimeStart = new System.Windows.Forms.Label();
            this.txtFolderOutput = new System.Windows.Forms.TextBox();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnBrowseFolderOutput = new System.Windows.Forms.Button();
            this.lblEncodingPreset = new System.Windows.Forms.Label();
            this.cboEncodingPreset = new System.Windows.Forms.ComboBox();
            this.btnEncodingPresetSave = new System.Windows.Forms.Button();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.btnDonePowerOff = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMediaMoveDown = new System.Windows.Forms.Button();
            this.btnMediaMoveUp = new System.Windows.Forms.Button();
            this.btnMediaFileDel = new System.Windows.Forms.Button();
            this.btnMediaFileOpen = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cmsNewImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProjectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEncodingPreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEncodingPresetSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEncodingPresetSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnBench = new System.Windows.Forms.Button();
            this.cboTargetFormat = new System.Windows.Forms.ComboBox();
            this.lblTargetFormat = new System.Windows.Forms.Label();
            this.tabMediaConfig.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.grpStreamInfo.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.pnlVideo.SuspendLayout();
            this.grpVideoInterlace.SuspendLayout();
            this.grpVideoStream.SuspendLayout();
            this.grpVideoCodec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoMultiPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoRateFactor)).BeginInit();
            this.grpVideoPicture.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.pnlAudio.SuspendLayout();
            this.grpAudioCodec.SuspendLayout();
            this.grpAudioStream.SuspendLayout();
            this.tabSubtitle.SuspendLayout();
            this.pnlSubtitle.SuspendLayout();
            this.tabAttachment.SuspendLayout();
            this.pnlAttachment.SuspendLayout();
            this.tabAdvance.SuspendLayout();
            this.pnlDecoder.SuspendLayout();
            this.grpAdvTrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.cmsNewImport.SuspendLayout();
            this.cmsEncodingPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMedia
            // 
            this.lstMedia.AllowDrop = true;
            this.lstMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMedia.CheckBoxes = true;
            this.lstMedia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMediaFileName,
            this.colMediaDuration,
            this.colMediaType,
            this.colMediaTarget,
            this.colMediaStatus});
            this.lstMedia.FullRowSelect = true;
            this.lstMedia.HideSelection = false;
            this.lstMedia.Location = new System.Drawing.Point(12, 114);
            this.lstMedia.Name = "lstMedia";
            this.lstMedia.Size = new System.Drawing.Size(876, 151);
            this.lstMedia.TabIndex = 14;
            this.lstMedia.UseCompatibleStateImageBehavior = false;
            this.lstMedia.View = System.Windows.Forms.View.Details;
            this.lstMedia.SelectedIndexChanged += new System.EventHandler(this.lstMedia_SelectedIndexChanged);
            this.lstMedia.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMedia_DragDrop);
            this.lstMedia.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstMedia_DragEnter);
            this.lstMedia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewItem_KeyDown);
            // 
            // colMediaFileName
            // 
            this.colMediaFileName.Text = "File name";
            this.colMediaFileName.Width = 410;
            // 
            // colMediaDuration
            // 
            this.colMediaDuration.Text = "Duration";
            this.colMediaDuration.Width = 100;
            // 
            // colMediaType
            // 
            this.colMediaType.Text = "Type";
            this.colMediaType.Width = 100;
            // 
            // colMediaTarget
            // 
            this.colMediaTarget.Text = "Target";
            this.colMediaTarget.Width = 100;
            // 
            // colMediaStatus
            // 
            this.colMediaStatus.Text = "Status";
            this.colMediaStatus.Width = 140;
            // 
            // tabMediaConfig
            // 
            this.tabMediaConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMediaConfig.Controls.Add(this.tabGeneral);
            this.tabMediaConfig.Controls.Add(this.tabVideo);
            this.tabMediaConfig.Controls.Add(this.tabAudio);
            this.tabMediaConfig.Controls.Add(this.tabSubtitle);
            this.tabMediaConfig.Controls.Add(this.tabAttachment);
            this.tabMediaConfig.Controls.Add(this.tabAdvance);
            this.tabMediaConfig.Location = new System.Drawing.Point(12, 271);
            this.tabMediaConfig.Name = "tabMediaConfig";
            this.tabMediaConfig.SelectedIndex = 0;
            this.tabMediaConfig.Size = new System.Drawing.Size(876, 331);
            this.tabMediaConfig.TabIndex = 15;
            this.tabMediaConfig.SelectedIndexChanged += new System.EventHandler(this.tabMediaConfig_SelectedIndexChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.pnlGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(868, 305);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.grpStreamInfo);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(3, 3);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(862, 299);
            this.pnlGeneral.TabIndex = 0;
            // 
            // grpStreamInfo
            // 
            this.grpStreamInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStreamInfo.Controls.Add(this.txtMediaInfo);
            this.grpStreamInfo.Location = new System.Drawing.Point(3, 3);
            this.grpStreamInfo.Name = "grpStreamInfo";
            this.grpStreamInfo.Size = new System.Drawing.Size(856, 293);
            this.grpStreamInfo.TabIndex = 1;
            this.grpStreamInfo.TabStop = false;
            this.grpStreamInfo.Text = "Media Info";
            // 
            // txtMediaInfo
            // 
            this.txtMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMediaInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtMediaInfo.Location = new System.Drawing.Point(6, 19);
            this.txtMediaInfo.Multiline = true;
            this.txtMediaInfo.Name = "txtMediaInfo";
            this.txtMediaInfo.ReadOnly = true;
            this.txtMediaInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMediaInfo.Size = new System.Drawing.Size(844, 268);
            this.txtMediaInfo.TabIndex = 0;
            this.txtMediaInfo.WordWrap = false;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.pnlVideo);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(868, 305);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.grpVideoInterlace);
            this.pnlVideo.Controls.Add(this.grpVideoStream);
            this.pnlVideo.Controls.Add(this.grpVideoCodec);
            this.pnlVideo.Controls.Add(this.grpVideoPicture);
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideo.Location = new System.Drawing.Point(3, 3);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(862, 299);
            this.pnlVideo.TabIndex = 0;
            // 
            // grpVideoInterlace
            // 
            this.grpVideoInterlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVideoInterlace.Controls.Add(this.chkVideoDeinterlace);
            this.grpVideoInterlace.Controls.Add(this.cboVideoDeinterlaceField);
            this.grpVideoInterlace.Controls.Add(this.lblVideoDeinterlaceField);
            this.grpVideoInterlace.Controls.Add(this.cboVideoDeinterlaceMode);
            this.grpVideoInterlace.Controls.Add(this.lblVideoDeinterlaceMode);
            this.grpVideoInterlace.Location = new System.Drawing.Point(634, 142);
            this.grpVideoInterlace.Name = "grpVideoInterlace";
            this.grpVideoInterlace.Size = new System.Drawing.Size(224, 151);
            this.grpVideoInterlace.TabIndex = 3;
            this.grpVideoInterlace.TabStop = false;
            // 
            // chkVideoDeinterlace
            // 
            this.chkVideoDeinterlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVideoDeinterlace.AutoSize = true;
            this.chkVideoDeinterlace.BackColor = System.Drawing.SystemColors.Window;
            this.chkVideoDeinterlace.Location = new System.Drawing.Point(8, -1);
            this.chkVideoDeinterlace.Name = "chkVideoDeinterlace";
            this.chkVideoDeinterlace.Size = new System.Drawing.Size(85, 17);
            this.chkVideoDeinterlace.TabIndex = 0;
            this.chkVideoDeinterlace.Text = "&Deinterlace?";
            this.chkVideoDeinterlace.UseVisualStyleBackColor = false;
            this.chkVideoDeinterlace.CheckedChanged += new System.EventHandler(this.chkVideoDeinterlace_CheckedChanged);
            this.chkVideoDeinterlace.Leave += new System.EventHandler(this.MediaApply);
            // 
            // cboVideoDeinterlaceField
            // 
            this.cboVideoDeinterlaceField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoDeinterlaceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoDeinterlaceField.Enabled = false;
            this.cboVideoDeinterlaceField.FormattingEnabled = true;
            this.cboVideoDeinterlaceField.Items.AddRange(new object[] {
            "Top Field First",
            "Bottom Field First"});
            this.cboVideoDeinterlaceField.Location = new System.Drawing.Point(9, 93);
            this.cboVideoDeinterlaceField.Name = "cboVideoDeinterlaceField";
            this.cboVideoDeinterlaceField.Size = new System.Drawing.Size(206, 21);
            this.cboVideoDeinterlaceField.TabIndex = 3;
            this.cboVideoDeinterlaceField.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoDeinterlaceField
            // 
            this.lblVideoDeinterlaceField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoDeinterlaceField.Enabled = false;
            this.lblVideoDeinterlaceField.Location = new System.Drawing.Point(9, 69);
            this.lblVideoDeinterlaceField.Name = "lblVideoDeinterlaceField";
            this.lblVideoDeinterlaceField.Size = new System.Drawing.Size(206, 21);
            this.lblVideoDeinterlaceField.TabIndex = 2;
            this.lblVideoDeinterlaceField.Text = "Fiel&ds:";
            this.lblVideoDeinterlaceField.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoDeinterlaceMode
            // 
            this.cboVideoDeinterlaceMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoDeinterlaceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoDeinterlaceMode.Enabled = false;
            this.cboVideoDeinterlaceMode.FormattingEnabled = true;
            this.cboVideoDeinterlaceMode.Items.AddRange(new object[] {
            "Deinterlace only frame",
            "Deinterlace each field",
            "Skips spatial interlacing frame check",
            "Skips spatial interlacing field check"});
            this.cboVideoDeinterlaceMode.Location = new System.Drawing.Point(9, 45);
            this.cboVideoDeinterlaceMode.Name = "cboVideoDeinterlaceMode";
            this.cboVideoDeinterlaceMode.Size = new System.Drawing.Size(206, 21);
            this.cboVideoDeinterlaceMode.TabIndex = 1;
            this.cboVideoDeinterlaceMode.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoDeinterlaceMode
            // 
            this.lblVideoDeinterlaceMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoDeinterlaceMode.Enabled = false;
            this.lblVideoDeinterlaceMode.Location = new System.Drawing.Point(9, 21);
            this.lblVideoDeinterlaceMode.Name = "lblVideoDeinterlaceMode";
            this.lblVideoDeinterlaceMode.Size = new System.Drawing.Size(206, 21);
            this.lblVideoDeinterlaceMode.TabIndex = 0;
            this.lblVideoDeinterlaceMode.Text = "&Mode:";
            this.lblVideoDeinterlaceMode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // grpVideoStream
            // 
            this.grpVideoStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVideoStream.Controls.Add(this.cboVideoStreamLang);
            this.grpVideoStream.Controls.Add(this.btnVideoAdd);
            this.grpVideoStream.Controls.Add(this.btnVideoDel);
            this.grpVideoStream.Controls.Add(this.lstVideo);
            this.grpVideoStream.Controls.Add(this.btnVideoMoveUp);
            this.grpVideoStream.Controls.Add(this.btnVideoMoveDown);
            this.grpVideoStream.Location = new System.Drawing.Point(3, 3);
            this.grpVideoStream.Name = "grpVideoStream";
            this.grpVideoStream.Size = new System.Drawing.Size(350, 290);
            this.grpVideoStream.TabIndex = 0;
            this.grpVideoStream.TabStop = false;
            this.grpVideoStream.Text = "&Streams";
            // 
            // cboVideoStreamLang
            // 
            this.cboVideoStreamLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoStreamLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoStreamLang.FormattingEnabled = true;
            this.cboVideoStreamLang.Location = new System.Drawing.Point(6, 263);
            this.cboVideoStreamLang.Name = "cboVideoStreamLang";
            this.cboVideoStreamLang.Size = new System.Drawing.Size(338, 21);
            this.cboVideoStreamLang.TabIndex = 5;
            this.cboVideoStreamLang.Leave += new System.EventHandler(this.MediaApply);
            // 
            // btnVideoAdd
            // 
            this.btnVideoAdd.Image = global::ifme.Properties.Resources.icon16_add;
            this.btnVideoAdd.Location = new System.Drawing.Point(6, 19);
            this.btnVideoAdd.Name = "btnVideoAdd";
            this.btnVideoAdd.Size = new System.Drawing.Size(24, 24);
            this.btnVideoAdd.TabIndex = 0;
            this.btnVideoAdd.UseVisualStyleBackColor = true;
            this.btnVideoAdd.Click += new System.EventHandler(this.btnVideoAdd_Click);
            // 
            // btnVideoDel
            // 
            this.btnVideoDel.Image = global::ifme.Properties.Resources.icon16_del;
            this.btnVideoDel.Location = new System.Drawing.Point(36, 19);
            this.btnVideoDel.Name = "btnVideoDel";
            this.btnVideoDel.Size = new System.Drawing.Size(24, 24);
            this.btnVideoDel.TabIndex = 1;
            this.btnVideoDel.UseVisualStyleBackColor = true;
            this.btnVideoDel.Click += new System.EventHandler(this.btnVideoDel_Click);
            // 
            // lstVideo
            // 
            this.lstVideo.AllowDrop = true;
            this.lstVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVideoId,
            this.colVideoLang,
            this.colVideoInfo});
            this.lstVideo.FullRowSelect = true;
            this.lstVideo.HideSelection = false;
            this.lstVideo.Location = new System.Drawing.Point(6, 49);
            this.lstVideo.Name = "lstVideo";
            this.lstVideo.Size = new System.Drawing.Size(338, 208);
            this.lstVideo.TabIndex = 4;
            this.lstVideo.UseCompatibleStateImageBehavior = false;
            this.lstVideo.View = System.Windows.Forms.View.Details;
            this.lstVideo.SelectedIndexChanged += new System.EventHandler(this.lstVideo_SelectedIndexChanged);
            this.lstVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstVideo_DragDrop);
            this.lstVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstVideo_DragEnter);
            this.lstVideo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewItem_KeyDown);
            // 
            // colVideoId
            // 
            this.colVideoId.Text = "Id";
            this.colVideoId.Width = 32;
            // 
            // colVideoLang
            // 
            this.colVideoLang.Text = "Lang";
            this.colVideoLang.Width = 48;
            // 
            // colVideoInfo
            // 
            this.colVideoInfo.Text = "Info";
            this.colVideoInfo.Width = 235;
            // 
            // btnVideoMoveUp
            // 
            this.btnVideoMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoMoveUp.Image = global::ifme.Properties.Resources.icon16_up;
            this.btnVideoMoveUp.Location = new System.Drawing.Point(290, 19);
            this.btnVideoMoveUp.Name = "btnVideoMoveUp";
            this.btnVideoMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnVideoMoveUp.TabIndex = 2;
            this.btnVideoMoveUp.UseVisualStyleBackColor = true;
            this.btnVideoMoveUp.Click += new System.EventHandler(this.btnVideoMoveUp_Click);
            // 
            // btnVideoMoveDown
            // 
            this.btnVideoMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoMoveDown.Image = global::ifme.Properties.Resources.icon16_down;
            this.btnVideoMoveDown.Location = new System.Drawing.Point(320, 19);
            this.btnVideoMoveDown.Name = "btnVideoMoveDown";
            this.btnVideoMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnVideoMoveDown.TabIndex = 3;
            this.btnVideoMoveDown.UseVisualStyleBackColor = true;
            this.btnVideoMoveDown.Click += new System.EventHandler(this.btnVideoMoveDown_Click);
            // 
            // grpVideoCodec
            // 
            this.grpVideoCodec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVideoCodec.Controls.Add(this.btnVideoAdvDec);
            this.grpVideoCodec.Controls.Add(this.btnVideoAdv);
            this.grpVideoCodec.Controls.Add(this.nudVideoMultiPass);
            this.grpVideoCodec.Controls.Add(this.lblVideoMultiPass);
            this.grpVideoCodec.Controls.Add(this.nudVideoRateFactor);
            this.grpVideoCodec.Controls.Add(this.lblVideoRateFactor);
            this.grpVideoCodec.Controls.Add(this.cboVideoRateControl);
            this.grpVideoCodec.Controls.Add(this.lblVideoRateControl);
            this.grpVideoCodec.Controls.Add(this.cboVideoTune);
            this.grpVideoCodec.Controls.Add(this.lblVideoTune);
            this.grpVideoCodec.Controls.Add(this.cboVideoPreset);
            this.grpVideoCodec.Controls.Add(this.lblVideoPreset);
            this.grpVideoCodec.Controls.Add(this.cboVideoEncoder);
            this.grpVideoCodec.Controls.Add(this.lblVideoEncoder);
            this.grpVideoCodec.Location = new System.Drawing.Point(359, 3);
            this.grpVideoCodec.Name = "grpVideoCodec";
            this.grpVideoCodec.Size = new System.Drawing.Size(270, 290);
            this.grpVideoCodec.TabIndex = 1;
            this.grpVideoCodec.TabStop = false;
            this.grpVideoCodec.Text = "&Codec";
            // 
            // btnVideoAdvDec
            // 
            this.btnVideoAdvDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoAdvDec.Location = new System.Drawing.Point(11, 222);
            this.btnVideoAdvDec.Name = "btnVideoAdvDec";
            this.btnVideoAdvDec.Size = new System.Drawing.Size(248, 28);
            this.btnVideoAdvDec.TabIndex = 13;
            this.btnVideoAdvDec.Text = "&Decoder options";
            this.btnVideoAdvDec.UseVisualStyleBackColor = true;
            this.btnVideoAdvDec.Click += new System.EventHandler(this.btnAdvanceCommand_Click);
            // 
            // btnVideoAdv
            // 
            this.btnVideoAdv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoAdv.Location = new System.Drawing.Point(11, 256);
            this.btnVideoAdv.Name = "btnVideoAdv";
            this.btnVideoAdv.Size = new System.Drawing.Size(248, 28);
            this.btnVideoAdv.TabIndex = 12;
            this.btnVideoAdv.Text = "E&ncoder options";
            this.btnVideoAdv.UseVisualStyleBackColor = true;
            this.btnVideoAdv.Click += new System.EventHandler(this.btnAdvanceCommand_Click);
            // 
            // nudVideoMultiPass
            // 
            this.nudVideoMultiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVideoMultiPass.BackColor = System.Drawing.Color.White;
            this.nudVideoMultiPass.ForeColor = System.Drawing.Color.Black;
            this.nudVideoMultiPass.Location = new System.Drawing.Point(138, 184);
            this.nudVideoMultiPass.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudVideoMultiPass.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVideoMultiPass.Name = "nudVideoMultiPass";
            this.nudVideoMultiPass.Size = new System.Drawing.Size(121, 20);
            this.nudVideoMultiPass.TabIndex = 11;
            this.nudVideoMultiPass.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVideoMultiPass.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoMultiPass
            // 
            this.lblVideoMultiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoMultiPass.Location = new System.Drawing.Point(138, 163);
            this.lblVideoMultiPass.Name = "lblVideoMultiPass";
            this.lblVideoMultiPass.Size = new System.Drawing.Size(121, 18);
            this.lblVideoMultiPass.TabIndex = 10;
            this.lblVideoMultiPass.Text = "M&ultipass:";
            this.lblVideoMultiPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudVideoRateFactor
            // 
            this.nudVideoRateFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVideoRateFactor.BackColor = System.Drawing.Color.White;
            this.nudVideoRateFactor.Font = new System.Drawing.Font("Tahoma", 8F);
            this.nudVideoRateFactor.ForeColor = System.Drawing.Color.Black;
            this.nudVideoRateFactor.Location = new System.Drawing.Point(11, 184);
            this.nudVideoRateFactor.Name = "nudVideoRateFactor";
            this.nudVideoRateFactor.Size = new System.Drawing.Size(121, 20);
            this.nudVideoRateFactor.TabIndex = 9;
            this.nudVideoRateFactor.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoRateFactor
            // 
            this.lblVideoRateFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoRateFactor.Location = new System.Drawing.Point(11, 163);
            this.lblVideoRateFactor.Name = "lblVideoRateFactor";
            this.lblVideoRateFactor.Size = new System.Drawing.Size(121, 18);
            this.lblVideoRateFactor.TabIndex = 8;
            this.lblVideoRateFactor.Text = "R&ate factor:";
            this.lblVideoRateFactor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoRateControl
            // 
            this.cboVideoRateControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoRateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoRateControl.FormattingEnabled = true;
            this.cboVideoRateControl.Location = new System.Drawing.Point(11, 139);
            this.cboVideoRateControl.Name = "cboVideoRateControl";
            this.cboVideoRateControl.Size = new System.Drawing.Size(248, 21);
            this.cboVideoRateControl.TabIndex = 7;
            this.cboVideoRateControl.SelectedIndexChanged += new System.EventHandler(this.cboVideoRateControl_SelectedIndexChanged);
            this.cboVideoRateControl.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoRateControl
            // 
            this.lblVideoRateControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoRateControl.Location = new System.Drawing.Point(11, 115);
            this.lblVideoRateControl.Name = "lblVideoRateControl";
            this.lblVideoRateControl.Size = new System.Drawing.Size(248, 18);
            this.lblVideoRateControl.TabIndex = 6;
            this.lblVideoRateControl.Text = "Rate &control:";
            this.lblVideoRateControl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoTune
            // 
            this.cboVideoTune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoTune.FormattingEnabled = true;
            this.cboVideoTune.Location = new System.Drawing.Point(138, 91);
            this.cboVideoTune.Name = "cboVideoTune";
            this.cboVideoTune.Size = new System.Drawing.Size(121, 21);
            this.cboVideoTune.TabIndex = 5;
            this.cboVideoTune.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoTune
            // 
            this.lblVideoTune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoTune.Location = new System.Drawing.Point(138, 67);
            this.lblVideoTune.Name = "lblVideoTune";
            this.lblVideoTune.Size = new System.Drawing.Size(121, 18);
            this.lblVideoTune.TabIndex = 4;
            this.lblVideoTune.Text = "&Tune:";
            this.lblVideoTune.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoPreset
            // 
            this.cboVideoPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoPreset.FormattingEnabled = true;
            this.cboVideoPreset.Location = new System.Drawing.Point(11, 91);
            this.cboVideoPreset.Name = "cboVideoPreset";
            this.cboVideoPreset.Size = new System.Drawing.Size(121, 21);
            this.cboVideoPreset.TabIndex = 3;
            this.cboVideoPreset.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoPreset
            // 
            this.lblVideoPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoPreset.Location = new System.Drawing.Point(11, 67);
            this.lblVideoPreset.Name = "lblVideoPreset";
            this.lblVideoPreset.Size = new System.Drawing.Size(121, 18);
            this.lblVideoPreset.TabIndex = 2;
            this.lblVideoPreset.Text = "Prese&t:";
            this.lblVideoPreset.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoEncoder
            // 
            this.cboVideoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoEncoder.FormattingEnabled = true;
            this.cboVideoEncoder.Location = new System.Drawing.Point(11, 43);
            this.cboVideoEncoder.Name = "cboVideoEncoder";
            this.cboVideoEncoder.Size = new System.Drawing.Size(248, 21);
            this.cboVideoEncoder.TabIndex = 1;
            this.cboVideoEncoder.SelectedIndexChanged += new System.EventHandler(this.cboVideoEncoder_SelectedIndexChanged);
            this.cboVideoEncoder.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoEncoder
            // 
            this.lblVideoEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoEncoder.Location = new System.Drawing.Point(11, 19);
            this.lblVideoEncoder.Name = "lblVideoEncoder";
            this.lblVideoEncoder.Size = new System.Drawing.Size(248, 18);
            this.lblVideoEncoder.TabIndex = 0;
            this.lblVideoEncoder.Text = "&Encoder:";
            this.lblVideoEncoder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // grpVideoPicture
            // 
            this.grpVideoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVideoPicture.Controls.Add(this.cboVideoPixelFormat);
            this.grpVideoPicture.Controls.Add(this.lblPixelFormat);
            this.grpVideoPicture.Controls.Add(this.cboVideoBitDepth);
            this.grpVideoPicture.Controls.Add(this.lblVideoBitDepth);
            this.grpVideoPicture.Controls.Add(this.cboVideoFrameRate);
            this.grpVideoPicture.Controls.Add(this.lblVideoFrameRate);
            this.grpVideoPicture.Controls.Add(this.cboVideoResolution);
            this.grpVideoPicture.Controls.Add(this.lblVideoResolution);
            this.grpVideoPicture.Location = new System.Drawing.Point(634, 3);
            this.grpVideoPicture.Name = "grpVideoPicture";
            this.grpVideoPicture.Size = new System.Drawing.Size(224, 133);
            this.grpVideoPicture.TabIndex = 2;
            this.grpVideoPicture.TabStop = false;
            this.grpVideoPicture.Text = "&Picture";
            // 
            // cboVideoPixelFormat
            // 
            this.cboVideoPixelFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoPixelFormat.FormattingEnabled = true;
            this.cboVideoPixelFormat.Items.AddRange(new object[] {
            "420",
            "422",
            "444"});
            this.cboVideoPixelFormat.Location = new System.Drawing.Point(115, 91);
            this.cboVideoPixelFormat.Name = "cboVideoPixelFormat";
            this.cboVideoPixelFormat.Size = new System.Drawing.Size(100, 21);
            this.cboVideoPixelFormat.TabIndex = 7;
            this.cboVideoPixelFormat.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblPixelFormat
            // 
            this.lblPixelFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPixelFormat.Location = new System.Drawing.Point(115, 67);
            this.lblPixelFormat.Name = "lblPixelFormat";
            this.lblPixelFormat.Size = new System.Drawing.Size(100, 18);
            this.lblPixelFormat.TabIndex = 6;
            this.lblPixelFormat.Text = "&Pixel Format:";
            this.lblPixelFormat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoBitDepth
            // 
            this.cboVideoBitDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoBitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoBitDepth.FormattingEnabled = true;
            this.cboVideoBitDepth.Location = new System.Drawing.Point(9, 91);
            this.cboVideoBitDepth.Name = "cboVideoBitDepth";
            this.cboVideoBitDepth.Size = new System.Drawing.Size(100, 21);
            this.cboVideoBitDepth.TabIndex = 5;
            this.cboVideoBitDepth.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoBitDepth
            // 
            this.lblVideoBitDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoBitDepth.Location = new System.Drawing.Point(9, 67);
            this.lblVideoBitDepth.Name = "lblVideoBitDepth";
            this.lblVideoBitDepth.Size = new System.Drawing.Size(100, 18);
            this.lblVideoBitDepth.TabIndex = 4;
            this.lblVideoBitDepth.Text = "&Bit depth:";
            this.lblVideoBitDepth.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoFrameRate
            // 
            this.cboVideoFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoFrameRate.BackColor = System.Drawing.Color.White;
            this.cboVideoFrameRate.ForeColor = System.Drawing.Color.Black;
            this.cboVideoFrameRate.FormattingEnabled = true;
            this.cboVideoFrameRate.Items.AddRange(new object[] {
            "auto",
            "5",
            "10",
            "12",
            "15",
            "23.976",
            "24",
            "25",
            "29.97",
            "30",
            "48",
            "50",
            "59.94",
            "60",
            "75",
            "85",
            "100",
            "120",
            "144",
            "200",
            "240"});
            this.cboVideoFrameRate.Location = new System.Drawing.Point(115, 43);
            this.cboVideoFrameRate.Name = "cboVideoFrameRate";
            this.cboVideoFrameRate.Size = new System.Drawing.Size(100, 21);
            this.cboVideoFrameRate.TabIndex = 3;
            this.cboVideoFrameRate.TextChanged += new System.EventHandler(this.cboVideoFrameRate_TextChanged);
            this.cboVideoFrameRate.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoFrameRate
            // 
            this.lblVideoFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoFrameRate.Location = new System.Drawing.Point(115, 19);
            this.lblVideoFrameRate.Name = "lblVideoFrameRate";
            this.lblVideoFrameRate.Size = new System.Drawing.Size(100, 18);
            this.lblVideoFrameRate.TabIndex = 2;
            this.lblVideoFrameRate.Text = "&Frame Rate:";
            this.lblVideoFrameRate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVideoResolution
            // 
            this.cboVideoResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVideoResolution.BackColor = System.Drawing.Color.White;
            this.cboVideoResolution.ForeColor = System.Drawing.Color.Black;
            this.cboVideoResolution.FormattingEnabled = true;
            this.cboVideoResolution.Items.AddRange(new object[] {
            "auto",
            "640x480",
            "640x360",
            "720x404",
            "800x600",
            "854x480",
            "1024x768",
            "1024x576",
            "1280x720",
            "1920x1080",
            "2560x1440",
            "3840x2160",
            "7680x4320"});
            this.cboVideoResolution.Location = new System.Drawing.Point(9, 43);
            this.cboVideoResolution.Name = "cboVideoResolution";
            this.cboVideoResolution.Size = new System.Drawing.Size(100, 21);
            this.cboVideoResolution.TabIndex = 1;
            this.cboVideoResolution.TextChanged += new System.EventHandler(this.cboVideoResolution_TextChanged);
            this.cboVideoResolution.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblVideoResolution
            // 
            this.lblVideoResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoResolution.Location = new System.Drawing.Point(9, 21);
            this.lblVideoResolution.Name = "lblVideoResolution";
            this.lblVideoResolution.Size = new System.Drawing.Size(100, 18);
            this.lblVideoResolution.TabIndex = 0;
            this.lblVideoResolution.Text = "&Resolution:";
            this.lblVideoResolution.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.pnlAudio);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(868, 305);
            this.tabAudio.TabIndex = 2;
            this.tabAudio.Text = "Audio";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // pnlAudio
            // 
            this.pnlAudio.Controls.Add(this.grpAudioCodec);
            this.pnlAudio.Controls.Add(this.grpAudioStream);
            this.pnlAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAudio.Location = new System.Drawing.Point(3, 3);
            this.pnlAudio.Name = "pnlAudio";
            this.pnlAudio.Size = new System.Drawing.Size(862, 299);
            this.pnlAudio.TabIndex = 0;
            // 
            // grpAudioCodec
            // 
            this.grpAudioCodec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAudioCodec.Controls.Add(this.btnAudioAdvDec);
            this.grpAudioCodec.Controls.Add(this.cboAudioMode);
            this.grpAudioCodec.Controls.Add(this.lblAudioMode);
            this.grpAudioCodec.Controls.Add(this.btnAudioAdv);
            this.grpAudioCodec.Controls.Add(this.cboAudioChannel);
            this.grpAudioCodec.Controls.Add(this.lblAudioChannel);
            this.grpAudioCodec.Controls.Add(this.cboAudioSampleRate);
            this.grpAudioCodec.Controls.Add(this.lblAudioSampleRate);
            this.grpAudioCodec.Controls.Add(this.cboAudioQuality);
            this.grpAudioCodec.Controls.Add(this.lblAudioQuality);
            this.grpAudioCodec.Controls.Add(this.cboAudioEncoder);
            this.grpAudioCodec.Controls.Add(this.lblAudioEncoder);
            this.grpAudioCodec.Location = new System.Drawing.Point(359, 3);
            this.grpAudioCodec.Name = "grpAudioCodec";
            this.grpAudioCodec.Size = new System.Drawing.Size(500, 290);
            this.grpAudioCodec.TabIndex = 1;
            this.grpAudioCodec.TabStop = false;
            this.grpAudioCodec.Text = "&Codec";
            // 
            // btnAudioAdvDec
            // 
            this.btnAudioAdvDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudioAdvDec.Location = new System.Drawing.Point(63, 181);
            this.btnAudioAdvDec.Name = "btnAudioAdvDec";
            this.btnAudioAdvDec.Size = new System.Drawing.Size(375, 28);
            this.btnAudioAdvDec.TabIndex = 11;
            this.btnAudioAdvDec.Text = "&Decoder options";
            this.btnAudioAdvDec.UseVisualStyleBackColor = true;
            this.btnAudioAdvDec.Click += new System.EventHandler(this.btnAdvanceCommand_Click);
            // 
            // cboAudioMode
            // 
            this.cboAudioMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioMode.FormattingEnabled = true;
            this.cboAudioMode.Location = new System.Drawing.Point(317, 72);
            this.cboAudioMode.Name = "cboAudioMode";
            this.cboAudioMode.Size = new System.Drawing.Size(121, 21);
            this.cboAudioMode.TabIndex = 10;
            this.cboAudioMode.SelectedIndexChanged += new System.EventHandler(this.cboAudioMode_SelectedIndexChanged);
            this.cboAudioMode.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAudioMode
            // 
            this.lblAudioMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudioMode.Location = new System.Drawing.Point(317, 48);
            this.lblAudioMode.Name = "lblAudioMode";
            this.lblAudioMode.Size = new System.Drawing.Size(121, 18);
            this.lblAudioMode.TabIndex = 9;
            this.lblAudioMode.Text = "&Mode:";
            this.lblAudioMode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAudioAdv
            // 
            this.btnAudioAdv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudioAdv.Location = new System.Drawing.Point(63, 215);
            this.btnAudioAdv.Name = "btnAudioAdv";
            this.btnAudioAdv.Size = new System.Drawing.Size(375, 28);
            this.btnAudioAdv.TabIndex = 8;
            this.btnAudioAdv.Text = "E&ncoder options";
            this.btnAudioAdv.UseVisualStyleBackColor = true;
            this.btnAudioAdv.Click += new System.EventHandler(this.btnAdvanceCommand_Click);
            // 
            // cboAudioChannel
            // 
            this.cboAudioChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioChannel.FormattingEnabled = true;
            this.cboAudioChannel.Location = new System.Drawing.Point(317, 120);
            this.cboAudioChannel.Name = "cboAudioChannel";
            this.cboAudioChannel.Size = new System.Drawing.Size(121, 21);
            this.cboAudioChannel.TabIndex = 7;
            this.cboAudioChannel.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAudioChannel
            // 
            this.lblAudioChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudioChannel.Location = new System.Drawing.Point(317, 96);
            this.lblAudioChannel.Name = "lblAudioChannel";
            this.lblAudioChannel.Size = new System.Drawing.Size(121, 18);
            this.lblAudioChannel.TabIndex = 6;
            this.lblAudioChannel.Text = "C&hannel:";
            this.lblAudioChannel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboAudioSampleRate
            // 
            this.cboAudioSampleRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSampleRate.FormattingEnabled = true;
            this.cboAudioSampleRate.Location = new System.Drawing.Point(190, 120);
            this.cboAudioSampleRate.Name = "cboAudioSampleRate";
            this.cboAudioSampleRate.Size = new System.Drawing.Size(121, 21);
            this.cboAudioSampleRate.TabIndex = 5;
            this.cboAudioSampleRate.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAudioSampleRate
            // 
            this.lblAudioSampleRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudioSampleRate.Location = new System.Drawing.Point(190, 96);
            this.lblAudioSampleRate.Name = "lblAudioSampleRate";
            this.lblAudioSampleRate.Size = new System.Drawing.Size(121, 18);
            this.lblAudioSampleRate.TabIndex = 4;
            this.lblAudioSampleRate.Text = "Sample &Rate:";
            this.lblAudioSampleRate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboAudioQuality
            // 
            this.cboAudioQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioQuality.FormattingEnabled = true;
            this.cboAudioQuality.Location = new System.Drawing.Point(63, 120);
            this.cboAudioQuality.Name = "cboAudioQuality";
            this.cboAudioQuality.Size = new System.Drawing.Size(121, 21);
            this.cboAudioQuality.TabIndex = 3;
            this.cboAudioQuality.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAudioQuality
            // 
            this.lblAudioQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudioQuality.Location = new System.Drawing.Point(63, 96);
            this.lblAudioQuality.Name = "lblAudioQuality";
            this.lblAudioQuality.Size = new System.Drawing.Size(121, 18);
            this.lblAudioQuality.TabIndex = 2;
            this.lblAudioQuality.Text = "&Quality:";
            this.lblAudioQuality.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboAudioEncoder
            // 
            this.cboAudioEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioEncoder.FormattingEnabled = true;
            this.cboAudioEncoder.Location = new System.Drawing.Point(63, 72);
            this.cboAudioEncoder.Name = "cboAudioEncoder";
            this.cboAudioEncoder.Size = new System.Drawing.Size(248, 21);
            this.cboAudioEncoder.TabIndex = 1;
            this.cboAudioEncoder.SelectedIndexChanged += new System.EventHandler(this.cboAudioEncoder_SelectedIndexChanged);
            this.cboAudioEncoder.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAudioEncoder
            // 
            this.lblAudioEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudioEncoder.Location = new System.Drawing.Point(63, 48);
            this.lblAudioEncoder.Name = "lblAudioEncoder";
            this.lblAudioEncoder.Size = new System.Drawing.Size(248, 18);
            this.lblAudioEncoder.TabIndex = 0;
            this.lblAudioEncoder.Text = "&Encoder:";
            this.lblAudioEncoder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // grpAudioStream
            // 
            this.grpAudioStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAudioStream.Controls.Add(this.cboAudioStreamLang);
            this.grpAudioStream.Controls.Add(this.lstAudio);
            this.grpAudioStream.Controls.Add(this.btnAudioMoveUp);
            this.grpAudioStream.Controls.Add(this.btnAudioMoveDown);
            this.grpAudioStream.Controls.Add(this.btnAudioDel);
            this.grpAudioStream.Controls.Add(this.btnAudioAdd);
            this.grpAudioStream.Location = new System.Drawing.Point(3, 3);
            this.grpAudioStream.Name = "grpAudioStream";
            this.grpAudioStream.Size = new System.Drawing.Size(350, 290);
            this.grpAudioStream.TabIndex = 0;
            this.grpAudioStream.TabStop = false;
            this.grpAudioStream.Text = "&Streams";
            // 
            // cboAudioStreamLang
            // 
            this.cboAudioStreamLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioStreamLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioStreamLang.FormattingEnabled = true;
            this.cboAudioStreamLang.Location = new System.Drawing.Point(6, 263);
            this.cboAudioStreamLang.Name = "cboAudioStreamLang";
            this.cboAudioStreamLang.Size = new System.Drawing.Size(338, 21);
            this.cboAudioStreamLang.TabIndex = 5;
            this.cboAudioStreamLang.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lstAudio
            // 
            this.lstAudio.AllowDrop = true;
            this.lstAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAudio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAudioId,
            this.colAudioLang,
            this.colAudioInfo});
            this.lstAudio.FullRowSelect = true;
            this.lstAudio.HideSelection = false;
            this.lstAudio.Location = new System.Drawing.Point(6, 49);
            this.lstAudio.Name = "lstAudio";
            this.lstAudio.Size = new System.Drawing.Size(338, 208);
            this.lstAudio.TabIndex = 4;
            this.lstAudio.UseCompatibleStateImageBehavior = false;
            this.lstAudio.View = System.Windows.Forms.View.Details;
            this.lstAudio.SelectedIndexChanged += new System.EventHandler(this.lstAudio_SelectedIndexChanged);
            this.lstAudio.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAudio_DragDrop);
            this.lstAudio.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAudio_DragEnter);
            this.lstAudio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewItem_KeyDown);
            // 
            // colAudioId
            // 
            this.colAudioId.Text = "Id";
            this.colAudioId.Width = 32;
            // 
            // colAudioLang
            // 
            this.colAudioLang.Text = "Lang";
            this.colAudioLang.Width = 48;
            // 
            // colAudioInfo
            // 
            this.colAudioInfo.Text = "Info";
            this.colAudioInfo.Width = 235;
            // 
            // btnAudioMoveUp
            // 
            this.btnAudioMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudioMoveUp.Image = global::ifme.Properties.Resources.icon16_up;
            this.btnAudioMoveUp.Location = new System.Drawing.Point(290, 19);
            this.btnAudioMoveUp.Name = "btnAudioMoveUp";
            this.btnAudioMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnAudioMoveUp.TabIndex = 2;
            this.btnAudioMoveUp.UseVisualStyleBackColor = true;
            this.btnAudioMoveUp.Click += new System.EventHandler(this.btnAudioMoveUp_Click);
            // 
            // btnAudioMoveDown
            // 
            this.btnAudioMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudioMoveDown.Image = global::ifme.Properties.Resources.icon16_down;
            this.btnAudioMoveDown.Location = new System.Drawing.Point(320, 19);
            this.btnAudioMoveDown.Name = "btnAudioMoveDown";
            this.btnAudioMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnAudioMoveDown.TabIndex = 3;
            this.btnAudioMoveDown.UseVisualStyleBackColor = true;
            this.btnAudioMoveDown.Click += new System.EventHandler(this.btnAudioMoveDown_Click);
            // 
            // btnAudioDel
            // 
            this.btnAudioDel.Image = global::ifme.Properties.Resources.icon16_del;
            this.btnAudioDel.Location = new System.Drawing.Point(36, 19);
            this.btnAudioDel.Name = "btnAudioDel";
            this.btnAudioDel.Size = new System.Drawing.Size(24, 24);
            this.btnAudioDel.TabIndex = 1;
            this.btnAudioDel.UseVisualStyleBackColor = true;
            this.btnAudioDel.Click += new System.EventHandler(this.btnAudioDel_Click);
            // 
            // btnAudioAdd
            // 
            this.btnAudioAdd.Image = global::ifme.Properties.Resources.icon16_add;
            this.btnAudioAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAudioAdd.Name = "btnAudioAdd";
            this.btnAudioAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAudioAdd.TabIndex = 0;
            this.btnAudioAdd.UseVisualStyleBackColor = true;
            this.btnAudioAdd.Click += new System.EventHandler(this.btnAudioAdd_Click);
            // 
            // tabSubtitle
            // 
            this.tabSubtitle.Controls.Add(this.pnlSubtitle);
            this.tabSubtitle.Location = new System.Drawing.Point(4, 22);
            this.tabSubtitle.Name = "tabSubtitle";
            this.tabSubtitle.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubtitle.Size = new System.Drawing.Size(868, 305);
            this.tabSubtitle.TabIndex = 3;
            this.tabSubtitle.Text = "Subtitle";
            this.tabSubtitle.UseVisualStyleBackColor = true;
            // 
            // pnlSubtitle
            // 
            this.pnlSubtitle.Controls.Add(this.chkSubHard);
            this.pnlSubtitle.Controls.Add(this.btnSubAdd2);
            this.pnlSubtitle.Controls.Add(this.cboSubLang);
            this.pnlSubtitle.Controls.Add(this.lblSubLang);
            this.pnlSubtitle.Controls.Add(this.lstSub);
            this.pnlSubtitle.Controls.Add(this.btnSubMoveDown);
            this.pnlSubtitle.Controls.Add(this.btnSubMoveUp);
            this.pnlSubtitle.Controls.Add(this.btnSubDel);
            this.pnlSubtitle.Controls.Add(this.btnSubAdd);
            this.pnlSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubtitle.Location = new System.Drawing.Point(3, 3);
            this.pnlSubtitle.Name = "pnlSubtitle";
            this.pnlSubtitle.Size = new System.Drawing.Size(862, 299);
            this.pnlSubtitle.TabIndex = 0;
            // 
            // chkSubHard
            // 
            this.chkSubHard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSubHard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSubHard.Location = new System.Drawing.Point(609, 3);
            this.chkSubHard.Name = "chkSubHard";
            this.chkSubHard.Size = new System.Drawing.Size(250, 24);
            this.chkSubHard.TabIndex = 8;
            this.chkSubHard.Text = "&Burn Subtitle (Hard Sub)";
            this.chkSubHard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSubHard.UseVisualStyleBackColor = true;
            this.chkSubHard.CheckedChanged += new System.EventHandler(this.chkSubHard_CheckedChanged);
            this.chkSubHard.Leave += new System.EventHandler(this.MediaApply);
            // 
            // btnSubAdd2
            // 
            this.btnSubAdd2.Image = global::ifme.Properties.Resources.icon16_add2;
            this.btnSubAdd2.Location = new System.Drawing.Point(33, 3);
            this.btnSubAdd2.Name = "btnSubAdd2";
            this.btnSubAdd2.Size = new System.Drawing.Size(24, 24);
            this.btnSubAdd2.TabIndex = 7;
            this.btnSubAdd2.UseVisualStyleBackColor = true;
            this.btnSubAdd2.Click += new System.EventHandler(this.btnSubAdd2_Click);
            // 
            // cboSubLang
            // 
            this.cboSubLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSubLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubLang.FormattingEnabled = true;
            this.cboSubLang.Location = new System.Drawing.Point(3, 272);
            this.cboSubLang.Name = "cboSubLang";
            this.cboSubLang.Size = new System.Drawing.Size(856, 21);
            this.cboSubLang.TabIndex = 6;
            this.cboSubLang.SelectedIndexChanged += new System.EventHandler(this.cboSubLang_SelectedIndexChanged);
            this.cboSubLang.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblSubLang
            // 
            this.lblSubLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubLang.Location = new System.Drawing.Point(3, 248);
            this.lblSubLang.Name = "lblSubLang";
            this.lblSubLang.Size = new System.Drawing.Size(856, 21);
            this.lblSubLang.TabIndex = 5;
            this.lblSubLang.Text = "&Language:";
            this.lblSubLang.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstSub
            // 
            this.lstSub.AllowDrop = true;
            this.lstSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubId,
            this.colSubFileName,
            this.colSubLang});
            this.lstSub.FullRowSelect = true;
            this.lstSub.HideSelection = false;
            this.lstSub.Location = new System.Drawing.Point(3, 33);
            this.lstSub.Name = "lstSub";
            this.lstSub.Size = new System.Drawing.Size(856, 212);
            this.lstSub.TabIndex = 4;
            this.lstSub.UseCompatibleStateImageBehavior = false;
            this.lstSub.View = System.Windows.Forms.View.Details;
            this.lstSub.SelectedIndexChanged += new System.EventHandler(this.lstSub_SelectedIndexChanged);
            this.lstSub.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstSub_DragDrop);
            this.lstSub.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstSub_DragEnter);
            this.lstSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewItem_KeyDown);
            // 
            // colSubId
            // 
            this.colSubId.Text = "Id";
            this.colSubId.Width = 50;
            // 
            // colSubFileName
            // 
            this.colSubFileName.Text = "File name";
            this.colSubFileName.Width = 562;
            // 
            // colSubLang
            // 
            this.colSubLang.Text = "Language";
            this.colSubLang.Width = 220;
            // 
            // btnSubMoveDown
            // 
            this.btnSubMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubMoveDown.Image = global::ifme.Properties.Resources.icon16_down;
            this.btnSubMoveDown.Location = new System.Drawing.Point(434, 3);
            this.btnSubMoveDown.Name = "btnSubMoveDown";
            this.btnSubMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnSubMoveDown.TabIndex = 3;
            this.btnSubMoveDown.UseVisualStyleBackColor = true;
            this.btnSubMoveDown.Click += new System.EventHandler(this.btnSubMoveDown_Click);
            // 
            // btnSubMoveUp
            // 
            this.btnSubMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubMoveUp.Image = global::ifme.Properties.Resources.icon16_up;
            this.btnSubMoveUp.Location = new System.Drawing.Point(404, 3);
            this.btnSubMoveUp.Name = "btnSubMoveUp";
            this.btnSubMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnSubMoveUp.TabIndex = 2;
            this.btnSubMoveUp.UseVisualStyleBackColor = true;
            this.btnSubMoveUp.Click += new System.EventHandler(this.btnSubMoveUp_Click);
            // 
            // btnSubDel
            // 
            this.btnSubDel.Image = global::ifme.Properties.Resources.icon16_del;
            this.btnSubDel.Location = new System.Drawing.Point(63, 3);
            this.btnSubDel.Name = "btnSubDel";
            this.btnSubDel.Size = new System.Drawing.Size(24, 24);
            this.btnSubDel.TabIndex = 1;
            this.btnSubDel.UseVisualStyleBackColor = true;
            this.btnSubDel.Click += new System.EventHandler(this.btnSubDel_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Image = global::ifme.Properties.Resources.icon16_add;
            this.btnSubAdd.Location = new System.Drawing.Point(3, 3);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(24, 24);
            this.btnSubAdd.TabIndex = 0;
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // tabAttachment
            // 
            this.tabAttachment.Controls.Add(this.pnlAttachment);
            this.tabAttachment.Location = new System.Drawing.Point(4, 22);
            this.tabAttachment.Name = "tabAttachment";
            this.tabAttachment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttachment.Size = new System.Drawing.Size(868, 305);
            this.tabAttachment.TabIndex = 4;
            this.tabAttachment.Text = "Attachments";
            this.tabAttachment.UseVisualStyleBackColor = true;
            // 
            // pnlAttachment
            // 
            this.pnlAttachment.Controls.Add(this.btnAttchAdd2);
            this.pnlAttachment.Controls.Add(this.cboAttachMime);
            this.pnlAttachment.Controls.Add(this.lblAttachMime);
            this.pnlAttachment.Controls.Add(this.lstAttach);
            this.pnlAttachment.Controls.Add(this.btnAttachDel);
            this.pnlAttachment.Controls.Add(this.btnAttachAdd);
            this.pnlAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttachment.Location = new System.Drawing.Point(3, 3);
            this.pnlAttachment.Name = "pnlAttachment";
            this.pnlAttachment.Size = new System.Drawing.Size(862, 299);
            this.pnlAttachment.TabIndex = 0;
            // 
            // btnAttchAdd2
            // 
            this.btnAttchAdd2.Image = global::ifme.Properties.Resources.icon16_add2;
            this.btnAttchAdd2.Location = new System.Drawing.Point(33, 3);
            this.btnAttchAdd2.Name = "btnAttchAdd2";
            this.btnAttchAdd2.Size = new System.Drawing.Size(24, 24);
            this.btnAttchAdd2.TabIndex = 1;
            this.btnAttchAdd2.UseVisualStyleBackColor = true;
            this.btnAttchAdd2.Click += new System.EventHandler(this.btnAttchAdd2_Click);
            // 
            // cboAttachMime
            // 
            this.cboAttachMime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAttachMime.FormattingEnabled = true;
            this.cboAttachMime.Location = new System.Drawing.Point(3, 272);
            this.cboAttachMime.Name = "cboAttachMime";
            this.cboAttachMime.Size = new System.Drawing.Size(856, 21);
            this.cboAttachMime.TabIndex = 5;
            this.cboAttachMime.SelectedIndexChanged += new System.EventHandler(this.cboAttachMime_SelectedIndexChanged);
            this.cboAttachMime.Leave += new System.EventHandler(this.MediaApply);
            // 
            // lblAttachMime
            // 
            this.lblAttachMime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttachMime.Location = new System.Drawing.Point(3, 248);
            this.lblAttachMime.Name = "lblAttachMime";
            this.lblAttachMime.Size = new System.Drawing.Size(856, 21);
            this.lblAttachMime.TabIndex = 4;
            this.lblAttachMime.Text = "&MIME Type:";
            this.lblAttachMime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstAttach
            // 
            this.lstAttach.AllowDrop = true;
            this.lstAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAttach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAttachId,
            this.colAttachFileName,
            this.colAttachMime});
            this.lstAttach.FullRowSelect = true;
            this.lstAttach.HideSelection = false;
            this.lstAttach.Location = new System.Drawing.Point(3, 33);
            this.lstAttach.Name = "lstAttach";
            this.lstAttach.Size = new System.Drawing.Size(856, 212);
            this.lstAttach.TabIndex = 3;
            this.lstAttach.UseCompatibleStateImageBehavior = false;
            this.lstAttach.View = System.Windows.Forms.View.Details;
            this.lstAttach.SelectedIndexChanged += new System.EventHandler(this.lstAttach_SelectedIndexChanged);
            this.lstAttach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAttach_DragDrop);
            this.lstAttach.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAttach_DragEnter);
            this.lstAttach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewItem_KeyDown);
            // 
            // colAttachId
            // 
            this.colAttachId.Text = "Id";
            this.colAttachId.Width = 50;
            // 
            // colAttachFileName
            // 
            this.colAttachFileName.Text = "File name";
            this.colAttachFileName.Width = 562;
            // 
            // colAttachMime
            // 
            this.colAttachMime.Text = "MIME";
            this.colAttachMime.Width = 220;
            // 
            // btnAttachDel
            // 
            this.btnAttachDel.Image = global::ifme.Properties.Resources.icon16_del;
            this.btnAttachDel.Location = new System.Drawing.Point(63, 3);
            this.btnAttachDel.Name = "btnAttachDel";
            this.btnAttachDel.Size = new System.Drawing.Size(24, 24);
            this.btnAttachDel.TabIndex = 2;
            this.btnAttachDel.UseVisualStyleBackColor = true;
            this.btnAttachDel.Click += new System.EventHandler(this.btnAttachDel_Click);
            // 
            // btnAttachAdd
            // 
            this.btnAttachAdd.Image = global::ifme.Properties.Resources.icon16_add;
            this.btnAttachAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAttachAdd.Name = "btnAttachAdd";
            this.btnAttachAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAttachAdd.TabIndex = 0;
            this.btnAttachAdd.UseVisualStyleBackColor = true;
            this.btnAttachAdd.Click += new System.EventHandler(this.btnAttachAdd_Click);
            // 
            // tabAdvance
            // 
            this.tabAdvance.Controls.Add(this.pnlDecoder);
            this.tabAdvance.Location = new System.Drawing.Point(4, 22);
            this.tabAdvance.Name = "tabAdvance";
            this.tabAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvance.Size = new System.Drawing.Size(868, 305);
            this.tabAdvance.TabIndex = 5;
            this.tabAdvance.Text = "Advance";
            this.tabAdvance.UseVisualStyleBackColor = true;
            // 
            // pnlDecoder
            // 
            this.pnlDecoder.Controls.Add(this.chkAdvTrim);
            this.pnlDecoder.Controls.Add(this.grpAdvTrim);
            this.pnlDecoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDecoder.Location = new System.Drawing.Point(3, 3);
            this.pnlDecoder.Name = "pnlDecoder";
            this.pnlDecoder.Size = new System.Drawing.Size(862, 299);
            this.pnlDecoder.TabIndex = 0;
            // 
            // chkAdvTrim
            // 
            this.chkAdvTrim.AutoSize = true;
            this.chkAdvTrim.Location = new System.Drawing.Point(12, 3);
            this.chkAdvTrim.Name = "chkAdvTrim";
            this.chkAdvTrim.Size = new System.Drawing.Size(115, 17);
            this.chkAdvTrim.TabIndex = 0;
            this.chkAdvTrim.Text = "&Trim Video && Audio";
            this.chkAdvTrim.UseVisualStyleBackColor = true;
            this.chkAdvTrim.CheckedChanged += new System.EventHandler(this.chkAdvTrim_CheckedChanged);
            this.chkAdvTrim.Leave += new System.EventHandler(this.MediaApply);
            // 
            // grpAdvTrim
            // 
            this.grpAdvTrim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdvTrim.Controls.Add(this.mtxAdvTimeDuration);
            this.grpAdvTrim.Controls.Add(this.mtxAdvTimeEnd);
            this.grpAdvTrim.Controls.Add(this.mtxAdvTimeStart);
            this.grpAdvTrim.Controls.Add(this.lblAdvTimeEqual);
            this.grpAdvTrim.Controls.Add(this.lblAdvTimeUntil);
            this.grpAdvTrim.Controls.Add(this.lblAdvTimeEnd);
            this.grpAdvTrim.Controls.Add(this.lblAdvTimeDuration);
            this.grpAdvTrim.Controls.Add(this.lblAdvTimeStart);
            this.grpAdvTrim.Enabled = false;
            this.grpAdvTrim.Location = new System.Drawing.Point(3, 3);
            this.grpAdvTrim.Name = "grpAdvTrim";
            this.grpAdvTrim.Size = new System.Drawing.Size(856, 100);
            this.grpAdvTrim.TabIndex = 1;
            this.grpAdvTrim.TabStop = false;
            // 
            // mtxAdvTimeDuration
            // 
            this.mtxAdvTimeDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxAdvTimeDuration.Culture = new System.Globalization.CultureInfo("");
            this.mtxAdvTimeDuration.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mtxAdvTimeDuration.Location = new System.Drawing.Point(512, 51);
            this.mtxAdvTimeDuration.Mask = "00:00:00";
            this.mtxAdvTimeDuration.Name = "mtxAdvTimeDuration";
            this.mtxAdvTimeDuration.Size = new System.Drawing.Size(100, 22);
            this.mtxAdvTimeDuration.TabIndex = 7;
            this.mtxAdvTimeDuration.Text = "000000";
            this.mtxAdvTimeDuration.Leave += new System.EventHandler(this.txtAdvTrim_Leave);
            // 
            // mtxAdvTimeEnd
            // 
            this.mtxAdvTimeEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxAdvTimeEnd.Culture = new System.Globalization.CultureInfo("");
            this.mtxAdvTimeEnd.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mtxAdvTimeEnd.Location = new System.Drawing.Point(378, 51);
            this.mtxAdvTimeEnd.Mask = "00:00:00";
            this.mtxAdvTimeEnd.Name = "mtxAdvTimeEnd";
            this.mtxAdvTimeEnd.Size = new System.Drawing.Size(100, 22);
            this.mtxAdvTimeEnd.TabIndex = 4;
            this.mtxAdvTimeEnd.Text = "000000";
            this.mtxAdvTimeEnd.Leave += new System.EventHandler(this.txtAdvTrim_Leave);
            // 
            // mtxAdvTimeStart
            // 
            this.mtxAdvTimeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxAdvTimeStart.Culture = new System.Globalization.CultureInfo("");
            this.mtxAdvTimeStart.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mtxAdvTimeStart.Location = new System.Drawing.Point(244, 51);
            this.mtxAdvTimeStart.Mask = "90:00:00";
            this.mtxAdvTimeStart.Name = "mtxAdvTimeStart";
            this.mtxAdvTimeStart.Size = new System.Drawing.Size(100, 22);
            this.mtxAdvTimeStart.TabIndex = 1;
            this.mtxAdvTimeStart.Text = "000000";
            this.mtxAdvTimeStart.Leave += new System.EventHandler(this.txtAdvTrim_Leave);
            // 
            // lblAdvTimeEqual
            // 
            this.lblAdvTimeEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvTimeEqual.Location = new System.Drawing.Point(484, 51);
            this.lblAdvTimeEqual.Name = "lblAdvTimeEqual";
            this.lblAdvTimeEqual.Size = new System.Drawing.Size(22, 22);
            this.lblAdvTimeEqual.TabIndex = 5;
            this.lblAdvTimeEqual.Text = "=";
            this.lblAdvTimeEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdvTimeUntil
            // 
            this.lblAdvTimeUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvTimeUntil.Location = new System.Drawing.Point(350, 51);
            this.lblAdvTimeUntil.Name = "lblAdvTimeUntil";
            this.lblAdvTimeUntil.Size = new System.Drawing.Size(22, 22);
            this.lblAdvTimeUntil.TabIndex = 2;
            this.lblAdvTimeUntil.Text = ">";
            this.lblAdvTimeUntil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdvTimeEnd
            // 
            this.lblAdvTimeEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvTimeEnd.Location = new System.Drawing.Point(378, 26);
            this.lblAdvTimeEnd.Name = "lblAdvTimeEnd";
            this.lblAdvTimeEnd.Size = new System.Drawing.Size(100, 22);
            this.lblAdvTimeEnd.TabIndex = 3;
            this.lblAdvTimeEnd.Text = "&End:";
            this.lblAdvTimeEnd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAdvTimeDuration
            // 
            this.lblAdvTimeDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvTimeDuration.Location = new System.Drawing.Point(512, 26);
            this.lblAdvTimeDuration.Name = "lblAdvTimeDuration";
            this.lblAdvTimeDuration.Size = new System.Drawing.Size(100, 22);
            this.lblAdvTimeDuration.TabIndex = 6;
            this.lblAdvTimeDuration.Text = "&Duration:";
            this.lblAdvTimeDuration.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAdvTimeStart
            // 
            this.lblAdvTimeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvTimeStart.Location = new System.Drawing.Point(244, 26);
            this.lblAdvTimeStart.Name = "lblAdvTimeStart";
            this.lblAdvTimeStart.Size = new System.Drawing.Size(100, 22);
            this.lblAdvTimeStart.TabIndex = 0;
            this.lblAdvTimeStart.Text = "&Start:";
            this.lblAdvTimeStart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFolderOutput
            // 
            this.txtFolderOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderOutput.BackColor = System.Drawing.Color.White;
            this.txtFolderOutput.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFolderOutput.ForeColor = System.Drawing.Color.Black;
            this.txtFolderOutput.Location = new System.Drawing.Point(168, 665);
            this.txtFolderOutput.Name = "txtFolderOutput";
            this.txtFolderOutput.Size = new System.Drawing.Size(690, 22);
            this.txtFolderOutput.TabIndex = 20;
            this.txtFolderOutput.TextChanged += new System.EventHandler(this.txtFolderOutput_TextChanged);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputFolder.Location = new System.Drawing.Point(12, 664);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(150, 23);
            this.lblOutputFolder.TabIndex = 19;
            this.lblOutputFolder.Text = "&Destination:";
            this.lblOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseFolderOutput
            // 
            this.btnBrowseFolderOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFolderOutput.Image = global::ifme.Properties.Resources.icon16_disk_save;
            this.btnBrowseFolderOutput.Location = new System.Drawing.Point(864, 664);
            this.btnBrowseFolderOutput.Name = "btnBrowseFolderOutput";
            this.btnBrowseFolderOutput.Size = new System.Drawing.Size(24, 24);
            this.btnBrowseFolderOutput.TabIndex = 21;
            this.btnBrowseFolderOutput.UseVisualStyleBackColor = true;
            this.btnBrowseFolderOutput.Click += new System.EventHandler(this.btnBrowseFolderOutput_Click);
            // 
            // lblEncodingPreset
            // 
            this.lblEncodingPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEncodingPreset.Location = new System.Drawing.Point(12, 637);
            this.lblEncodingPreset.Name = "lblEncodingPreset";
            this.lblEncodingPreset.Size = new System.Drawing.Size(150, 22);
            this.lblEncodingPreset.TabIndex = 16;
            this.lblEncodingPreset.Text = "Encoding &Preset:";
            this.lblEncodingPreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEncodingPreset
            // 
            this.cboEncodingPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEncodingPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncodingPreset.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cboEncodingPreset.FormattingEnabled = true;
            this.cboEncodingPreset.Location = new System.Drawing.Point(168, 637);
            this.cboEncodingPreset.Name = "cboEncodingPreset";
            this.cboEncodingPreset.Size = new System.Drawing.Size(690, 22);
            this.cboEncodingPreset.TabIndex = 17;
            this.cboEncodingPreset.SelectedIndexChanged += new System.EventHandler(this.cboEncodingPreset_SelectedIndexChanged);
            // 
            // btnEncodingPresetSave
            // 
            this.btnEncodingPresetSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncodingPresetSave.Image = global::ifme.Properties.Resources.icon16_bookmarks;
            this.btnEncodingPresetSave.Location = new System.Drawing.Point(864, 636);
            this.btnEncodingPresetSave.Name = "btnEncodingPresetSave";
            this.btnEncodingPresetSave.Size = new System.Drawing.Size(24, 24);
            this.btnEncodingPresetSave.TabIndex = 18;
            this.btnEncodingPresetSave.UseVisualStyleBackColor = true;
            this.btnEncodingPresetSave.Click += new System.EventHandler(this.btnEncodingPresetSave_Click);
            // 
            // lblSplit1
            // 
            this.lblSplit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplit1.Font = new System.Drawing.Font("Tahoma", 6F);
            this.lblSplit1.Location = new System.Drawing.Point(88, 76);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(2, 32);
            this.lblSplit1.TabIndex = 2;
            // 
            // lblSplit2
            // 
            this.lblSplit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplit2.Font = new System.Drawing.Font("Tahoma", 6F);
            this.lblSplit2.Location = new System.Drawing.Point(772, 76);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(2, 32);
            this.lblSplit2.TabIndex = 10;
            // 
            // pbxBanner
            // 
            this.pbxBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBanner.BackColor = System.Drawing.Color.Black;
            this.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBanner.Location = new System.Drawing.Point(0, 0);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(900, 64);
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            this.pbxBanner.Resize += new System.EventHandler(this.pbxBanner_Resize);
            // 
            // btnDonePowerOff
            // 
            this.btnDonePowerOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonePowerOff.Image = global::ifme.Properties.Resources.icon22_off_ok;
            this.btnDonePowerOff.Location = new System.Drawing.Point(734, 76);
            this.btnDonePowerOff.Name = "btnDonePowerOff";
            this.btnDonePowerOff.Size = new System.Drawing.Size(32, 32);
            this.btnDonePowerOff.TabIndex = 9;
            this.btnDonePowerOff.UseVisualStyleBackColor = true;
            this.btnDonePowerOff.Click += new System.EventHandler(this.btnDonePowerOff_Click);
            // 
            // btnOption
            // 
            this.btnOption.Image = global::ifme.Properties.Resources.icon22_preferences;
            this.btnOption.Location = new System.Drawing.Point(96, 76);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(32, 32);
            this.btnOption.TabIndex = 3;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::ifme.Properties.Resources.icon22_stop;
            this.btnStop.Location = new System.Drawing.Point(856, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 13;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::ifme.Properties.Resources.icon22_pause;
            this.btnPause.Location = new System.Drawing.Point(818, 76);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 32);
            this.btnPause.TabIndex = 12;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Image = global::ifme.Properties.Resources.icon22_play;
            this.btnStart.Location = new System.Drawing.Point(780, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.TabIndex = 11;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMediaMoveDown
            // 
            this.btnMediaMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMediaMoveDown.Image = global::ifme.Properties.Resources.icon22_down;
            this.btnMediaMoveDown.Location = new System.Drawing.Point(453, 76);
            this.btnMediaMoveDown.Name = "btnMediaMoveDown";
            this.btnMediaMoveDown.Size = new System.Drawing.Size(32, 32);
            this.btnMediaMoveDown.TabIndex = 7;
            this.btnMediaMoveDown.UseVisualStyleBackColor = true;
            this.btnMediaMoveDown.Click += new System.EventHandler(this.btnMediaMoveDown_Click);
            // 
            // btnMediaMoveUp
            // 
            this.btnMediaMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMediaMoveUp.Image = global::ifme.Properties.Resources.icon22_up;
            this.btnMediaMoveUp.Location = new System.Drawing.Point(415, 76);
            this.btnMediaMoveUp.Name = "btnMediaMoveUp";
            this.btnMediaMoveUp.Size = new System.Drawing.Size(32, 32);
            this.btnMediaMoveUp.TabIndex = 6;
            this.btnMediaMoveUp.UseVisualStyleBackColor = true;
            this.btnMediaMoveUp.Click += new System.EventHandler(this.btnMediaMoveUp_Click);
            // 
            // btnMediaFileDel
            // 
            this.btnMediaFileDel.Image = global::ifme.Properties.Resources.icon22_del;
            this.btnMediaFileDel.Location = new System.Drawing.Point(50, 76);
            this.btnMediaFileDel.Name = "btnMediaFileDel";
            this.btnMediaFileDel.Size = new System.Drawing.Size(32, 32);
            this.btnMediaFileDel.TabIndex = 1;
            this.btnMediaFileDel.UseVisualStyleBackColor = true;
            this.btnMediaFileDel.Click += new System.EventHandler(this.btnMediaFileDel_Click);
            // 
            // btnMediaFileOpen
            // 
            this.btnMediaFileOpen.Image = global::ifme.Properties.Resources.icon22_add;
            this.btnMediaFileOpen.Location = new System.Drawing.Point(12, 76);
            this.btnMediaFileOpen.Name = "btnMediaFileOpen";
            this.btnMediaFileOpen.Size = new System.Drawing.Size(32, 32);
            this.btnMediaFileOpen.TabIndex = 0;
            this.btnMediaFileOpen.UseVisualStyleBackColor = true;
            this.btnMediaFileOpen.Click += new System.EventHandler(this.btnMediaFileOpen_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ifme.Properties.Resources.icon22_help_about;
            this.btnAbout.Location = new System.Drawing.Point(134, 76);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(32, 32);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // cmsNewImport
            // 
            this.cmsNewImport.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmsNewImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSeparator1,
            this.tsmiImport,
            this.tsmiImportFolder,
            this.tsmiSeparator2,
            this.tsmiProjectNew,
            this.tsmiProjectOpen,
            this.tsmiProjectSave,
            this.tsmiProjectSaveAs});
            this.cmsNewImport.Name = "cmsNewImport";
            this.cmsNewImport.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsNewImport.Size = new System.Drawing.Size(179, 170);
            // 
            // tsmiNew
            // 
            this.tsmiNew.Image = global::ifme.Properties.Resources.icon16_bookmark_new;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiNew.Size = new System.Drawing.Size(178, 22);
            this.tsmiNew.Text = "N&ew";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiSeparator1
            // 
            this.tsmiSeparator1.Name = "tsmiSeparator1";
            this.tsmiSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiImport
            // 
            this.tsmiImport.Image = global::ifme.Properties.Resources.icon16_document_import;
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiImport.Size = new System.Drawing.Size(178, 22);
            this.tsmiImport.Text = "Import &Files";
            this.tsmiImport.Click += new System.EventHandler(this.tsmiImport_Click);
            // 
            // tsmiImportFolder
            // 
            this.tsmiImportFolder.Image = global::ifme.Properties.Resources.icon16_folder;
            this.tsmiImportFolder.Name = "tsmiImportFolder";
            this.tsmiImportFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiImportFolder.Size = new System.Drawing.Size(178, 22);
            this.tsmiImportFolder.Text = "Import Fol&der";
            this.tsmiImportFolder.Click += new System.EventHandler(this.tsmiImportFolder_Click);
            // 
            // tsmiSeparator2
            // 
            this.tsmiSeparator2.Name = "tsmiSeparator2";
            this.tsmiSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiProjectNew
            // 
            this.tsmiProjectNew.Image = global::ifme.Properties.Resources.icon16_add2;
            this.tsmiProjectNew.Name = "tsmiProjectNew";
            this.tsmiProjectNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiProjectNew.Size = new System.Drawing.Size(178, 22);
            this.tsmiProjectNew.Text = "New &Project";
            this.tsmiProjectNew.Click += new System.EventHandler(this.tsmiProjectNew_Click);
            // 
            // tsmiProjectOpen
            // 
            this.tsmiProjectOpen.Image = global::ifme.Properties.Resources.icon16_folder_explore;
            this.tsmiProjectOpen.Name = "tsmiProjectOpen";
            this.tsmiProjectOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiProjectOpen.Size = new System.Drawing.Size(178, 22);
            this.tsmiProjectOpen.Text = "&Open Project";
            this.tsmiProjectOpen.Click += new System.EventHandler(this.tsmiProjectOpen_Click);
            // 
            // tsmiProjectSave
            // 
            this.tsmiProjectSave.Image = global::ifme.Properties.Resources.icon16_document_save;
            this.tsmiProjectSave.Name = "tsmiProjectSave";
            this.tsmiProjectSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiProjectSave.Size = new System.Drawing.Size(178, 22);
            this.tsmiProjectSave.Text = "&Save Project";
            this.tsmiProjectSave.Click += new System.EventHandler(this.tsmiProjectSave_Click);
            // 
            // tsmiProjectSaveAs
            // 
            this.tsmiProjectSaveAs.Name = "tsmiProjectSaveAs";
            this.tsmiProjectSaveAs.Size = new System.Drawing.Size(178, 22);
            this.tsmiProjectSaveAs.Text = "Save Project &As";
            this.tsmiProjectSaveAs.Click += new System.EventHandler(this.tsmiProjectSaveAs_Click);
            // 
            // cmsEncodingPreset
            // 
            this.cmsEncodingPreset.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmsEncodingPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEncodingPresetSave,
            this.tsmiEncodingPresetSaveAs});
            this.cmsEncodingPreset.Name = "cmsEncodingPreset";
            this.cmsEncodingPreset.Size = new System.Drawing.Size(114, 48);
            // 
            // tsmiEncodingPresetSave
            // 
            this.tsmiEncodingPresetSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEncodingPresetSave.Image")));
            this.tsmiEncodingPresetSave.Name = "tsmiEncodingPresetSave";
            this.tsmiEncodingPresetSave.Size = new System.Drawing.Size(113, 22);
            this.tsmiEncodingPresetSave.Text = "&Save";
            this.tsmiEncodingPresetSave.Click += new System.EventHandler(this.tsmiEncodingPresetSave_Click);
            // 
            // tsmiEncodingPresetSaveAs
            // 
            this.tsmiEncodingPresetSaveAs.Image = global::ifme.Properties.Resources.icon16_document_save_as;
            this.tsmiEncodingPresetSaveAs.Name = "tsmiEncodingPresetSaveAs";
            this.tsmiEncodingPresetSaveAs.Size = new System.Drawing.Size(113, 22);
            this.tsmiEncodingPresetSaveAs.Text = "Save &As";
            this.tsmiEncodingPresetSaveAs.Click += new System.EventHandler(this.tsmiEncodingPresetSaveAs_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Image = global::ifme.Properties.Resources.icon22_donate;
            this.btnDonate.Location = new System.Drawing.Point(172, 76);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(32, 32);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnBench
            // 
            this.btnBench.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBench.Image = global::ifme.Properties.Resources.icon22_bench;
            this.btnBench.Location = new System.Drawing.Point(696, 76);
            this.btnBench.Name = "btnBench";
            this.btnBench.Size = new System.Drawing.Size(32, 32);
            this.btnBench.TabIndex = 8;
            this.btnBench.UseVisualStyleBackColor = true;
            // 
            // cboTargetFormat
            // 
            this.cboTargetFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTargetFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetFormat.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cboTargetFormat.FormattingEnabled = true;
            this.cboTargetFormat.Items.AddRange(new object[] {
            "Video: AVI (Audio Video Interleave Container) [Microsoft, 1992, OLD!]",
            "Video: MP4 (MPEG-4 Part 14 Container)",
            "Video: MKV (Matroska Multimedia Container)",
            "Video: WEBM (HTML5 WebM Container)",
            "Audio: MP3 (MPEG-2 Audio Layer III)",
            "Audio: MP4 (Advanced Audio Coding)",
            "Audio: OGG (Xiph.Org Foundation Ogg Vorbis)",
            "Audio: OPUS (Xiph.Org Foundation Opus Vorbis)",
            "Audio: FLAC (Xiph.Org Foundation Free Lossless Audio Codec)"});
            this.cboTargetFormat.Location = new System.Drawing.Point(168, 609);
            this.cboTargetFormat.Name = "cboTargetFormat";
            this.cboTargetFormat.Size = new System.Drawing.Size(720, 22);
            this.cboTargetFormat.TabIndex = 22;
            this.cboTargetFormat.SelectedIndexChanged += new System.EventHandler(this.cboTargetFormat_SelectedIndexChanged);
            // 
            // lblTargetFormat
            // 
            this.lblTargetFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetFormat.Location = new System.Drawing.Point(12, 608);
            this.lblTargetFormat.Name = "lblTargetFormat";
            this.lblTargetFormat.Size = new System.Drawing.Size(150, 22);
            this.lblTargetFormat.TabIndex = 23;
            this.lblTargetFormat.Text = "&Output Format:";
            this.lblTargetFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.lblTargetFormat);
            this.Controls.Add(this.cboTargetFormat);
            this.Controls.Add(this.btnBench);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.pbxBanner);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.btnDonePowerOff);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnEncodingPresetSave);
            this.Controls.Add(this.cboEncodingPreset);
            this.Controls.Add(this.lblEncodingPreset);
            this.Controls.Add(this.btnBrowseFolderOutput);
            this.Controls.Add(this.lblOutputFolder);
            this.Controls.Add(this.txtFolderOutput);
            this.Controls.Add(this.tabMediaConfig);
            this.Controls.Add(this.lstMedia);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMediaMoveDown);
            this.Controls.Add(this.btnMediaMoveUp);
            this.Controls.Add(this.btnMediaFileDel);
            this.Controls.Add(this.btnMediaFileOpen);
            this.Controls.Add(this.btnAbout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Friendly Media Encoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tabMediaConfig.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.grpStreamInfo.ResumeLayout(false);
            this.grpStreamInfo.PerformLayout();
            this.tabVideo.ResumeLayout(false);
            this.pnlVideo.ResumeLayout(false);
            this.grpVideoInterlace.ResumeLayout(false);
            this.grpVideoInterlace.PerformLayout();
            this.grpVideoStream.ResumeLayout(false);
            this.grpVideoCodec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoMultiPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoRateFactor)).EndInit();
            this.grpVideoPicture.ResumeLayout(false);
            this.tabAudio.ResumeLayout(false);
            this.pnlAudio.ResumeLayout(false);
            this.grpAudioCodec.ResumeLayout(false);
            this.grpAudioStream.ResumeLayout(false);
            this.tabSubtitle.ResumeLayout(false);
            this.pnlSubtitle.ResumeLayout(false);
            this.tabAttachment.ResumeLayout(false);
            this.pnlAttachment.ResumeLayout(false);
            this.tabAdvance.ResumeLayout(false);
            this.pnlDecoder.ResumeLayout(false);
            this.pnlDecoder.PerformLayout();
            this.grpAdvTrim.ResumeLayout(false);
            this.grpAdvTrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.cmsNewImport.ResumeLayout(false);
            this.cmsEncodingPreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.PictureBox pbxBanner;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnMediaFileOpen;
		private System.Windows.Forms.Button btnMediaFileDel;
		private System.Windows.Forms.Button btnMediaMoveUp;
		private System.Windows.Forms.Button btnMediaMoveDown;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.ListView lstMedia;
		private System.Windows.Forms.ColumnHeader colMediaFileName;
		private System.Windows.Forms.ColumnHeader colMediaDuration;
		private System.Windows.Forms.ColumnHeader colMediaType;
		private System.Windows.Forms.ColumnHeader colMediaTarget;
		private System.Windows.Forms.ColumnHeader colMediaStatus;
		private System.Windows.Forms.TabControl tabMediaConfig;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabVideo;
		private System.Windows.Forms.TabPage tabAudio;
		private System.Windows.Forms.TabPage tabSubtitle;
		private System.Windows.Forms.TabPage tabAttachment;
		private System.Windows.Forms.TextBox txtFolderOutput;
		private System.Windows.Forms.Label lblOutputFolder;
		private System.Windows.Forms.Button btnBrowseFolderOutput;
		private System.Windows.Forms.Label lblEncodingPreset;
		private System.Windows.Forms.ComboBox cboEncodingPreset;
		private System.Windows.Forms.Button btnEncodingPresetSave;
		private System.Windows.Forms.Panel pnlGeneral;
		private System.Windows.Forms.Panel pnlVideo;
		private System.Windows.Forms.Button btnVideoDel;
		private System.Windows.Forms.Button btnVideoAdd;
		private System.Windows.Forms.ListView lstVideo;
		private System.Windows.Forms.Button btnVideoMoveDown;
		private System.Windows.Forms.Button btnVideoMoveUp;
		private System.Windows.Forms.ColumnHeader colVideoId;
		private System.Windows.Forms.GroupBox grpVideoCodec;
		private System.Windows.Forms.GroupBox grpVideoInterlace;
		private System.Windows.Forms.GroupBox grpVideoPicture;
		private System.Windows.Forms.Label lblVideoFrameRate;
		private System.Windows.Forms.Label lblVideoResolution;
		private System.Windows.Forms.ComboBox cboVideoFrameRate;
		private System.Windows.Forms.GroupBox grpVideoStream;
		private System.Windows.Forms.ComboBox cboVideoPixelFormat;
		private System.Windows.Forms.Label lblPixelFormat;
		private System.Windows.Forms.ComboBox cboVideoBitDepth;
		private System.Windows.Forms.Label lblVideoBitDepth;
		private System.Windows.Forms.CheckBox chkVideoDeinterlace;
		private System.Windows.Forms.Panel pnlAudio;
		private System.Windows.Forms.GroupBox grpAudioStream;
		private System.Windows.Forms.ComboBox cboVideoDeinterlaceField;
		private System.Windows.Forms.Label lblVideoDeinterlaceField;
		private System.Windows.Forms.ComboBox cboVideoDeinterlaceMode;
		private System.Windows.Forms.Label lblVideoDeinterlaceMode;
		private System.Windows.Forms.ComboBox cboVideoTune;
		private System.Windows.Forms.Label lblVideoTune;
		private System.Windows.Forms.ComboBox cboVideoPreset;
		private System.Windows.Forms.Label lblVideoPreset;
		private System.Windows.Forms.ComboBox cboVideoEncoder;
		private System.Windows.Forms.Label lblVideoEncoder;
		private System.Windows.Forms.NumericUpDown nudVideoMultiPass;
		private System.Windows.Forms.Label lblVideoMultiPass;
		private System.Windows.Forms.NumericUpDown nudVideoRateFactor;
		private System.Windows.Forms.Label lblVideoRateFactor;
		private System.Windows.Forms.ComboBox cboVideoRateControl;
		private System.Windows.Forms.Label lblVideoRateControl;
		private System.Windows.Forms.Button btnVideoAdv;
		private System.Windows.Forms.ListView lstAudio;
		private System.Windows.Forms.ColumnHeader colAudioId;
		private System.Windows.Forms.Button btnAudioMoveUp;
		private System.Windows.Forms.Button btnAudioMoveDown;
		private System.Windows.Forms.Button btnAudioDel;
		private System.Windows.Forms.Button btnAudioAdd;
		private System.Windows.Forms.GroupBox grpAudioCodec;
		private System.Windows.Forms.ComboBox cboAudioChannel;
		private System.Windows.Forms.Label lblAudioChannel;
		private System.Windows.Forms.ComboBox cboAudioSampleRate;
		private System.Windows.Forms.Label lblAudioSampleRate;
		private System.Windows.Forms.ComboBox cboAudioQuality;
		private System.Windows.Forms.Label lblAudioQuality;
		private System.Windows.Forms.ComboBox cboAudioEncoder;
		private System.Windows.Forms.Label lblAudioEncoder;
		private System.Windows.Forms.Button btnAudioAdv;
		private System.Windows.Forms.Panel pnlSubtitle;
		private System.Windows.Forms.Button btnSubDel;
		private System.Windows.Forms.Button btnSubAdd;
		private System.Windows.Forms.Button btnSubMoveDown;
		private System.Windows.Forms.Button btnSubMoveUp;
		private System.Windows.Forms.ComboBox cboSubLang;
		private System.Windows.Forms.Label lblSubLang;
		private System.Windows.Forms.ListView lstSub;
		private System.Windows.Forms.ColumnHeader colSubFileName;
		private System.Windows.Forms.ColumnHeader colSubLang;
		private System.Windows.Forms.Panel pnlAttachment;
		private System.Windows.Forms.Button btnAttachDel;
		private System.Windows.Forms.Button btnAttachAdd;
		private System.Windows.Forms.ListView lstAttach;
		private System.Windows.Forms.ColumnHeader colAttachFileName;
		private System.Windows.Forms.ColumnHeader colAttachMime;
		private System.Windows.Forms.ComboBox cboAttachMime;
		private System.Windows.Forms.Label lblAttachMime;
		private System.Windows.Forms.Button btnOption;
		private System.Windows.Forms.Button btnDonePowerOff;
		private System.Windows.Forms.Label lblSplit1;
		private System.Windows.Forms.Label lblSplit2;
		private System.Windows.Forms.ComboBox cboAudioMode;
		private System.Windows.Forms.Label lblAudioMode;
		private System.Windows.Forms.ColumnHeader colSubId;
		private System.Windows.Forms.ColumnHeader colVideoInfo;
		private System.Windows.Forms.ComboBox cboVideoResolution;
		private System.Windows.Forms.GroupBox grpStreamInfo;
		private System.Windows.Forms.TextBox txtMediaInfo;
		private System.Windows.Forms.ColumnHeader colAudioLang;
		private System.Windows.Forms.ColumnHeader colAudioInfo;
        private System.Windows.Forms.ContextMenuStrip cmsNewImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiImport;
        private System.Windows.Forms.ContextMenuStrip cmsEncodingPreset;
        private System.Windows.Forms.ToolStripMenuItem tsmiEncodingPresetSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiEncodingPresetSaveAs;
        private System.Windows.Forms.ComboBox cboVideoStreamLang;
        private System.Windows.Forms.ComboBox cboAudioStreamLang;
        private System.Windows.Forms.ColumnHeader colVideoLang;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnAttchAdd2;
        private System.Windows.Forms.Button btnSubAdd2;
        private System.Windows.Forms.Button btnBench;
        private System.Windows.Forms.ColumnHeader colAttachId;
		private System.Windows.Forms.TabPage tabAdvance;
		private System.Windows.Forms.Panel pnlDecoder;
		private System.Windows.Forms.CheckBox chkAdvTrim;
		private System.Windows.Forms.GroupBox grpAdvTrim;
		private System.Windows.Forms.Label lblAdvTimeStart;
		private System.Windows.Forms.Label lblAdvTimeEqual;
		private System.Windows.Forms.Label lblAdvTimeUntil;
		private System.Windows.Forms.Label lblAdvTimeEnd;
		private System.Windows.Forms.Label lblAdvTimeDuration;
		private System.Windows.Forms.MaskedTextBox mtxAdvTimeStart;
		private System.Windows.Forms.MaskedTextBox mtxAdvTimeDuration;
		private System.Windows.Forms.MaskedTextBox mtxAdvTimeEnd;
		private System.Windows.Forms.Button btnVideoAdvDec;
		private System.Windows.Forms.Button btnAudioAdvDec;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportFolder;
        private System.Windows.Forms.CheckBox chkSubHard;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectSave;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparator1;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectSaveAs;
        private System.Windows.Forms.ComboBox cboTargetFormat;
        private System.Windows.Forms.Label lblTargetFormat;
    }
}

