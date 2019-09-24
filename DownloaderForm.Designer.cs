﻿namespace Hipparcos_DB
{
	partial class DownloaderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloaderForm));
			this.progressBarDownloadFile = new System.Windows.Forms.ProgressBar();
			this.progressBarDownloadFiles = new System.Windows.Forms.ProgressBar();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelFilesDownload = new System.Windows.Forms.Label();
			this.labelDownloadStatus = new System.Windows.Forms.Label();
			this.labelDownloadPercent = new System.Windows.Forms.Label();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonStartDownload = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorDownload = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelHost = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxHost = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonEditHost = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRestoreHost = new System.Windows.Forms.ToolStripButton();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBarDownloadFile
			// 
			this.progressBarDownloadFile.Location = new System.Drawing.Point(3, 360);
			this.progressBarDownloadFile.Name = "progressBarDownloadFile";
			this.progressBarDownloadFile.Size = new System.Drawing.Size(490, 13);
			this.progressBarDownloadFile.Step = 1;
			this.progressBarDownloadFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarDownloadFile.TabIndex = 1;
			this.progressBarDownloadFile.Visible = false;
			this.progressBarDownloadFile.MouseEnter += new System.EventHandler(this.ProgressBarDownloadFile_MouseEnter);
			this.progressBarDownloadFile.MouseLeave += new System.EventHandler(this.ProgressBarDownloadFile_MouseLeave);
			// 
			// progressBarDownloadFiles
			// 
			this.progressBarDownloadFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBarDownloadFiles.Location = new System.Drawing.Point(3, 16);
			this.progressBarDownloadFiles.Name = "progressBarDownloadFiles";
			this.progressBarDownloadFiles.Size = new System.Drawing.Size(490, 13);
			this.progressBarDownloadFiles.Step = 1;
			this.progressBarDownloadFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarDownloadFiles.TabIndex = 3;
			this.progressBarDownloadFiles.MouseEnter += new System.EventHandler(this.ProgressBarDownloadFiles_MouseEnter);
			this.progressBarDownloadFiles.MouseLeave += new System.EventHandler(this.ProgressBarDownloadFiles_MouseLeave);
			// 
			// textBox
			// 
			this.textBox.AcceptsReturn = true;
			this.textBox.AcceptsTab = true;
			this.tableLayoutPanel.SetColumnSpan(this.textBox, 2);
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(3, 35);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.Size = new System.Drawing.Size(548, 319);
			this.textBox.TabIndex = 5;
			this.textBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox.Leave += new System.EventHandler(this.TextBox_Leave);
			this.textBox.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.textBox.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel.Controls.Add(this.labelFilesDownload, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.textBox, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.progressBarDownloadFiles, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelDownloadStatus, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.progressBarDownloadFile, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.labelDownloadPercent, 1, 4);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 5;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(554, 385);
			this.tableLayoutPanel.TabIndex = 4;
			// 
			// labelFilesDownload
			// 
			this.labelFilesDownload.AutoSize = true;
			this.labelFilesDownload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFilesDownload.Location = new System.Drawing.Point(499, 13);
			this.labelFilesDownload.Name = "labelFilesDownload";
			this.labelFilesDownload.Size = new System.Drawing.Size(52, 19);
			this.labelFilesDownload.TabIndex = 4;
			this.labelFilesDownload.Text = "00 / 99";
			this.labelFilesDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelFilesDownload.Enter += new System.EventHandler(this.LabelFilesDownload_Enter);
			this.labelFilesDownload.Leave += new System.EventHandler(this.LabelFilesDownload_Leave);
			this.labelFilesDownload.MouseEnter += new System.EventHandler(this.LabelFilesDownload_MouseEnter);
			this.labelFilesDownload.MouseLeave += new System.EventHandler(this.LabelFilesDownload_MouseLeave);
			// 
			// labelDownlaodStatus
			// 
			this.labelDownloadStatus.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.labelDownloadStatus, 2);
			this.labelDownloadStatus.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDownloadStatus.Location = new System.Drawing.Point(3, 0);
			this.labelDownloadStatus.Name = "labelDownlaodStatus";
			this.labelDownloadStatus.Size = new System.Drawing.Size(548, 13);
			this.labelDownloadStatus.TabIndex = 0;
			this.labelDownloadStatus.Text = "Click the button \"Start download\" to begin";
			this.labelDownloadStatus.Enter += new System.EventHandler(this.LabelDownlaodStatus_Enter);
			this.labelDownloadStatus.Leave += new System.EventHandler(this.LabelDownlaodStatus_Leave);
			this.labelDownloadStatus.MouseEnter += new System.EventHandler(this.LabelDownlaodStatus_MouseEnter);
			this.labelDownloadStatus.MouseLeave += new System.EventHandler(this.LabelDownlaodStatus_MouseLeave);
			// 
			// labelDownloadPercent
			// 
			this.labelDownloadPercent.AutoSize = true;
			this.labelDownloadPercent.Location = new System.Drawing.Point(499, 357);
			this.labelDownloadPercent.Name = "labelDownloadPercent";
			this.labelDownloadPercent.Size = new System.Drawing.Size(36, 13);
			this.labelDownloadPercent.TabIndex = 2;
			this.labelDownloadPercent.Text = "100 %";
			this.labelDownloadPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDownloadPercent.Visible = false;
			this.labelDownloadPercent.Enter += new System.EventHandler(this.LabelDownloadPercent_Enter);
			this.labelDownloadPercent.Leave += new System.EventHandler(this.LabelDownloadPercent_Leave);
			this.labelDownloadPercent.MouseEnter += new System.EventHandler(this.LabelDownloadPercent_MouseEnter);
			this.labelDownloadPercent.MouseLeave += new System.EventHandler(this.LabelDownloadPercent_MouseLeave);
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(554, 385);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(554, 432);
			this.toolStripContainer.TabIndex = 6;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(554, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleDescription = "text with some information";
			this.toolStripStatusLabel.AccessibleName = "information text";
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.DoubleClickEnabled = true;
			this.toolStripStatusLabel.Image = global::Hipparcos_DB.Properties.Resources.fugue_information_white_16px_shadowless;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
			this.toolStripStatusLabel.Text = "info text";
			this.toolStripStatusLabel.ToolTipText = "info text";
			this.toolStripStatusLabel.MouseEnter += new System.EventHandler(this.ToolStripStatusLabel_MouseEnter);
			this.toolStripStatusLabel.MouseLeave += new System.EventHandler(this.ToolStripStatusLabel_MouseLeave);
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStartDownload,
            this.toolStripSeparatorDownload,
            this.toolStripLabelHost,
            this.toolStripTextBoxHost,
            this.toolStripButtonEditHost,
            this.toolStripButtonRestoreHost});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(554, 25);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			// 
			// toolStripButtonStartDownload
			// 
			this.toolStripButtonStartDownload.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.toolStripButtonStartDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStartDownload.Name = "toolStripButtonStartDownload";
			this.toolStripButtonStartDownload.Size = new System.Drawing.Size(107, 22);
			this.toolStripButtonStartDownload.Text = "&Start download";
			this.toolStripButtonStartDownload.Click += new System.EventHandler(this.ToolStripButtonStartDownload_Click);
			this.toolStripButtonStartDownload.MouseEnter += new System.EventHandler(this.ToolStripButtonStartDownload_MouseEnter);
			this.toolStripButtonStartDownload.MouseLeave += new System.EventHandler(this.ToolStripButtonStartDownload_MouseLeave);
			// 
			// toolStripSeparatorDownload
			// 
			this.toolStripSeparatorDownload.Name = "toolStripSeparatorDownload";
			this.toolStripSeparatorDownload.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabelHost
			// 
			this.toolStripLabelHost.Name = "toolStripLabelHost";
			this.toolStripLabelHost.Size = new System.Drawing.Size(35, 22);
			this.toolStripLabelHost.Text = "&Host:";
			this.toolStripLabelHost.MouseEnter += new System.EventHandler(this.ToolStripLabelHost_MouseEnter);
			this.toolStripLabelHost.MouseLeave += new System.EventHandler(this.ToolStripLabelHost_MouseLeave);
			// 
			// toolStripTextBoxHost
			// 
			this.toolStripTextBoxHost.AutoToolTip = true;
			this.toolStripTextBoxHost.BackColor = System.Drawing.SystemColors.Window;
			this.toolStripTextBoxHost.Name = "toolStripTextBoxHost";
			this.toolStripTextBoxHost.Size = new System.Drawing.Size(200, 25);
			this.toolStripTextBoxHost.Enter += new System.EventHandler(this.ToolStripTextBoxHost_Enter);
			this.toolStripTextBoxHost.Leave += new System.EventHandler(this.ToolStripTextBoxHost_Leave);
			this.toolStripTextBoxHost.MouseEnter += new System.EventHandler(this.ToolStripTextBoxHost_MouseEnter);
			this.toolStripTextBoxHost.MouseLeave += new System.EventHandler(this.ToolStripTextBoxHost_MouseLeave);
			// 
			// toolStripButtonEditHost
			// 
			this.toolStripButtonEditHost.Image = global::Hipparcos_DB.Properties.Resources.fugue_pencil_16px_shadowless;
			this.toolStripButtonEditHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditHost.Name = "toolStripButtonEditHost";
			this.toolStripButtonEditHost.Size = new System.Drawing.Size(73, 22);
			this.toolStripButtonEditHost.Text = "&Edit host";
			this.toolStripButtonEditHost.Click += new System.EventHandler(this.ToolStripButtonEditHost_Click);
			this.toolStripButtonEditHost.MouseEnter += new System.EventHandler(this.ToolStripButtonEditHost_MouseEnter);
			this.toolStripButtonEditHost.MouseLeave += new System.EventHandler(this.ToolStripButtonEditHost_MouseLeave);
			// 
			// toolStripButtonRestoreHost
			// 
			this.toolStripButtonRestoreHost.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.toolStripButtonRestoreHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRestoreHost.Name = "toolStripButtonRestoreHost";
			this.toolStripButtonRestoreHost.Size = new System.Drawing.Size(92, 22);
			this.toolStripButtonRestoreHost.Text = "&Restore host";
			this.toolStripButtonRestoreHost.Click += new System.EventHandler(this.ToolStripButtonRestoreHost_Click);
			this.toolStripButtonRestoreHost.MouseEnter += new System.EventHandler(this.ToolStripButtonRestoreHost_MouseEnter);
			this.toolStripButtonRestoreHost.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonRestoreHost_MouseMove);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			// 
			// DownloaderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 432);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DownloaderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DownloaderForm";
			this.Load += new System.EventHandler(this.DownloaderForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBarDownloadFile;
		private System.Windows.Forms.ProgressBar progressBarDownloadFiles;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelFilesDownload;
		private System.Windows.Forms.Label labelDownloadPercent;
		private System.Windows.Forms.Label labelDownloadStatus;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel toolStripLabelHost;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxHost;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditHost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorDownload;
		private System.Windows.Forms.ToolStripButton toolStripButtonStartDownload;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripButton toolStripButtonRestoreHost;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}