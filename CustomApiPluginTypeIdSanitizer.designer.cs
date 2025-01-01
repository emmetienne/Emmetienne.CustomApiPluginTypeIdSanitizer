using System.Collections.Specialized;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer
{
    partial class CustomApiPluginTypeIdSanitizer
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomApiPluginTypeIdSanitizer));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.sourceEnvironmentConnectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.targetEnvironmentConnectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitLayoutContainer = new System.Windows.Forms.SplitContainer();
            this.solutionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourceSolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.sourceSolutionTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.solutionPathTextBox = new System.Windows.Forms.TextBox();
            this.selectSolutionButton = new System.Windows.Forms.Button();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.sanitizedSolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.sanitizerSolutionSolutionSettings = new System.Windows.Forms.TableLayoutPanel();
            this.destinationPathTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.destinationFolderTextBox = new System.Windows.Forms.TextBox();
            this.sanitizedSolutionExportPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteTempExtractedFileCheckBox = new System.Windows.Forms.CheckBox();
            this.sanitizeButton = new System.Windows.Forms.Button();
            this.logTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.loggingDataGridView = new System.Windows.Forms.DataGridView();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLayoutContainer)).BeginInit();
            this.splitLayoutContainer.Panel1.SuspendLayout();
            this.splitLayoutContainer.Panel2.SuspendLayout();
            this.splitLayoutContainer.SuspendLayout();
            this.solutionTableLayout.SuspendLayout();
            this.sourceSolutionGroupBox.SuspendLayout();
            this.sourceSolutionTableContainer.SuspendLayout();
            this.sanitizedSolutionGroupBox.SuspendLayout();
            this.sanitizerSolutionSolutionSettings.SuspendLayout();
            this.destinationPathTableLayout.SuspendLayout();
            this.logTableLayout.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loggingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceEnvironmentConnectionToolStripButton,
            this.tssSeparator1,
            this.targetEnvironmentConnectionToolStripButton});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1028, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // sourceEnvironmentConnectionToolStripButton
            // 
            this.sourceEnvironmentConnectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sourceEnvironmentConnectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.sourceEnvironmentConnectionToolStripButton.Name = "sourceEnvironmentConnectionToolStripButton";
            this.sourceEnvironmentConnectionToolStripButton.Size = new System.Drawing.Size(179, 22);
            this.sourceEnvironmentConnectionToolStripButton.Text = "Connect to source environment";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // targetEnvironmentConnectionToolStripButton
            // 
            this.targetEnvironmentConnectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.targetEnvironmentConnectionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("targetEnvironmentConnectionToolStripButton.Image")));
            this.targetEnvironmentConnectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.targetEnvironmentConnectionToolStripButton.Name = "targetEnvironmentConnectionToolStripButton";
            this.targetEnvironmentConnectionToolStripButton.Size = new System.Drawing.Size(175, 22);
            this.targetEnvironmentConnectionToolStripButton.Text = "Connect to target environment";
            this.targetEnvironmentConnectionToolStripButton.Click += new System.EventHandler(this.TargetEnvironmentConnectionToolStripButton_Click);
            // 
            // splitLayoutContainer
            // 
            this.splitLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLayoutContainer.Location = new System.Drawing.Point(0, 25);
            this.splitLayoutContainer.Name = "splitLayoutContainer";
            this.splitLayoutContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLayoutContainer.Panel1
            // 
            this.splitLayoutContainer.Panel1.Controls.Add(this.solutionTableLayout);
            // 
            // splitLayoutContainer.Panel2
            // 
            this.splitLayoutContainer.Panel2.Controls.Add(this.logTableLayout);
            this.splitLayoutContainer.Size = new System.Drawing.Size(1028, 583);
            this.splitLayoutContainer.SplitterDistance = 298;
            this.splitLayoutContainer.TabIndex = 5;
            // 
            // solutionTableLayout
            // 
            this.solutionTableLayout.ColumnCount = 1;
            this.solutionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1028F));
            this.solutionTableLayout.Controls.Add(this.sourceSolutionGroupBox, 0, 0);
            this.solutionTableLayout.Controls.Add(this.sanitizedSolutionGroupBox, 0, 1);
            this.solutionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.solutionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.solutionTableLayout.Name = "solutionTableLayout";
            this.solutionTableLayout.RowCount = 2;
            this.solutionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.solutionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.solutionTableLayout.Size = new System.Drawing.Size(1028, 298);
            this.solutionTableLayout.TabIndex = 0;
            // 
            // sourceSolutionGroupBox
            // 
            this.sourceSolutionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sourceSolutionGroupBox.Controls.Add(this.sourceSolutionTableContainer);
            this.sourceSolutionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceSolutionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.sourceSolutionGroupBox.Name = "sourceSolutionGroupBox";
            this.sourceSolutionGroupBox.Size = new System.Drawing.Size(1022, 52);
            this.sourceSolutionGroupBox.TabIndex = 0;
            this.sourceSolutionGroupBox.TabStop = false;
            this.sourceSolutionGroupBox.Text = "Source solution settings";
            // 
            // sourceSolutionTableContainer
            // 
            this.sourceSolutionTableContainer.ColumnCount = 3;
            this.sourceSolutionTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.sourceSolutionTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourceSolutionTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sourceSolutionTableContainer.Controls.Add(this.solutionPathTextBox, 1, 0);
            this.sourceSolutionTableContainer.Controls.Add(this.selectSolutionButton, 2, 0);
            this.sourceSolutionTableContainer.Controls.Add(this.solutionLabel, 0, 0);
            this.sourceSolutionTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceSolutionTableContainer.Location = new System.Drawing.Point(3, 16);
            this.sourceSolutionTableContainer.Name = "sourceSolutionTableContainer";
            this.sourceSolutionTableContainer.RowCount = 1;
            this.sourceSolutionTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sourceSolutionTableContainer.Size = new System.Drawing.Size(1016, 33);
            this.sourceSolutionTableContainer.TabIndex = 0;
            // 
            // solutionPathTextBox
            // 
            this.solutionPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solutionPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionPathTextBox.Location = new System.Drawing.Point(60, 7);
            this.solutionPathTextBox.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.solutionPathTextBox.Name = "solutionPathTextBox";
            this.solutionPathTextBox.Size = new System.Drawing.Size(916, 20);
            this.solutionPathTextBox.TabIndex = 1;
            // 
            // selectSolutionButton
            // 
            this.selectSolutionButton.AutoSize = true;
            this.selectSolutionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectSolutionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectSolutionButton.Location = new System.Drawing.Point(976, 0);
            this.selectSolutionButton.Margin = new System.Windows.Forms.Padding(0);
            this.selectSolutionButton.Name = "selectSolutionButton";
            this.selectSolutionButton.Size = new System.Drawing.Size(40, 33);
            this.selectSolutionButton.TabIndex = 0;
            this.selectSolutionButton.Text = "📂";
            this.selectSolutionButton.UseVisualStyleBackColor = true;
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionLabel.Location = new System.Drawing.Point(3, 0);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(54, 33);
            this.solutionLabel.TabIndex = 2;
            this.solutionLabel.Text = "Solution:";
            this.solutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sanitizedSolutionGroupBox
            // 
            this.sanitizedSolutionGroupBox.Controls.Add(this.sanitizerSolutionSolutionSettings);
            this.sanitizedSolutionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanitizedSolutionGroupBox.Location = new System.Drawing.Point(3, 61);
            this.sanitizedSolutionGroupBox.Name = "sanitizedSolutionGroupBox";
            this.sanitizedSolutionGroupBox.Size = new System.Drawing.Size(1022, 234);
            this.sanitizedSolutionGroupBox.TabIndex = 1;
            this.sanitizedSolutionGroupBox.TabStop = false;
            this.sanitizedSolutionGroupBox.Text = "Sanitized solution settings";
            // 
            // sanitizerSolutionSolutionSettings
            // 
            this.sanitizerSolutionSolutionSettings.ColumnCount = 1;
            this.sanitizerSolutionSolutionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sanitizerSolutionSolutionSettings.Controls.Add(this.destinationPathTableLayout, 0, 0);
            this.sanitizerSolutionSolutionSettings.Controls.Add(this.deleteTempExtractedFileCheckBox, 0, 1);
            this.sanitizerSolutionSolutionSettings.Controls.Add(this.sanitizeButton, 0, 2);
            this.sanitizerSolutionSolutionSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanitizerSolutionSolutionSettings.Location = new System.Drawing.Point(3, 16);
            this.sanitizerSolutionSolutionSettings.Name = "sanitizerSolutionSolutionSettings";
            this.sanitizerSolutionSolutionSettings.RowCount = 4;
            this.sanitizerSolutionSolutionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.sanitizerSolutionSolutionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.sanitizerSolutionSolutionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.sanitizerSolutionSolutionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sanitizerSolutionSolutionSettings.Size = new System.Drawing.Size(1016, 215);
            this.sanitizerSolutionSolutionSettings.TabIndex = 0;
            // 
            // destinationPathTableLayout
            // 
            this.destinationPathTableLayout.ColumnCount = 3;
            this.destinationPathTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.destinationPathTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.destinationPathTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.destinationPathTableLayout.Controls.Add(this.destinationFolderTextBox, 1, 0);
            this.destinationPathTableLayout.Controls.Add(this.sanitizedSolutionExportPathButton, 2, 0);
            this.destinationPathTableLayout.Controls.Add(this.label1, 0, 0);
            this.destinationPathTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationPathTableLayout.Location = new System.Drawing.Point(0, 0);
            this.destinationPathTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.destinationPathTableLayout.Name = "destinationPathTableLayout";
            this.destinationPathTableLayout.RowCount = 1;
            this.destinationPathTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.destinationPathTableLayout.Size = new System.Drawing.Size(1016, 35);
            this.destinationPathTableLayout.TabIndex = 6;
            // 
            // destinationFolderTextBox
            // 
            this.destinationFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinationFolderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationFolderTextBox.Location = new System.Drawing.Point(100, 8);
            this.destinationFolderTextBox.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.destinationFolderTextBox.Name = "destinationFolderTextBox";
            this.destinationFolderTextBox.Size = new System.Drawing.Size(876, 20);
            this.destinationFolderTextBox.TabIndex = 2;
            // 
            // sanitizedSolutionExportPathButton
            // 
            this.sanitizedSolutionExportPathButton.AutoSize = true;
            this.sanitizedSolutionExportPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sanitizedSolutionExportPathButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanitizedSolutionExportPathButton.Location = new System.Drawing.Point(976, 0);
            this.sanitizedSolutionExportPathButton.Margin = new System.Windows.Forms.Padding(0);
            this.sanitizedSolutionExportPathButton.Name = "sanitizedSolutionExportPathButton";
            this.sanitizedSolutionExportPathButton.Size = new System.Drawing.Size(40, 35);
            this.sanitizedSolutionExportPathButton.TabIndex = 3;
            this.sanitizedSolutionExportPathButton.Text = "📂";
            this.sanitizedSolutionExportPathButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteTempExtractedFileCheckBox
            // 
            this.deleteTempExtractedFileCheckBox.AutoSize = true;
            this.deleteTempExtractedFileCheckBox.Checked = true;
            this.deleteTempExtractedFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteTempExtractedFileCheckBox.Location = new System.Drawing.Point(3, 38);
            this.deleteTempExtractedFileCheckBox.Name = "deleteTempExtractedFileCheckBox";
            this.deleteTempExtractedFileCheckBox.Size = new System.Drawing.Size(174, 17);
            this.deleteTempExtractedFileCheckBox.TabIndex = 4;
            this.deleteTempExtractedFileCheckBox.Text = "Delete temporary extracted files";
            this.deleteTempExtractedFileCheckBox.UseVisualStyleBackColor = true;
            this.deleteTempExtractedFileCheckBox.CheckedChanged += new System.EventHandler(this.DeleteTempExtractedFile_CheckedChanged);
            // 
            // sanitizeButton
            // 
            this.sanitizeButton.AutoSize = true;
            this.sanitizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sanitizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanitizeButton.Location = new System.Drawing.Point(0, 70);
            this.sanitizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.sanitizeButton.Name = "sanitizeButton";
            this.sanitizeButton.Size = new System.Drawing.Size(1016, 35);
            this.sanitizeButton.TabIndex = 5;
            this.sanitizeButton.Text = "Sanitize Custom API\'s in solution";
            this.sanitizeButton.UseVisualStyleBackColor = true;
            this.sanitizeButton.Click += new System.EventHandler(this.SanitizeButton_Click);
            // 
            // logTableLayout
            // 
            this.logTableLayout.ColumnCount = 1;
            this.logTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logTableLayout.Controls.Add(this.logGroupBox, 0, 0);
            this.logTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTableLayout.Location = new System.Drawing.Point(0, 0);
            this.logTableLayout.Name = "logTableLayout";
            this.logTableLayout.RowCount = 1;
            this.logTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logTableLayout.Size = new System.Drawing.Size(1028, 281);
            this.logTableLayout.TabIndex = 0;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.loggingDataGridView);
            this.logGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGroupBox.Location = new System.Drawing.Point(3, 3);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(1022, 275);
            this.logGroupBox.TabIndex = 0;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Logs";
            // 
            // loggingDataGridView
            // 
            this.loggingDataGridView.AllowUserToAddRows = false;
            this.loggingDataGridView.AllowUserToDeleteRows = false;
            this.loggingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loggingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.loggingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loggingDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.loggingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestamp,
            this.message,
            this.exception,
            this.severity});
            this.loggingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggingDataGridView.GridColor = System.Drawing.Color.White;
            this.loggingDataGridView.Location = new System.Drawing.Point(3, 16);
            this.loggingDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.loggingDataGridView.Name = "loggingDataGridView";
            this.loggingDataGridView.ReadOnly = true;
            this.loggingDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.loggingDataGridView.RowHeadersVisible = false;
            this.loggingDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loggingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loggingDataGridView.Size = new System.Drawing.Size(1016, 256);
            this.loggingDataGridView.TabIndex = 0;
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "Timestamp";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // exception
            // 
            this.exception.HeaderText = "Exception";
            this.exception.Name = "exception";
            this.exception.ReadOnly = true;
            // 
            // severity
            // 
            this.severity.HeaderText = "Severity";
            this.severity.Name = "severity";
            this.severity.ReadOnly = true;
            // 
            // CustomApiPluginTypeIdSanitizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLayoutContainer);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "CustomApiPluginTypeIdSanitizer";
            this.Size = new System.Drawing.Size(1028, 608);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitLayoutContainer.Panel1.ResumeLayout(false);
            this.splitLayoutContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLayoutContainer)).EndInit();
            this.splitLayoutContainer.ResumeLayout(false);
            this.solutionTableLayout.ResumeLayout(false);
            this.sourceSolutionGroupBox.ResumeLayout(false);
            this.sourceSolutionTableContainer.ResumeLayout(false);
            this.sourceSolutionTableContainer.PerformLayout();
            this.sanitizedSolutionGroupBox.ResumeLayout(false);
            this.sanitizerSolutionSolutionSettings.ResumeLayout(false);
            this.sanitizerSolutionSolutionSettings.PerformLayout();
            this.destinationPathTableLayout.ResumeLayout(false);
            this.destinationPathTableLayout.PerformLayout();
            this.logTableLayout.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loggingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs e)
        {
            return;
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.SplitContainer splitLayoutContainer;
        private System.Windows.Forms.TableLayoutPanel solutionTableLayout;
        private System.Windows.Forms.GroupBox sourceSolutionGroupBox;
        private System.Windows.Forms.GroupBox sanitizedSolutionGroupBox;
        private System.Windows.Forms.TableLayoutPanel sourceSolutionTableContainer;
        private System.Windows.Forms.Button selectSolutionButton;
        private System.Windows.Forms.TextBox solutionPathTextBox;
        private System.Windows.Forms.TableLayoutPanel sanitizerSolutionSolutionSettings;
        private System.Windows.Forms.Button sanitizedSolutionExportPathButton;
        private System.Windows.Forms.TextBox destinationFolderTextBox;
        private System.Windows.Forms.CheckBox deleteTempExtractedFileCheckBox;
        private System.Windows.Forms.Button sanitizeButton;
        private System.Windows.Forms.ToolStripButton sourceEnvironmentConnectionToolStripButton;
        private System.Windows.Forms.ToolStripButton targetEnvironmentConnectionToolStripButton;
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.TableLayoutPanel destinationPathTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel logTableLayout;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.DataGridView loggingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn exception;
        private System.Windows.Forms.DataGridViewTextBoxColumn severity;
    }
}
