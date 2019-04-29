namespace FairShare
{
    partial class FairShareForm
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
			this.chkResults = new System.Windows.Forms.CheckedListBox();
			this.lblGroups = new System.Windows.Forms.Label();
			this.lblPicks = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.numGroups = new System.Windows.Forms.NumericUpDown();
			this.numPicks = new System.Windows.Forms.NumericUpDown();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grpResultsMapping = new System.Windows.Forms.GroupBox();
			this.grpGenerate = new System.Windows.Forms.GroupBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.grpResultsList = new System.Windows.Forms.GroupBox();
			this.grpMapping = new System.Windows.Forms.GroupBox();
			this.tlpMappings = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.numGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPicks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grpResultsMapping.SuspendLayout();
			this.grpGenerate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.grpResultsList.SuspendLayout();
			this.grpMapping.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkResults
			// 
			this.chkResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
			this.chkResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chkResults.CheckOnClick = true;
			this.chkResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkResults.FormattingEnabled = true;
			this.chkResults.Location = new System.Drawing.Point(3, 16);
			this.chkResults.Name = "chkResults";
			this.chkResults.Size = new System.Drawing.Size(131, 305);
			this.chkResults.TabIndex = 2;
			// 
			// lblGroups
			// 
			this.lblGroups.AutoSize = true;
			this.lblGroups.Location = new System.Drawing.Point(9, 19);
			this.lblGroups.Name = "lblGroups";
			this.lblGroups.Size = new System.Drawing.Size(41, 13);
			this.lblGroups.TabIndex = 3;
			this.lblGroups.Text = "Groups";
			// 
			// lblPicks
			// 
			this.lblPicks.AutoSize = true;
			this.lblPicks.Location = new System.Drawing.Point(9, 58);
			this.lblPicks.Name = "lblPicks";
			this.lblPicks.Size = new System.Drawing.Size(33, 13);
			this.lblPicks.TabIndex = 4;
			this.lblPicks.Text = "Picks";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(9, 100);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(64, 23);
			this.btnGenerate.TabIndex = 5;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// numGroups
			// 
			this.numGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numGroups.Location = new System.Drawing.Point(9, 35);
			this.numGroups.Name = "numGroups";
			this.numGroups.Size = new System.Drawing.Size(64, 20);
			this.numGroups.TabIndex = 8;
			this.numGroups.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// numPicks
			// 
			this.numPicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numPicks.Location = new System.Drawing.Point(9, 74);
			this.numPicks.Name = "numPicks";
			this.numPicks.Size = new System.Drawing.Size(64, 20);
			this.numPicks.TabIndex = 9;
			this.numPicks.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grpGenerate);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grpResultsMapping);
			this.splitContainer1.Size = new System.Drawing.Size(368, 345);
			this.splitContainer1.SplitterDistance = 90;
			this.splitContainer1.TabIndex = 10;
			// 
			// grpResultsMapping
			// 
			this.grpResultsMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
			this.grpResultsMapping.Controls.Add(this.splitContainer2);
			this.grpResultsMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpResultsMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.grpResultsMapping.Location = new System.Drawing.Point(0, 0);
			this.grpResultsMapping.Name = "grpResultsMapping";
			this.grpResultsMapping.Size = new System.Drawing.Size(272, 343);
			this.grpResultsMapping.TabIndex = 0;
			this.grpResultsMapping.TabStop = false;
			this.grpResultsMapping.Text = "Results";
			// 
			// grpGenerate
			// 
			this.grpGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
			this.grpGenerate.Controls.Add(this.lblPicks);
			this.grpGenerate.Controls.Add(this.btnGenerate);
			this.grpGenerate.Controls.Add(this.lblGroups);
			this.grpGenerate.Controls.Add(this.numPicks);
			this.grpGenerate.Controls.Add(this.numGroups);
			this.grpGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.grpGenerate.Location = new System.Drawing.Point(0, 0);
			this.grpGenerate.Name = "grpGenerate";
			this.grpGenerate.Size = new System.Drawing.Size(88, 343);
			this.grpGenerate.TabIndex = 10;
			this.grpGenerate.TabStop = false;
			this.grpGenerate.Text = "Generate";
			// 
			// splitContainer2
			// 
			this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(3, 16);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.grpMapping);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.splitContainer2.Panel2.Controls.Add(this.grpResultsList);
			this.splitContainer2.Size = new System.Drawing.Size(266, 324);
			this.splitContainer2.SplitterDistance = 125;
			this.splitContainer2.TabIndex = 0;
			// 
			// grpResultsList
			// 
			this.grpResultsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
			this.grpResultsList.Controls.Add(this.chkResults);
			this.grpResultsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpResultsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.grpResultsList.Location = new System.Drawing.Point(0, 0);
			this.grpResultsList.Name = "grpResultsList";
			this.grpResultsList.Size = new System.Drawing.Size(137, 324);
			this.grpResultsList.TabIndex = 3;
			this.grpResultsList.TabStop = false;
			this.grpResultsList.Text = "Results";
			// 
			// grpMapping
			// 
			this.grpMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(162)))));
			this.grpMapping.Controls.Add(this.tlpMappings);
			this.grpMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.grpMapping.Location = new System.Drawing.Point(0, 0);
			this.grpMapping.Name = "grpMapping";
			this.grpMapping.Size = new System.Drawing.Size(125, 324);
			this.grpMapping.TabIndex = 0;
			this.grpMapping.TabStop = false;
			this.grpMapping.Text = "Mapping";
			// 
			// tlpMappings
			// 
			this.tlpMappings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlpMappings.ColumnCount = 1;
			this.tlpMappings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMappings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMappings.Location = new System.Drawing.Point(3, 16);
			this.tlpMappings.Name = "tlpMappings";
			this.tlpMappings.RowCount = 1;
			this.tlpMappings.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMappings.Size = new System.Drawing.Size(119, 305);
			this.tlpMappings.TabIndex = 0;
			// 
			// FairShareForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 345);
			this.Controls.Add(this.splitContainer1);
			this.DoubleBuffered = true;
			this.Name = "FairShareForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fair Share Sequence Generator";
			((System.ComponentModel.ISupportInitialize)(this.numGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPicks)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grpResultsMapping.ResumeLayout(false);
			this.grpGenerate.ResumeLayout(false);
			this.grpGenerate.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.grpResultsList.ResumeLayout(false);
			this.grpMapping.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.CheckedListBox chkResults;
		private System.Windows.Forms.Label lblGroups;
		private System.Windows.Forms.Label lblPicks;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.NumericUpDown numGroups;
		private System.Windows.Forms.NumericUpDown numPicks;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox grpGenerate;
		private System.Windows.Forms.GroupBox grpResultsMapping;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox grpMapping;
		private System.Windows.Forms.GroupBox grpResultsList;
		private System.Windows.Forms.TableLayoutPanel tlpMappings;
	}
}

