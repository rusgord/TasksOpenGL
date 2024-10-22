
namespace Task03
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            nupxmin = new System.Windows.Forms.NumericUpDown();
            nupxmax = new System.Windows.Forms.NumericUpDown();
            nuppoints = new System.Windows.Forms.NumericUpDown();
            lxmin = new System.Windows.Forms.Label();
            lxmax = new System.Windows.Forms.Label();
            lpoints = new System.Windows.Forms.Label();
            showY = new System.Windows.Forms.Button();
            lymin = new System.Windows.Forms.Label();
            nupymin = new System.Windows.Forms.NumericUpDown();
            lymax = new System.Windows.Forms.Label();
            nupymax = new System.Windows.Forms.NumericUpDown();
            func1 = new System.Windows.Forms.RadioButton();
            func2 = new System.Windows.Forms.RadioButton();
            pfunc1 = new System.Windows.Forms.PictureBox();
            pfunc2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)nupxmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupxmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuppoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupymin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupymax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pfunc1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pfunc2).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ChosedFunc = 0;
            renderControl1.CustomChange = false;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(3, 3);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(490, 318);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.XMax = 1.2D;
            renderControl1.XMin = -1.2D;
            renderControl1.YMax = 12.650348738374163D;
            renderControl1.YMin = -4.9394067118565008D;
            // 
            // nupxmin
            // 
            nupxmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nupxmin.DecimalPlaces = 1;
            nupxmin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupxmin.Location = new System.Drawing.Point(604, 25);
            nupxmin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nupxmin.Name = "nupxmin";
            nupxmin.Size = new System.Drawing.Size(51, 23);
            nupxmin.TabIndex = 1;
            nupxmin.Value = new decimal(new int[] { 12, 0, 0, -2147418112 });
            nupxmin.ValueChanged += OnChangedXmin;
            // 
            // nupxmax
            // 
            nupxmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nupxmax.DecimalPlaces = 1;
            nupxmax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupxmax.Location = new System.Drawing.Point(604, 54);
            nupxmax.Name = "nupxmax";
            nupxmax.Size = new System.Drawing.Size(51, 23);
            nupxmax.TabIndex = 2;
            nupxmax.Value = new decimal(new int[] { 12, 0, 0, 65536 });
            nupxmax.ValueChanged += OnChangedXmax;
            // 
            // nuppoints
            // 
            nuppoints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            nuppoints.Location = new System.Drawing.Point(585, 112);
            nuppoints.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nuppoints.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nuppoints.Name = "nuppoints";
            nuppoints.Size = new System.Drawing.Size(70, 23);
            nuppoints.TabIndex = 3;
            nuppoints.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nuppoints.ValueChanged += OnChanged;
            // 
            // lxmin
            // 
            lxmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lxmin.AutoSize = true;
            lxmin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            lxmin.Location = new System.Drawing.Point(517, 28);
            lxmin.Name = "lxmin";
            lxmin.Size = new System.Drawing.Size(43, 20);
            lxmin.TabIndex = 4;
            lxmin.Text = "Xmin";
            // 
            // lxmax
            // 
            lxmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lxmax.AutoSize = true;
            lxmax.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            lxmax.Location = new System.Drawing.Point(517, 57);
            lxmax.Name = "lxmax";
            lxmax.Size = new System.Drawing.Size(46, 20);
            lxmax.TabIndex = 5;
            lxmax.Text = "Xmax";
            // 
            // lpoints
            // 
            lpoints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lpoints.AutoSize = true;
            lpoints.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            lpoints.Location = new System.Drawing.Point(517, 117);
            lpoints.Name = "lpoints";
            lpoints.Size = new System.Drawing.Size(48, 20);
            lpoints.TabIndex = 6;
            lpoints.Text = "Points";
            // 
            // showY
            // 
            showY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            showY.Location = new System.Drawing.Point(517, 83);
            showY.Name = "showY";
            showY.Size = new System.Drawing.Size(138, 23);
            showY.TabIndex = 7;
            showY.Text = "Show Y";
            showY.UseVisualStyleBackColor = true;
            showY.Click += showY_Click;
            // 
            // lymin
            // 
            lymin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lymin.AutoSize = true;
            lymin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            lymin.Location = new System.Drawing.Point(517, 88);
            lymin.Name = "lymin";
            lymin.Size = new System.Drawing.Size(41, 20);
            lymin.TabIndex = 9;
            lymin.Text = "Ymin";
            lymin.Visible = false;
            // 
            // nupymin
            // 
            nupymin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nupymin.DecimalPlaces = 1;
            nupymin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupymin.Location = new System.Drawing.Point(604, 85);
            nupymin.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            nupymin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nupymin.Name = "nupymin";
            nupymin.Size = new System.Drawing.Size(51, 23);
            nupymin.TabIndex = 8;
            nupymin.Value = new decimal(new int[] { 12, 0, 0, -2147418112 });
            nupymin.Visible = false;
            nupymin.ValueChanged += OnChangedYmin;
            // 
            // lymax
            // 
            lymax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lymax.AutoSize = true;
            lymax.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            lymax.Location = new System.Drawing.Point(517, 117);
            lymax.Name = "lymax";
            lymax.Size = new System.Drawing.Size(41, 20);
            lymax.TabIndex = 11;
            lymax.Text = "Ymin";
            lymax.Visible = false;
            // 
            // nupymax
            // 
            nupymax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nupymax.DecimalPlaces = 1;
            nupymax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupymax.Location = new System.Drawing.Point(604, 114);
            nupymax.Name = "nupymax";
            nupymax.Size = new System.Drawing.Size(51, 23);
            nupymax.TabIndex = 10;
            nupymax.Value = new decimal(new int[] { 12, 0, 0, 65536 });
            nupymax.Visible = false;
            nupymax.ValueChanged += OnChangedYmax;
            // 
            // func1
            // 
            func1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            func1.AutoSize = true;
            func1.Checked = true;
            func1.Location = new System.Drawing.Point(517, 158);
            func1.Name = "func1";
            func1.Size = new System.Drawing.Size(14, 13);
            func1.TabIndex = 12;
            func1.TabStop = true;
            func1.UseVisualStyleBackColor = true;
            func1.CheckedChanged += SwitchFunk1;
            // 
            // func2
            // 
            func2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            func2.AutoSize = true;
            func2.Location = new System.Drawing.Point(517, 215);
            func2.Name = "func2";
            func2.Size = new System.Drawing.Size(14, 13);
            func2.TabIndex = 13;
            func2.UseVisualStyleBackColor = true;
            func2.CheckedChanged += SwitchFunk2;
            // 
            // pfunc1
            // 
            pfunc1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pfunc1.Image = Properties.Resources.func1;
            pfunc1.Location = new System.Drawing.Point(537, 143);
            pfunc1.Name = "pfunc1";
            pfunc1.Size = new System.Drawing.Size(118, 44);
            pfunc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pfunc1.TabIndex = 14;
            pfunc1.TabStop = false;
            pfunc1.Click += CheckedFunk1;
            // 
            // pfunc2
            // 
            pfunc2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pfunc2.Image = Properties.Resources.funk2;
            pfunc2.Location = new System.Drawing.Point(537, 199);
            pfunc2.Name = "pfunc2";
            pfunc2.Size = new System.Drawing.Size(118, 37);
            pfunc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pfunc2.TabIndex = 15;
            pfunc2.TabStop = false;
            pfunc2.Click += CheckedFunk2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(667, 324);
            Controls.Add(pfunc2);
            Controls.Add(pfunc1);
            Controls.Add(func2);
            Controls.Add(func1);
            Controls.Add(lymax);
            Controls.Add(nupymax);
            Controls.Add(lymin);
            Controls.Add(nupymin);
            Controls.Add(showY);
            Controls.Add(lpoints);
            Controls.Add(lxmax);
            Controls.Add(lxmin);
            Controls.Add(nuppoints);
            Controls.Add(nupxmax);
            Controls.Add(nupxmin);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)nupxmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupxmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuppoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupymin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupymax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pfunc1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pfunc2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown nupxmin;
        private System.Windows.Forms.NumericUpDown nupxmax;
        private System.Windows.Forms.NumericUpDown nuppoints;
        private System.Windows.Forms.Label lxmin;
        private System.Windows.Forms.Label lxmax;
        private System.Windows.Forms.Label lpoints;
        private System.Windows.Forms.Button showY;
        private System.Windows.Forms.Label lymin;
        private System.Windows.Forms.NumericUpDown nupymin;
        private System.Windows.Forms.Label lymax;
        private System.Windows.Forms.NumericUpDown nupymax;
        private System.Windows.Forms.RadioButton func1;
        private System.Windows.Forms.RadioButton func2;
        private System.Windows.Forms.PictureBox pfunc1;
        private System.Windows.Forms.PictureBox pfunc2;
    }
}

