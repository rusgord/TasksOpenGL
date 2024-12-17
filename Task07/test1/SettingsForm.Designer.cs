namespace test1
{
    partial class SettingsForm
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
            trbarSpeed = new System.Windows.Forms.TrackBar();
            groupBoxFigure = new System.Windows.Forms.GroupBox();
            labelCy = new System.Windows.Forms.Label();
            labelCx = new System.Windows.Forms.Label();
            chkbxCustomFigure = new System.Windows.Forms.CheckBox();
            nudCy = new System.Windows.Forms.NumericUpDown();
            nudCx = new System.Windows.Forms.NumericUpDown();
            chkbxFloatFigure = new System.Windows.Forms.CheckBox();
            groupBoxSize = new System.Windows.Forms.GroupBox();
            lblSizeH = new System.Windows.Forms.Label();
            lblSizeL = new System.Windows.Forms.Label();
            trbarSize = new System.Windows.Forms.TrackBar();
            groupBoxSpeed = new System.Windows.Forms.GroupBox();
            lblSpeedH = new System.Windows.Forms.Label();
            lblSpeedL = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)trbarSpeed).BeginInit();
            groupBoxFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCx).BeginInit();
            groupBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbarSize).BeginInit();
            groupBoxSpeed.SuspendLayout();
            SuspendLayout();
            // 
            // trbarSpeed
            // 
            trbarSpeed.Location = new System.Drawing.Point(6, 37);
            trbarSpeed.Maximum = 25;
            trbarSpeed.Name = "trbarSpeed";
            trbarSpeed.Size = new System.Drawing.Size(188, 45);
            trbarSpeed.TabIndex = 0;
            // 
            // groupBoxFigure
            // 
            groupBoxFigure.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxFigure.Controls.Add(labelCy);
            groupBoxFigure.Controls.Add(labelCx);
            groupBoxFigure.Controls.Add(chkbxCustomFigure);
            groupBoxFigure.Controls.Add(nudCy);
            groupBoxFigure.Controls.Add(nudCx);
            groupBoxFigure.Controls.Add(chkbxFloatFigure);
            groupBoxFigure.Controls.Add(groupBoxSize);
            groupBoxFigure.Controls.Add(groupBoxSpeed);
            groupBoxFigure.Location = new System.Drawing.Point(12, 12);
            groupBoxFigure.Name = "groupBoxFigure";
            groupBoxFigure.Size = new System.Drawing.Size(454, 210);
            groupBoxFigure.TabIndex = 1;
            groupBoxFigure.TabStop = false;
            groupBoxFigure.Text = "Figure";
            // 
            // labelCy
            // 
            labelCy.AutoSize = true;
            labelCy.Location = new System.Drawing.Point(16, 115);
            labelCy.Name = "labelCy";
            labelCy.Size = new System.Drawing.Size(52, 15);
            labelCy.TabIndex = 9;
            labelCy.Text = "Cy value";
            // 
            // labelCx
            // 
            labelCx.AutoSize = true;
            labelCx.Location = new System.Drawing.Point(16, 92);
            labelCx.Name = "labelCx";
            labelCx.Size = new System.Drawing.Size(52, 15);
            labelCx.TabIndex = 8;
            labelCx.Text = "Cx value";
            // 
            // chkbxCustomFigure
            // 
            chkbxCustomFigure.AutoSize = true;
            chkbxCustomFigure.Location = new System.Drawing.Point(16, 62);
            chkbxCustomFigure.Name = "chkbxCustomFigure";
            chkbxCustomFigure.Size = new System.Drawing.Size(102, 19);
            chkbxCustomFigure.TabIndex = 7;
            chkbxCustomFigure.Text = "Custom figure";
            chkbxCustomFigure.UseVisualStyleBackColor = true;
            chkbxCustomFigure.CheckedChanged += OnChangedCustom;
            // 
            // nudCy
            // 
            nudCy.DecimalPlaces = 1;
            nudCy.Enabled = false;
            nudCy.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudCy.Location = new System.Drawing.Point(100, 113);
            nudCy.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudCy.Name = "nudCy";
            nudCy.Size = new System.Drawing.Size(66, 23);
            nudCy.TabIndex = 6;
            nudCy.Value = new decimal(new int[] { 27015, 0, 0, 327680 });
            // 
            // nudCx
            // 
            nudCx.DecimalPlaces = 1;
            nudCx.Enabled = false;
            nudCx.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudCx.Location = new System.Drawing.Point(100, 90);
            nudCx.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudCx.Name = "nudCx";
            nudCx.Size = new System.Drawing.Size(66, 23);
            nudCx.TabIndex = 5;
            nudCx.Value = new decimal(new int[] { 7, 0, 0, -2147418112 });
            // 
            // chkbxFloatFigure
            // 
            chkbxFloatFigure.AutoSize = true;
            chkbxFloatFigure.Checked = true;
            chkbxFloatFigure.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbxFloatFigure.Location = new System.Drawing.Point(16, 37);
            chkbxFloatFigure.Name = "chkbxFloatFigure";
            chkbxFloatFigure.Size = new System.Drawing.Size(103, 19);
            chkbxFloatFigure.TabIndex = 4;
            chkbxFloatFigure.Text = "Floating figure";
            chkbxFloatFigure.UseVisualStyleBackColor = true;
            chkbxFloatFigure.CheckedChanged += OnChangedFloating;
            // 
            // groupBoxSize
            // 
            groupBoxSize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxSize.Controls.Add(lblSizeH);
            groupBoxSize.Controls.Add(lblSizeL);
            groupBoxSize.Controls.Add(trbarSize);
            groupBoxSize.Location = new System.Drawing.Point(242, 113);
            groupBoxSize.Name = "groupBoxSize";
            groupBoxSize.Size = new System.Drawing.Size(200, 85);
            groupBoxSize.TabIndex = 3;
            groupBoxSize.TabStop = false;
            groupBoxSize.Text = "Size";
            // 
            // lblSizeH
            // 
            lblSizeH.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSizeH.AutoSize = true;
            lblSizeH.Location = new System.Drawing.Point(161, 19);
            lblSizeH.Name = "lblSizeH";
            lblSizeH.Size = new System.Drawing.Size(33, 15);
            lblSizeH.TabIndex = 2;
            lblSizeH.Text = "High";
            // 
            // lblSizeL
            // 
            lblSizeL.AutoSize = true;
            lblSizeL.Location = new System.Drawing.Point(6, 19);
            lblSizeL.Name = "lblSizeL";
            lblSizeL.Size = new System.Drawing.Size(29, 15);
            lblSizeL.TabIndex = 1;
            lblSizeL.Text = "Low";
            // 
            // trbarSize
            // 
            trbarSize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            trbarSize.Location = new System.Drawing.Point(6, 37);
            trbarSize.Maximum = 25;
            trbarSize.Name = "trbarSize";
            trbarSize.Size = new System.Drawing.Size(188, 45);
            trbarSize.TabIndex = 0;
            // 
            // groupBoxSpeed
            // 
            groupBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxSpeed.Controls.Add(lblSpeedH);
            groupBoxSpeed.Controls.Add(lblSpeedL);
            groupBoxSpeed.Controls.Add(trbarSpeed);
            groupBoxSpeed.Location = new System.Drawing.Point(242, 22);
            groupBoxSpeed.Name = "groupBoxSpeed";
            groupBoxSpeed.Size = new System.Drawing.Size(200, 85);
            groupBoxSpeed.TabIndex = 1;
            groupBoxSpeed.TabStop = false;
            groupBoxSpeed.Text = "Speed";
            // 
            // lblSpeedH
            // 
            lblSpeedH.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSpeedH.AutoSize = true;
            lblSpeedH.Location = new System.Drawing.Point(161, 19);
            lblSpeedH.Name = "lblSpeedH";
            lblSpeedH.Size = new System.Drawing.Size(33, 15);
            lblSpeedH.TabIndex = 2;
            lblSpeedH.Text = "High";
            // 
            // lblSpeedL
            // 
            lblSpeedL.AutoSize = true;
            lblSpeedL.Location = new System.Drawing.Point(6, 19);
            lblSpeedL.Name = "lblSpeedL";
            lblSpeedL.Size = new System.Drawing.Size(29, 15);
            lblSpeedL.TabIndex = 1;
            lblSpeedL.Text = "Low";
            // 
            // btnOK
            // 
            btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOK.Location = new System.Drawing.Point(485, 34);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(112, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += OnClickOkBtn;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Location = new System.Drawing.Point(485, 63);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(112, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnClickCancelBtn;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 244);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBoxFigure);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += SettingsFormClosed;
            Load += SettingsFormLoad;
            ((System.ComponentModel.ISupportInitialize)trbarSpeed).EndInit();
            groupBoxFigure.ResumeLayout(false);
            groupBoxFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCx).EndInit();
            groupBoxSize.ResumeLayout(false);
            groupBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbarSize).EndInit();
            groupBoxSpeed.ResumeLayout(false);
            groupBoxSpeed.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TrackBar trbarSpeed;
        private System.Windows.Forms.GroupBox groupBoxFigure;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.Label lblSizeH;
        private System.Windows.Forms.Label lblSizeL;
        private System.Windows.Forms.TrackBar trbarSize;
        private System.Windows.Forms.GroupBox groupBoxSpeed;
        private System.Windows.Forms.Label lblSpeedH;
        private System.Windows.Forms.Label lblSpeedL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkbxFloatFigure;
        private System.Windows.Forms.NumericUpDown nudCy;
        private System.Windows.Forms.NumericUpDown nudCx;
        private System.Windows.Forms.Label labelCy;
        private System.Windows.Forms.Label labelCx;
        private System.Windows.Forms.CheckBox chkbxCustomFigure;
    }
}